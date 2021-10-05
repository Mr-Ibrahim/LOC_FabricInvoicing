using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AS_CustomizedMethods;
using AS_ExceptionHandler;
using AS_SharedParameter;
using AS_DynamicAccessLogic;

namespace LOC_FabricInvoicing.ApplicationForms
{
    public partial class Frm_DivisionCreate : Form
    {
        string Who = AS_CustomizedMethods.StringBuilder_Modi.WhoAmI();
        public Frm_DivisionCreate()
        {
            InitializeComponent();
            FormOnload();
        }
        private void FormOnload() 
        {
            var query01 = "SELECT DISTINCT [DIVISION] FROM [FICDBSRV].[dbo].[INVOICEDIVISION]";
            var _DataTable01 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query01, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable01, txt_DivisionName, 0);

            var query02 = "SELECT DISTINCT [ENTITY] FROM [FICDBSRV].[dbo].[LEGALENTITY]";
            var _DataTable02 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query02, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable02, txt_Entity, 0);
        }
        private void btn_AddDivision_Click(object sender, EventArgs e)
        {
            if (txt_DivisionName.Text.ConvertToTrim() == string.Empty)
            {
                MessageBox.Show("Division is required.");
                txt_DivisionName.Focus();
            }
            else if (txt_Initials.Text.ConvertToTrim() == string.Empty)
            {
                MessageBox.Show("Initials is required.");
                txt_Initials.Focus();
            }
            else if (txt_Entity.Text.ConvertToTrim() == string.Empty)
            {
                MessageBox.Show("Entity is required.");
                txt_Entity.Focus();
            }
            else 
            {
                CreateEntity();
            }
        }
        private void CreateEntity() 
        {
            var Record = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT FOOTER + 1 FROM [dbo].[COMBINEHIERARCHY] AS [CHE] WHERE [CHE].[HEADER] = 'RECID'"), SQLConnectionState.CloseOnExit);

            List<string> list = new List<string>();

            list.Add(txt_DivisionName.Text);
            list.Add(txt_Initials.Text);
            list.Add(txt_Entity.Text.Trim().ToUpper() == "ALMIRAH" ? 567894310.ToString() : txt_Entity.Text.Trim().ToUpper() == "JUNAID JAMSHED" ? 567894320.ToString() : 0.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Record.ToString());

            String[] _StringArray = list.ToArray();
            dynamic value = AppMain.AppObject.DatabaseAction.ReadAndWrite.InsertSQLData("INVOICEDIVISION", _StringArray);

            MessageBox.Show($"New Record count: {value}, row have been added successfully.");

            string Query = $"UPDATE [dbo].[COMBINEHIERARCHY] SET BODY = 'INVOICEDIVISION', FOOTER = {Record.ToString()} WHERE HEADER = 'RECID'";
            AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLNonQuery(Query, SQLConnectionState.CloseOnExit);
            Null_TextFields();
        }
        private void Null_TextFields() 
        {
            txt_DivisionName.Text = txt_Initials.Text = txt_Entity.Text = "";
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
