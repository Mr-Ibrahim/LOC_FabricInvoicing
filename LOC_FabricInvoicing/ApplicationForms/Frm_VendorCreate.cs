using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AS_CustomizedMethods;
using AS_ExceptionHandler;
using AS_SharedParameter;
using AS_DynamicAccessLogic;

namespace LOC_FabricInvoicing.ApplicationForms
{
    public partial class Frm_VendorCreate : Form
    {
        string Who = AS_CustomizedMethods.StringBuilder_Modi.WhoAmI();
        public Frm_VendorCreate()
        {
            InitializeComponent();
            FormOnload();
        }
        private void FormOnload()
        {
            var query01 = "SELECT DISTINCT [SUPPLIER] FROM [FICDBSRV].[dbo].[SUPPLIERSINFO]";
            var _DataTable01 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query01, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable01, txt_VendorName, 0);

            var query02 = "SELECT DISTINCT [DIVISION] FROM [FICDBSRV].[dbo].[INVOICEDIVISION]";
            var _DataTable02 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query02, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable02, txt_Division, 0);
        }
        private void CreateVendor()
        {
            var Record = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT FOOTER + 1 FROM [dbo].[COMBINEHIERARCHY] AS [CHE] WHERE [CHE].[HEADER] = 'RECID'"), SQLConnectionState.CloseOnExit);

            List<string> list = new List<string>();

            list.Add(txt_VendorName.Text.ConvertToUpperTrim());
            list.Add(AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT[RECID] FROM[FICDBSRV].[dbo].[INVOICEDIVISION] WHERE DIVISION = '{0}'", txt_Division.Text), SQLConnectionState.CloseOnExit).ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Record.ToString());

            String[] _StringArray = list.ToArray();
            dynamic value = AppMain.AppObject.DatabaseAction.ReadAndWrite.InsertSQLData("SUPPLIERSINFO", _StringArray);

            MessageBox.Show($"New Record count: {value}, row have been added successfully.");

            string Query = $"UPDATE [dbo].[COMBINEHIERARCHY] SET BODY = 'SUPPLIERSINFO', FOOTER = {Record.ToString()} WHERE HEADER = 'RECID'";
            AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLNonQuery(Query, SQLConnectionState.CloseOnExit);
            Null_TextFields();
        }
        private void Null_TextFields()
        {
            txt_VendorName.Text = txt_Division.Text = "";
        }

        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
            if (txt_VendorName.Text.ConvertToTrim() == string.Empty)
            {
                MessageBox.Show("Division is required.");
                txt_VendorName.Focus();
            }
            else if (txt_Division.Text.ConvertToTrim() == string.Empty)
            {
                MessageBox.Show("Initials is required.");
                txt_Division.Focus();
            }
            else
            {
                CreateVendor();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Null_TextFields();
        }

        private void btn_BackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void pnl_MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Form_inhand.MouseControl(sender, e, Handle);
        }
    }
}
