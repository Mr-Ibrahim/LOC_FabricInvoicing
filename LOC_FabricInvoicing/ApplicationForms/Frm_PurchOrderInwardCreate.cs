using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AS_CustomizedMethods;
using AS_ExceptionHandler;
using AS_SharedParameter;
using AS_DynamicAccessLogic;

namespace LOC_FabricInvoicing.ApplicationForms
{
    public partial class Frm_PurchOrderInwardCreate : Form
    {
        string Who = AS_CustomizedMethods.StringBuilder_Modi.WhoAmI();
        public Frm_PurchOrderInwardCreate()
        {
            InitializeComponent();
            FormOnload();
            this.KeyPreview = true;
        }
        private void FormOnload() 
        {
            var query01 = "SELECT DISTINCT [PURCHORDER] FROM [FICDBSRV].[dbo].[PURCHORDERINWARD]";
            var _DataTable01 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query01, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable01, txt_PurchOrder, 0);

            var query02 = "SELECT DISTINCT [INWARD] FROM [FICDBSRV].[dbo].[PURCHORDERINWARD]";
            var _DataTable02 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query02, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable02, txt_Inward, 0);
        }
        private void btn_AddDivision_Click(object sender, EventArgs e)
        {
            if (lbl_ValuesPurchOrder.Text.ConvertToTrim() == string.Empty)
            {
                MessageBox.Show("Division is required.");
                txt_PurchOrder.Focus();
            }
            else if (lbl_ValuesInward.Text.ConvertToTrim() == string.Empty)
            {
                MessageBox.Show("Initials is required.");
                txt_Inward.Focus();
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

            list.Add(lbl_ValuesPurchOrder.Text);
            list.Add(lbl_ValuesInward.Text);
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Record.ToString());

            String[] _StringArray = list.ToArray();
            dynamic value = AppMain.AppObject.DatabaseAction.ReadAndWrite.InsertSQLData("PURCHORDERINWARD", _StringArray);

            MessageBox.Show($"New Record count: {value}, row have been added successfully.");

            string Query = $"UPDATE [dbo].[COMBINEHIERARCHY] SET BODY = 'PURCHORDERINWARD', FOOTER = {Record.ToString()} WHERE HEADER = 'RECID'";
            AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLNonQuery(Query, SQLConnectionState.CloseOnExit);
            Null_TextFields();
        }
        private void Null_TextFields() 
        {
            txt_PurchOrder.Text = txt_Inward.Text = "";
            lbl_ValuesPurchOrder.Text = lbl_ValuesInward.Text = "";
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
        public void Purch_Seprator()
        {
            if (txt_PurchOrder.Text.ConvertToTrim() == string.Empty)
                MessageBox.Show("No values to append.");
            else
            {
                if (lbl_ValuesPurchOrder.Text != "")
                    lbl_ValuesPurchOrder.Text += ", " + txt_PurchOrder.Text;
                else
                    lbl_ValuesPurchOrder.Text = txt_PurchOrder.Text;

                txt_PurchOrder.Text = "";
                txt_PurchOrder.Focus();
            }
        }
        private void btn_Separator1_Click(object sender, EventArgs e)
        {
            Purch_Seprator();
        }
        private void txt_PurchOrder_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyCode == Keys.Enter)
            {
                Purch_Seprator();
            }
        }
        public void Inward_Seprator()
        {
            if (txt_Inward.Text.ConvertToTrim() == string.Empty)
                MessageBox.Show("No values to append.");
            else
            {
                if (lbl_ValuesInward.Text != "")
                    lbl_ValuesInward.Text += ", " + txt_Inward.Text;
                else
                    lbl_ValuesInward.Text = txt_Inward.Text;

                txt_Inward.Text = "";
                txt_Inward.Focus();
            }
        }
        private void btn_Separator2_Click(object sender, EventArgs e)
        {
            Inward_Seprator();
        }
        private void txt_Inward_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Inward_Seprator();
            }
        }
    }
}
