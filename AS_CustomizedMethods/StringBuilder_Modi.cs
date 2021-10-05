using AS_ExceptionHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace AS_CustomizedMethods
{
    public static class StringBuilder_Modi
    {
        #region FORCE CONVERSION TO STRING TYPE
        public static string ConvertToString(this object value)
        {
            string StringResult = null;
            try
            {
                if (value == null)
                    return "";
            }
            catch (AS_Exception)
            {
                StringResult = "";
            }
            finally
            {
                StringResult = Convert.ToString(value);
            }
            return StringResult;
        }
        public static string ConvertToLower(this object value)
        {
            return value.ConvertToString().ToLower();
        }
        public static string ConvertToUpper(this object value)
        {
            return value.ConvertToString().ToUpper();
        }
        public static string ConvertToTrim(this object value)
        {
            return value.ToString().Trim();
        }
        public static string ConvertToLowerTrim(this object value)
        {
            return value.ConvertToLower().Trim();
        }
        public static string ConvertToUpperTrim(this object value)
        {
            return value.ConvertToUpper().Trim();
        }
        #endregion

        #region FORCE CONVERSION TO NUMERICAL DATA TYPES
        public static decimal ConvertToDecimal(this object Value)
        {
            decimal DecimalResult = 0;
            try
            {
                if (Value.ConvertToTrim() == "") 
                {
                    return DecimalResult;
                }
                DecimalResult = Convert.ToDecimal(Value);
            }
            catch (AS_Exception)
            {
                DecimalResult = 0;
            }
            return DecimalResult;
        }
        public static int ConvertToInt32(this object value)
        {
            int IntegerResult = 0;
            try
            {
                if (value.ConvertToTrim() == "")
                {
                    return IntegerResult;
                }
                value = Convert.ToInt32(value.ConvertToDecimal());
            }
            catch (AS_Exception x)
            {
                IntegerResult = 0;
                throw x;
            }
            return IntegerResult;
        }
        public static int ConvertToInt64(this object value)
        {
            int IntegerResult = 0;
            try
            {
                if (value.ConvertToTrim() == "")
                {
                    return IntegerResult;
                }
                value = Convert.ToInt64(value);
            }
            catch (AS_Exception x)
            {
                IntegerResult = 0;
                throw x;
            }
            return IntegerResult;
        }
        public static string ConvertToAmount(this object value) 
        {
            string specifier = "F2";
            if (value.ConvertToTrim().Count(x => x.ToString() == ".") > 1) 
            {
                value = value.ConvertToTrim().Substring(0, value.ConvertToTrim().Length - 3);
            }
            return value.ConvertToDecimal().ToString(specifier, CultureInfo.InvariantCulture);
        }
        public static string ConvertToLineID(this object value) 
        {
            return value.ConvertToInt32().ToString("0000");
        }
        #endregion

        #region CONVERSTION OF DATE AND TIME TO DESIRE FORMAT
        public static DateTime ConvertToDateTime(this object value, string DateFormat = "dd/MM/yyyy") 
        {
            string TryParseDateFormat = DateFormat;
            DateTime DateTimeResult = new DateTime(1900, 01, 01);
            try
            {
                if (value.ConvertToTrim() == "") 
                {
                    return DateTimeResult;
                }
                try
                {
                    DateTimeResult = Convert.ToDateTime(value);
                }
                catch (FormatException)
                {
                    DateTimeResult = new DateTime(1900, 01, 01);
                }
                if (DateTimeResult.Date < Convert.ToDateTime("1900-01-01").Date) 
                {
                    DateTimeResult = Convert.ToDateTime("1900-01-01");
                }
            }
            catch (AS_Exception) 
            {
                DateTimeResult = Convert.ToDateTime("1900-01-01");
            }
            return DateTimeResult;
        }
        public static DateTime ConvertToDate(this object value) 
        {
            return value.ConvertToDateTime().Date;
        }
        public static TimeSpan ConvertToTime(this object value)
        {
            TimeSpan TimeResult = Convert.ToDateTime("00:00:00").TimeOfDay;
            try
            {
                if (value.ConvertToTrim() == "") 
                {
                    return TimeResult;
                }
                TimeResult = Convert.ToDateTime(value).TimeOfDay;
            }
            catch (AS_Exception)
            {
                TimeResult = Convert.ToDateTime("00:00:00").TimeOfDay;
            }
            return TimeResult;
        }
        //public static TimeSpan SecondsToTime(this object value) 
        //{
        //    TimeSpan TimeResult = Convert.ToDateTime("00:00:00").TimeOfDay;
        //    TimeSpan _TimeSpan;
        //    try
        //    {
        //        TimeSpan t = TimeSpan.FromSeconds(double.Parse((string)value));
        //        TimeReturn = string.Format(@"{0:D2}:{1:D2}:{2:D2}:{3:D3}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
        //    }
        //    catch(Exception)
        //    {
        //        TimeReturn = string.Format("{0:D2}:{1:D2}", t.Hours, t.Minutes);
        //    }
        //    return TimeReturn;
        //}
        #endregion

        public static bool ContainsDataTable(this DataSet _DataSet) 
        {
            return _DataSet != null && _DataSet.Tables.Count > 0;
        }

        public static bool IsNullOrEmpty(this object value) 
        {
            return value.ConvertToTrim() == "";
        }

        public static string WhoAmI() 
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }
            return false;
        }

        public static string SpecialCharToString(this object value)
        {
            string StringResult = null;
            try
            {
                if (value == null)
                    return "";
            }
            catch (AS_Exception)
            {
                StringResult = "";
            }
            finally
            {
                bool Result = hasSpecialChar(value.ToString());
                if (Result == true)
                {
                    StringResult = value.ToString().Replace("'", "''");
                }
                else 
                {
                    StringResult = value.ToString();
                }
            }
            return StringResult;
        }

        public static dynamic AutoComplete_StringCollection(DataTable _DataTable, TextBox _TextBox, int Column) 
        {
            try
            {
                AutoCompleteStringCollection _AutoCompleteStringCollection = new AutoCompleteStringCollection();
                for (int i = 0; i < _DataTable.Rows.Count; i++)
                {
                    _AutoCompleteStringCollection.Add(_DataTable.Rows[i][Column].ToString());
                }
                _TextBox.AutoCompleteCustomSource = _AutoCompleteStringCollection;
                _TextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                _TextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (AS_Exception x)
            {
                throw x;
            }
            return _DataTable;
        }
    }
}