using AS_DynamicAccessLogic;
using AS_ExceptionHandler;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AS_CustomizedMethods;
using System.Data.SqlTypes;

namespace AS_SQLAccessLogic
{
    public class DatabaseInitialization
    {
        public string Instance { get; private set; }
        public string Database { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string SqlConnection_String { get; private set; }

        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        private SqlDataAdapter _sqlDataAdapter;
        private SqlBulkCopy _sqlBulkCopy;

        public DatabaseInitialization(string _instance, string _database, string _username, string _password)
        {
            Instance = _instance;
            Database = _database;
            Username = _username;
            Password = _password;

            BuildSQLConnection();
        }
        public void BuildSQLConnection()
        {
            SqlConnection_String = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};", Instance, Database, Username, Password);
        }
        public void OpenSQLConnection()
        {
            try
            {
                if (_sqlConnection == null || _sqlConnection.State != ConnectionState.Open && _sqlCommand.Transaction == null) 
                {
                    _sqlConnection = new SqlConnection(SqlConnection_String);
                    _sqlCommand = new SqlCommand {CommandType = CommandType.Text, Connection = _sqlConnection};
                    _sqlConnection.Open();
                }
            }
            catch (AS_Exception x) 
            {
                throw x;
            }
            finally
            {
            }
        }
        public SqlConnection _OpenSQLConnection()
        {
            try
            {
                if (_sqlConnection == null || _sqlConnection.State != ConnectionState.Open && _sqlCommand.Transaction == null)
                {
                    _sqlConnection = new SqlConnection(SqlConnection_String);
                    _sqlCommand = new SqlCommand { CommandType = CommandType.Text, Connection = _sqlConnection };
                    _sqlConnection.Open();
                }
            }
            catch (AS_Exception x)
            {
                throw x;
            }
            finally
            {
            }
            return _sqlConnection;
        }
        public void CloseSQLConnection()
        {
            try
            {
                if (_sqlConnection != null || _sqlConnection.State != ConnectionState.Closed)
                {
                    _sqlCommand = null;
                    _sqlConnection.Close();
                    _sqlConnection = null;
                }
            }
            catch (AS_Exception x)
            {
                throw x;
            }
            finally
            {
            }
        }
        public void BeginSQLTransaction()
        {
            try
            {
                if (_sqlCommand != null && _sqlCommand.Transaction != null)
                {
                    return;
                }
                OpenSQLConnection();
                _sqlCommand.Transaction = _sqlConnection.BeginTransaction();
            }
            catch (AS_Exception x)
            {
                CloseSQLConnection();
                throw x;
            }
            finally
            {
            }
        }
        public void ReverseSQLTransaction()
        {
            try
            {
                if (_sqlCommand != null && _sqlCommand.Transaction != null)
                {
                    _sqlCommand.Transaction.Rollback();
                }
                CloseSQLConnection();
            }
            catch (AS_Exception x)
            {
                CloseSQLConnection();
                throw x;
            }
            finally
            {
            }
        }
        public void CommitSQLTransaction() 
        {
            try
            {
                if (_sqlCommand != null && _sqlCommand.Transaction != null)
                {
                    _sqlCommand.Transaction.Commit();
                }
                CloseSQLConnection();
            }
            catch (AS_Exception x) 
            {
                ReverseSQLTransaction();
                throw x;
            }
            finally
            {
            }
        }
        public void ExecuteSqlBulkCopy(string TableName, string[] _Mapping, DataTable _DataTable)
        {
            bool Success;
            try
            {
                SqlBulkCopy _sqlBulkCopy = new SqlBulkCopy(_OpenSQLConnection());
                for (int i = 0; i < _Mapping.Length; i++)
                {
                    _sqlBulkCopy.ColumnMappings.Add(_Mapping[i].ToString(), _Mapping[i].ToString());
                }
                _sqlBulkCopy.BulkCopyTimeout = 0;
                _sqlBulkCopy.DestinationTableName = TableName;
                _sqlBulkCopy.WriteToServer(_DataTable);

            }
            catch (SqlException x)
            {
                Success = false;
                CloseSQLConnection();
                throw x;
            }
        }
        public DataSet ExecuteSQLDataSet(string query, SQLConnectionState ThisConnectionState = SQLConnectionState.CloseOnExit) 
        {
            var Dataset = new DataSet();
            try
            {
                try
                {
                    if (query.ConvertToTrim() == "" || query.ConvertToTrim().Contains("<G<") || query.ConvertToTrim().Contains("<T<")) 
                    {
                        return null;
                    }
                    OpenSQLConnection();
                    _sqlCommand.CommandText = query;
                    _sqlCommand.CommandTimeout = 0;

                    _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                    _sqlDataAdapter.Fill(Dataset);
                    if (ThisConnectionState == SQLConnectionState.CloseOnExit) 
                    {
                        CloseSQLConnection();
                    }
                }
                catch (AS_Exception x)
                {
                    throw new AS_Exception(x.Message);
                }
            }
            catch (AS_Exception)
            {
                ReverseSQLTransaction();
                throw;
            }
            return Dataset;
        }

        public DataTable ExecuteSQLDataTable(string query, int i, SQLConnectionState ThisConnectionState = SQLConnectionState.CloseOnExit) 
        {
            var _DataTable = new DataTable();
            try
            {
                var _DataSet = ExecuteSQLDataSet(query, ThisConnectionState);
                if (_DataSet.ContainsDataTable()) 
                {
                    _DataTable = _DataSet.Tables[i];
                    _DataSet.Tables.Clear();
                }
            }
            catch (AS_Exception x)
            {
                throw x;
            }
            return _DataTable;
        }

        public object ExecuteSQLScalar(string query, SQLConnectionState ThisConnectionState = SQLConnectionState.CloseOnExit)
        {
            object result = null;
            try
            {
                if (query.IsNullOrEmpty()) return null;

                try
                {
                    BeginSQLTransaction();
                    _sqlCommand.CommandText = query;
                    result = _sqlCommand.ExecuteScalar();

                    if (ThisConnectionState == SQLConnectionState.CloseOnExit)
                        CommitSQLTransaction();
                }
                catch (SqlException ex)
                {
                    throw new AS_Exception(ex.Message);
                }
            }
            catch (AS_Exception ex)
            {
                ReverseSQLTransaction();
                throw ex;
            }
            return result;
        }

        public object ExecuteSQLNonQuery(string query, SQLConnectionState ThisConnectionState = SQLConnectionState.CloseOnExit)
        {
            object RowsAffected = null;
            try
            {
                if (query.IsNullOrEmpty() || query.ConvertToTrim().Contains("<G<") || query.ConvertToTrim().Contains("<T<")) 
                {
                    return null;
                }

                try
                {
                    BeginSQLTransaction();
                    _sqlCommand.CommandText = query;
                    RowsAffected = _sqlCommand.ExecuteNonQuery();

                    if (ThisConnectionState == SQLConnectionState.CloseOnExit)
                        CommitSQLTransaction();
                }
                catch (SqlException ex)
                {
                    throw new AS_Exception(ex.Message);
                }
            }
            catch (SqlException x)
            {
                ReverseSQLTransaction();
                throw x;
            }
            return RowsAffected;
        }

        public dynamic InsertSQLData(string TableName, string[] _string, SQLConnectionState ThisConnectionState = SQLConnectionState.CloseOnExit) 
        {
            object RowsAffected = null;

            try
            {
                DataTable _DataTable_YPK = ExecuteSQLDataTable(string.Format("DECLARE @VALUE NVARCHAR (200), @TABLE_NAME NVARCHAR (100) SET @TABLE_NAME = '{0}' SET @VALUE = (SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE WHERE TABLE_NAME = @TABLE_NAME) SELECT ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TABLE_NAME AND COLUMN_NAME != @VALUE", TableName), 0, SQLConnectionState.CloseOnExit);
                DataTable _DataTable_NPK = ExecuteSQLDataTable(string.Format("DECLARE @TABLE_NAME NVARCHAR (100) SET @TABLE_NAME = '{0}' SELECT ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TABLE_NAME", TableName), 0, SQLConnectionState.CloseOnExit);

                DataTable _DataTable = _DataTable_YPK;

                if (_DataTable_YPK.Rows.Count == 0)
                {
                    _DataTable = _DataTable_NPK;
                }
                else
                {
                    _DataTable = _DataTable_YPK;
                }

                var QueryBeforeValue = new StringBuilder(string.Format("INSERT INTO [DBO].[{0}](", TableName));
                var QueryAfterValue = new StringBuilder("(");

                for (int i = 0; i < _DataTable.Rows.Count; i++)
                {
                    var COLUMN_NAME = _DataTable.Rows[i]["COLUMN_NAME"].ToString();

                    int condition = i < _DataTable.Rows.Count - 1 ? 0 : 1;
                    switch (condition)
                    {
                        case 0:
                            QueryBeforeValue.Append(string.Format("[{0}], ", COLUMN_NAME));
                            QueryAfterValue.Append(string.Format("@{0}, ", COLUMN_NAME));
                            break;
                        case 1:
                            QueryBeforeValue.Append(string.Format("[{0}])VALUES ", COLUMN_NAME));
                            QueryAfterValue.Append(string.Format("@{0})", COLUMN_NAME));
                            break;
                    }
                }

                BeginSQLTransaction();
                _sqlCommand.CommandText = string.Format("{0} {1}", QueryBeforeValue, QueryAfterValue);

                for (int i = 0; i < _DataTable.Rows.Count; i++)
                {
                    var ORDINAL_POSITION = _DataTable.Rows[i]["ORDINAL_POSITION"].ToString();
                    var COLUMN_NAME = _DataTable.Rows[i]["COLUMN_NAME"].ToString();
                    var DATA_TYPE = _DataTable.Rows[i]["DATA_TYPE"].ToString();
                    var CHARACTER_MAXIMUM_LENGTH = _DataTable.Rows[i]["CHARACTER_MAXIMUM_LENGTH"].ToString();
                    var IS_NULLABLE = _DataTable.Rows[i]["IS_NULLABLE"].ToString();

                    dynamic _DATA_TYPE = typeof(SqlDbType);
                    int _CML;

                    if (CHARACTER_MAXIMUM_LENGTH == null || CHARACTER_MAXIMUM_LENGTH == "")
                    {
                        _CML = 0;
                    }
                    else
                    {
                        _CML = Int32.Parse(CHARACTER_MAXIMUM_LENGTH);
                    }

                    try
                    {
                        switch (DATA_TYPE)
                        {
                            case "int":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.Int).Value = _string[i].ToString();
                                break;
                            case "nvarchar":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.NVarChar).Value = _string[i].ToString();
                                break;
                            case "varchar":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.VarChar).Value = _string[i].ToString();
                                break;
                            case "bigint":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.BigInt).Value = _string[i].ToString();
                                break;
                            case "datetime":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.DateTime).Value = _string[i].ToString();
                                break;
                            case "float":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.Float).Value = _string[i].ToString();
                                break;
                            case "money":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.Money).Value = _string[i].ToString();
                                break;
                            case "numeric":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.Decimal).Value = _string[i].ToString();
                                break;
                            case "bit":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.Bit).Value = _string[i].ToString();
                                break;
                            case "text":
                                _sqlCommand.Parameters.Add(string.Format("@{0}", COLUMN_NAME), SqlDbType.Text).Value = _string[i].ToString();
                                break;
                        }
                    }
                    catch (SqlException x)
                    {
                        MessageBox.Show(x.Message);
                        throw x;
                    }
                }
                RowsAffected = _sqlCommand.ExecuteNonQuery();

                if (ThisConnectionState == SQLConnectionState.CloseOnExit)
                    CommitSQLTransaction();
            }
            catch (SqlException ex)
            {
                throw new AS_Exception(ex.Message);
            }
            return RowsAffected;
        }
    }
}
