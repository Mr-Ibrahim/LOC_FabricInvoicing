using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AS_CustomizedMethods;
using AS_ExceptionHandler;
using AS_SharedParameter;
using AS_DynamicAccessLogic;
using System.Data;
using System.Threading;

namespace LOC_FabricInvoicing.ApplicationForms
{
    public partial class Frm_InvoiceCreate : Form
    {
        string Who = AS_CustomizedMethods.StringBuilder_Modi.WhoAmI();
        float Qty, Price, Tax, Final;

        public Frm_InvoiceCreate()
        {
            InitializeComponent();
            on_Load();
            btn_BackToMain.Hide();
            txt_Status.SelectedIndex = 0; txt_RecSub.SelectedIndex = 0;
            txt_Tax.Text = "17";
        }
        private void on_Load(bool refresh = false) 
        {
            var query01 = "SELECT DISTINCT [DIVISION] FROM [FICDBSRV].[dbo].[INVOICEDIVISION]";
            var _DataTable01 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query01, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable01, txt_DivisionName, 0);

            var query02 = "SELECT DISTINCT [SUPPLIER] FROM [FICDBSRV].[dbo].[SUPPLIERSINFO]";
            var _DataTable02 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query02, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable02, txt_VendorName, 0);

            var query03a = string.Format("SELECT [PURCHORDER] FROM [FICDBSRV].[dbo].[PURCHORDERINWARD]");
            var _DataTable03a = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query03a, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable03a, txt_Purchase, 0);

            var query03b = string.Format("SELECT [INWARD] FROM [FICDBSRV].[dbo].[PURCHORDERINWARD]");
            var _DataTable03b = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query03b, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable03b, txt_Inward, 0);

            var query04 = "SELECT [CONTACTPERSONSTORE] FROM [FICDBSRV].[dbo].[CONTACTLINK]";
            var _DataTable04 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query04, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable04, txt_ConcernPerson, 0);

            var query05 = "SELECT DISTINCT [DESIGNREFERENCE] FROM [FICDBSRV].[dbo].[PURCHTRANSACTIONLINES]";
            var _DataTable05 = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataTable(query05, 0, SQLConnectionState.CloseOnExit);
            StringBuilder_Modi.AutoComplete_StringCollection(_DataTable05, txt_DesignRef, 0);

            if (refresh) 
            {
                _DataTable01.Clear();
                _DataTable02.Clear();
                _DataTable03a.Clear();
                _DataTable03b.Clear();
                _DataTable04.Clear();
                _DataTable05.Clear();
                on_Load();
            }

            string InvoiceManagement = @"SELECT 
                                        [PTL].[POINWNUM]
                                        , [LET].[ENTITY]
                                        , [IDV].[DIVISION]
                                        , [SIO].[SUPPLIER]
                                        , [POI].[PURCHORDER] AS [PO #]
                                        , [POI].[INWARD] AS [INWARD #]
                                        , [ITR].[INVOICENO] AS [INVOICE #]
                                        , [ITR].[DATE]
                                        , [PTL].[QUANTITY]
                                        , [PTL].[RATE]
                                        , ([PTL].[QUANTITY] * [PTL].[RATE]) AS [TOTAL]
                                        , CASE
                                        WHEN [PTL].[TAX] > 0 THEN ((([PTL].[QUANTITY] * [PTL].[RATE])/100)*[PTL].[TAX])
                                        ELSE 0
                                        END AS[TAX]
                                        , CASE
                                        WHEN [PTL].[TAX] > 0 THEN ([PTL].[QUANTITY] * [PTL].[RATE])+((([PTL].[QUANTITY] * [PTL].[RATE])/100)*[PTL].[TAX])
                                        ELSE ([PTL].[QUANTITY] * [PTL].[RATE])
                                        END AS[TOTAL WITH TAX]
                                        , [PTL].[COMMENT]
                                        , [PTL].[CREDIT]
                                        , [PTL].[DEBIT]
                                        , [CLK].[CONTACTPERSONSTORE] AS [CONTACT]
                                        , [PTL].[DESIGNREFERENCE] AS [DESIGN]
                                        , [PTL].[RECEIVING]
                                        , [PTL].[REMARK]
                                        , [PTL].[CREATEDBY] AS [CREATED BY]
                                        , [PTL].[CREATEDDATETIME] AS [CREATED ON]
                                        FROM [FICDBSRV].[dbo].[PURCHTRANSACTIONLINES] AS [PTL]
                                        LEFT JOIN [DBO].[INVOICEDIVISION] AS [IDV] ON [PTL].[DIVISION] = [IDV].[RECID]
                                        LEFT JOIN [DBO].[LEGALENTITY] AS [LET] ON [IDV].[ENTITY] = [LET].[RECID]
                                        LEFT JOIN [DBO].[SUPPLIERSINFO] AS [SIO] ON [PTL].[VENDORNAME] = [SIO].[RECID]
                                        LEFT JOIN [DBO].[PURCHORDERINWARD] AS [POI] ON [PTL].[POINWNUM] = [POI].[RECID]
                                        LEFT JOIN [DBO].[INVOICETRANSACTIONS] AS [ITR] ON [PTL].[INVOICE] = [ITR].[RECID]
                                        LEFT JOIN [DBO].[CONTACTLINK] AS [CLK] ON [PTL].[CONCERNPERSON] = [CLK].[RECID]";
            DataSet CP_DataSet = AS_SharedParameter.AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLDataSet(InvoiceManagement, SQLConnectionState.CloseOnExit);
            grd_InvoiceManagement.DataSource = CP_DataSet.Tables[0];
            gridView1.Columns[0].Visible = false;
        }

        String GlobalRecordID;

        private void Create_InvoiceEntry() 
        {
            var Record = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT FOOTER + 1 FROM [dbo].[COMBINEHIERARCHY] AS [CHE] WHERE [CHE].[HEADER] = 'RECID'"), SQLConnectionState.CloseOnExit);
            GlobalRecordID = Record.ToString();
            List<string> list = new List<string>();

            list.Add(txt_InvoiceNum.Text);
            list.Add(txt_DateTime.Text);
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Record.ToString());

            String[] _StringArray = list.ToArray();
            dynamic value = AppMain.AppObject.DatabaseAction.ReadAndWrite.InsertSQLData("INVOICETRANSACTIONS", _StringArray);

            string Query = $"UPDATE [dbo].[COMBINEHIERARCHY] SET BODY = 'INVOICETRANSACTIONS', FOOTER = {Record.ToString()} WHERE HEADER = 'RECID'";
            AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLNonQuery(Query, SQLConnectionState.CloseOnExit);
        }

        private void Create_PI_Entry() 
        {
            var RECID = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT RECID FROM [FICDBSRV].[dbo].[PURCHORDERINWARD] WHERE PURCHORDER = '{0}' AND INWARD LIKE '%{1}%'", txt_Purchase.Text, txt_Inward.Text), SQLConnectionState.CloseOnExit);

            if (RECID != null)
            {
                POIW = Convert.ToString(RECID.ToString());
            }
            else 
            {
                var Record = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT FOOTER + 1 FROM [dbo].[COMBINEHIERARCHY] AS [CHE] WHERE [CHE].[HEADER] = 'RECID'"), SQLConnectionState.CloseOnExit);

                List<string> list = new List<string>();

                list.Add(txt_Purchase.Text);
                list.Add(txt_Inward.Text);

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

                var RECID_ = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT RECID FROM [FICDBSRV].[dbo].[PURCHORDERINWARD] WHERE PURCHORDER = '{0}' AND INWARD LIKE '%{1}%'", txt_Purchase.Text, txt_Inward.Text), SQLConnectionState.CloseOnExit);
                POIW = Convert.ToString(RECID_.ToString());
            }
        }
        private void Create_LineEntry()
        {
            var Record = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT FOOTER + 2 FROM [dbo].[COMBINEHIERARCHY] AS [CHE] WHERE [CHE].[HEADER] = 'RECID'"), SQLConnectionState.CloseOnExit);

            List<string> list = new List<string>();

            list.Add(AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT RECID FROM [dbo].[INVOICEDIVISION] WHERE [DIVISION] = '{0}'", txt_DivisionName.Text), SQLConnectionState.CloseOnExit).ToString());
            list.Add(AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT RECID FROM [dbo].[SUPPLIERSINFO] WHERE [SUPPLIER] = '{0}'", txt_VendorName.Text), SQLConnectionState.CloseOnExit).ToString());
            list.Add(POIW.ToString());
            list.Add(GlobalRecordID.ToString());
            list.Add(txt_Quantity.Text);
            list.Add(txt_DateTime.Text);
            list.Add(txt_RecSub.SelectedItem.ToString());
            list.Add(txt_Status.SelectedItem.ToString());
            list.Add(txt_Rate.Text);
            list.Add(txt_NetAmount.Text);
            list.Add(txt_Tax.Text);
            list.Add(txt_NetAmount.Text);
            list.Add(txt_Comments.Text);
            list.Add(txt_CreditNote.Text);
            list.Add(txt_DebitNote.Text);
            list.Add(AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT RECID FROM [dbo].[CONTACTLINK] WHERE [CONTACTPERSONSTORE] = '{0}'", txt_ConcernPerson.Text), SQLConnectionState.CloseOnExit).ToString());
            list.Add(txt_DesignRef.Text);
            list.Add(""); //RECEIVING
            list.Add(txt_Remarks.Text);

            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Who);
            list.Add(DateTime.Now.ToString());
            list.Add(Record.ToString());

            String[] _StringArray = list.ToArray();
            dynamic value = AppMain.AppObject.DatabaseAction.ReadAndWrite.InsertSQLData("PURCHTRANSACTIONLINES", _StringArray);

            MessageBox.Show($"New Record count: {value}, row have been added successfully.");

            string Query = $"UPDATE [dbo].[COMBINEHIERARCHY] SET BODY = 'PURCHTRANSACTIONLINES', FOOTER = {Record.ToString()} WHERE HEADER = 'RECID'";
            AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLNonQuery(Query, SQLConnectionState.CloseOnExit);
            Null_TextFields();
        }
        private void Null_TextFields(bool Partial = false)
        {
            if (Partial)
            {
                txt_Quantity.Text = txt_Rate.Text = txt_NetAmount.Text = txt_Comments.Text = txt_CreditNote.Text = txt_DebitNote.Text = txt_ConcernPerson.Text = txt_DesignRef.Text = txt_Remarks.Text = txt_NetAmount.Text = "";
            }
            else 
            {
                txt_DivisionName.Text = txt_VendorName.Text = txt_Purchase.Text = txt_InvoiceNum.Text = txt_DateTime.Text = "";
                txt_Status.SelectedIndex = 0; txt_RecSub.SelectedIndex = 0;
                txt_Quantity.Text = txt_Rate.Text = txt_NetAmount.Text = "0";
                txt_Comments.Text = txt_CreditNote.Text = txt_DebitNote.Text = txt_ConcernPerson.Text = txt_DesignRef.Text = txt_Remarks.Text = "";
            }
        }

        private void btn_PurchaseOrderInward_Click(object sender, EventArgs e)
        {
            Frm_PurchOrderInwardCreate form = new Frm_PurchOrderInwardCreate();
            form.Show();
        }

        private void btn_ConcernPersonCreate_Click(object sender, EventArgs e)
        {
            Frm_ContactStorePersonCreate form = new Frm_ContactStorePersonCreate();
            form.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            on_Load(true);
        }
        string POIW;

        private void Integer_Only(object sender, KeyPressEventArgs e, dynamic Handle)
        {
            if (e.KeyChar == '.')
            {
                if (this.Text.IndexOf(".") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Create_PI_Entry();
            Create_InvoiceEntry();
            Create_LineEntry();
            on_Load(true);
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integer_Only(sender, e, Handle);
        }

        private void txt_Rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integer_Only(sender, e, Handle);
        }

        private void txt_NetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integer_Only(sender, e, Handle);
        }

        private void txt_CreditNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integer_Only(sender, e, Handle);
        }

        private void txt_DebitNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integer_Only(sender, e, Handle);
        }

        private void Btn_PartialClear_Click(object sender, EventArgs e)
        {
            Null_TextFields(true);
        }

        private void btn_BackToMain_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
        bool Maximized = false;
        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            switch (Maximized)
            {
                case (false):
                    this.WindowState = FormWindowState.Maximized;
                    Maximized = true;
                    break;
                case (true):
                    this.WindowState = FormWindowState.Normal;
                    Maximized = false;
                    break;
                default:
                    break;
            }
        }

        private void grd_InvoiceManagement_DoubleClick(object sender, EventArgs e)
        {
            txt_DivisionName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIVISION").ToString();
            txt_VendorName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SUPPLIER").ToString();
            POIW = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "POINWNUM").ToString();
            txt_InvoiceNum.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "INVOICE #").ToString();
            txt_DateTime.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DATE").ToString();
            txt_Quantity.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QUANTITY").ToString();
            txt_Rate.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "RATE").ToString();
            txt_NetAmount.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TOTAL WITH TAX").ToString();
            txt_Comments.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "COMMENT").ToString();
            txt_CreditNote.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CREDIT").ToString();
            txt_DebitNote.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DEBIT").ToString();
            txt_ConcernPerson.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CONTACT").ToString();
            txt_DesignRef.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DESIGN").ToString();
            txt_Remarks.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "REMARK").ToString();

            //lbl_PurchaseText.Text = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT DISTINCT [PURCHORDER] FROM [FICDBSRV].[dbo].[PURCHORDERINWARD] WHERE RECID = '{0}'", POIW.ToString()), SQLConnectionState.CloseOnExit).ToString();
            //lbl_InwardText.Text = AppMain.AppObject.DatabaseAction.ReadAndWrite.ExecuteSQLScalar(string.Format("SELECT DISTINCT [INWARD] FROM [FICDBSRV].[dbo].[PURCHORDERINWARD] WHERE RECID = '{0}'", POIW.ToString()), SQLConnectionState.CloseOnExit).ToString();
            //lbl_InwardText.Text = lbl_InwardText.Text.Replace(",", " - ");
        }
        private void btn_InvoiceCreate_Click(object sender, EventArgs e)
        {
            Frm_InvoiceCreate form = new Frm_InvoiceCreate();
            form.Show();
        }

        private void btn_DivisionCreate_Click(object sender, EventArgs e)
        {
            Frm_DivisionCreate form = new Frm_DivisionCreate();
            form.Show();
        }

        private void btn_VendorCreate_Click(object sender, EventArgs e)
        {
            Frm_VendorCreate form = new Frm_VendorCreate();
            form.Show();
        }

        private void txt_ClearAll_Click(object sender, EventArgs e)
        {
            Null_TextFields(false);
        }

        private void pan_title_MouseDown(object sender, MouseEventArgs e)
        {
            Form_inhand.MouseControl(sender, e, Handle);
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (grd_InvoiceManagement.DataSource == null)
            {
                MessageBox.Show("Kindly supply Grid with values to export.", "Nothing to Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SaveFileDialog SFD = new SaveFileDialog();
                    SFD.Filter = "Excel workbook (*.xlsx)|*.xlsx| Comma Separated Values (*.csv)|*.csv";
                    DialogResult Dr = SFD.ShowDialog();
                    if (Dr == DialogResult.OK)
                    {
                        gridView1.ExportToXlsx(SFD.FileName);
                    }
                }
                catch (Exception ep)
                {
                    MessageBox.Show(ep.Message);
                }
            }
        }
        private void txt_NetAmount_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quantity.Text != null || txt_Quantity.Text != "" &&
                txt_Rate.Text != null || txt_Rate.Text != ""
                )
            {
                Qty = float.Parse(txt_Quantity.Text);
                Price = float.Parse(txt_Rate.Text);
                Tax = float.Parse(txt_Tax.Text);
                Final = ((Qty * Price) / 100) * Tax + (Qty * Price);
                txt_NetAmount.Text = Final.ToString();
            }
        }
    }
}
