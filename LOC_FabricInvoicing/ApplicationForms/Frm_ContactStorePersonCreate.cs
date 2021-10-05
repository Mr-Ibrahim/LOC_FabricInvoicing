using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AS_CustomizedMethods;
using AS_ExceptionHandler;
using AS_SharedParameter;
using AS_DynamicAccessLogic;

namespace LOC_FabricInvoicing.ApplicationForms
{
    public partial class Frm_ContactStorePersonCreate : Form
    {
        string Who = AS_CustomizedMethods.StringBuilder_Modi.WhoAmI();
        public Frm_ContactStorePersonCreate()
        {
            InitializeComponent();
            FormOnload();
        }
        private void FormOnload()
        {
            var query01 = "SELECT DISTINCT [CONTACTPERSONSTORE] FROM [FICDBSRV].[dbo].[CONTACTLINK]";
            var _DataTable01 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query01, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable01, txt_ContactPerson, 0);
        }
        private void CreateVendor()
        {
            var Record = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT FOOTER + 1 FROM [dbo].[COMBINEHIERARCHY] AS [CHE] WHERE [CHE].[HEADER] = 'RECID'"), SQLConnectionState.CloseOnExit);

            List<string> list = new List<string>();

            list.Add(txt_ContactPerson.Text.ConvertToUpperTrim());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Record.ToString());

            String[] _StringArray = list.ToArray();
            dynamic value = AppMain.AppObject.DatabaseAction.ReadAndWrite.InsertSQLData("CONTACTLINK", _StringArray);

            MessageBox.Show($"New Record count: {value}, row have been added successfully.");

            string Query = $"UPDATE [dbo].[COMBINEHIERARCHY] SET BODY = 'CONTACTLINK', FOOTER = {Record.ToString()} WHERE HEADER = 'RECID'";
            AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLNonQuery(Query, SQLConnectionState.CloseOnExit);
            Null_TextFields();
        }
        private void Null_TextFields()
        {
            txt_ContactPerson.Text = txt_ContactStore.Text = "";
        }

        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
            if (txt_ContactPerson.Text == string.Empty && txt_ContactStore.Text.ConvertToTrim() == string.Empty)
            {
                MessageBox.Show("Either contact person or store is required.");
                txt_ContactPerson.Focus();
            }
            else if (txt_ContactPerson.Text.ConvertToTrim() != string.Empty)
            {
                txt_ContactPerson.Text += " - PER";
                ContactPerson();
            }
            else if (txt_ContactStore.Text.ConvertToTrim() != string.Empty)
            {
                txt_ContactStore.Text += " - STR";
                ContactStore();
            }
        }

        private void ContactPerson()
        {
            var Record = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT FOOTER + 1 FROM [dbo].[COMBINEHIERARCHY] AS [CHE] WHERE [CHE].[HEADER] = 'RECID'"), SQLConnectionState.CloseOnExit);

            List<string> list = new List<string>();

            list.Add(txt_ContactPerson.Text.ConvertToUpperTrim());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Record.ToString());

            String[] _StringArray = list.ToArray();
            dynamic value = AppMain.AppObject.DatabaseAction.ReadAndWrite.InsertSQLData("CONTACTLINK", _StringArray);

            MessageBox.Show($"New Record count: {value}, row have been added successfully.");

            string Query = $"UPDATE [dbo].[COMBINEHIERARCHY] SET BODY = 'CONTACTLINK', FOOTER = {Record.ToString()} WHERE HEADER = 'RECID'";
            AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLNonQuery(Query, SQLConnectionState.CloseOnExit);
            Null_TextFields();
        }
        private void ContactStore()
        {
            var Record = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT FOOTER + 1 FROM [dbo].[COMBINEHIERARCHY] AS [CHE] WHERE [CHE].[HEADER] = 'RECID'"), SQLConnectionState.CloseOnExit);

            List<string> list = new List<string>();

            list.Add(txt_ContactStore.Text.ConvertToUpperTrim());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Record.ToString());

            String[] _StringArray = list.ToArray();
            dynamic value = AppMain.AppObject.DatabaseAction.ReadAndWrite.InsertSQLData("CONTACTLINK", _StringArray);

            MessageBox.Show($"New Record count: {value}, row have been added successfully.");

            string Query = $"UPDATE [dbo].[COMBINEHIERARCHY] SET BODY = 'CONTACTLINK', FOOTER = {Record.ToString()} WHERE HEADER = 'RECID'";
            AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLNonQuery(Query, SQLConnectionState.CloseOnExit);
            Null_TextFields();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Null_TextFields();
            txt_ContactPerson.Enabled = true;
            txt_ContactStore.Enabled = true;
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

        private void txt_ContactPerson_TextChanged(object sender, EventArgs e)
        {
            txt_ContactStore.Enabled = false;
        }

        private void txt_ContactStore_TextChanged(object sender, EventArgs e)
        {
            txt_ContactPerson.Enabled = false;
        }
    }
}
