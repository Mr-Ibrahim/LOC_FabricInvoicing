﻿
namespace LOC_FabricInvoicing.ApplicationForms
{
    partial class Frm_InvoiceCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InvoiceCreate));
            this.pan_title = new System.Windows.Forms.Panel();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_BackToMain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ProductDisplayNumber = new System.Windows.Forms.Label();
            this.lbl_ProductType = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.txt_VendorName = new System.Windows.Forms.TextBox();
            this.txt_Purchase = new System.Windows.Forms.TextBox();
            this.lbl_PrimaryAddress = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_ProductTaxGroup = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NetAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CreditNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DebitNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ConcernPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DesignRef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DivisionName = new System.Windows.Forms.TextBox();
            this.grd_InvoiceManagement = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.btn_ConcernPersonCreate = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Btn_PartialClear = new System.Windows.Forms.Button();
            this.txt_InvoiceNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_DateTime = new System.Windows.Forms.DateTimePicker();
            this.txt_Status = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ClearAll = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.txt_Tax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Inward = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_RecSub = new System.Windows.Forms.ComboBox();
            this.btn_DivisionCreate = new System.Windows.Forms.Button();
            this.btn_VendorCreate = new System.Windows.Forms.Button();
            this.pan_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_InvoiceManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_title
            // 
            this.pan_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.pan_title.Controls.Add(this.btn_Maximize);
            this.pan_title.Controls.Add(this.btn_BackToMain);
            this.pan_title.Controls.Add(this.btn_Exit);
            this.pan_title.Controls.Add(this.label1);
            this.pan_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_title.Location = new System.Drawing.Point(0, 0);
            this.pan_title.Name = "pan_title";
            this.pan_title.Size = new System.Drawing.Size(1080, 45);
            this.pan_title.TabIndex = 9;
            this.pan_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_title_MouseDown);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Maximize.BackgroundImage")));
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Maximize.Location = new System.Drawing.Point(989, 2);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(40, 40);
            this.btn_Maximize.TabIndex = 30;
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_BackToMain
            // 
            this.btn_BackToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BackToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_BackToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackToMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackToMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_BackToMain.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackToMain.Image")));
            this.btn_BackToMain.Location = new System.Drawing.Point(943, 2);
            this.btn_BackToMain.Name = "btn_BackToMain";
            this.btn_BackToMain.Size = new System.Drawing.Size(40, 40);
            this.btn_BackToMain.TabIndex = 29;
            this.btn_BackToMain.UseVisualStyleBackColor = false;
            this.btn_BackToMain.Click += new System.EventHandler(this.btn_BackToMain_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(1035, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.btn_Exit.TabIndex = 31;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Invoice Management Panel";
            // 
            // lbl_ProductDisplayNumber
            // 
            this.lbl_ProductDisplayNumber.AutoSize = true;
            this.lbl_ProductDisplayNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductDisplayNumber.Location = new System.Drawing.Point(59, 14);
            this.lbl_ProductDisplayNumber.Name = "lbl_ProductDisplayNumber";
            this.lbl_ProductDisplayNumber.Size = new System.Drawing.Size(84, 13);
            this.lbl_ProductDisplayNumber.TabIndex = 71;
            this.lbl_ProductDisplayNumber.Text = "Vendor Name :";
            // 
            // lbl_ProductType
            // 
            this.lbl_ProductType.AutoSize = true;
            this.lbl_ProductType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductType.Location = new System.Drawing.Point(93, 139);
            this.lbl_ProductType.Name = "lbl_ProductType";
            this.lbl_ProductType.Size = new System.Drawing.Size(50, 13);
            this.lbl_ProductType.TabIndex = 72;
            this.lbl_ProductType.Text = "Invoice :";
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Product.Location = new System.Drawing.Point(69, 76);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(74, 13);
            this.lbl_Product.TabIndex = 73;
            this.lbl_Product.Text = "PO Number :";
            // 
            // txt_VendorName
            // 
            this.txt_VendorName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_VendorName.Location = new System.Drawing.Point(158, 8);
            this.txt_VendorName.Name = "txt_VendorName";
            this.txt_VendorName.Size = new System.Drawing.Size(184, 25);
            this.txt_VendorName.TabIndex = 1;
            // 
            // txt_Purchase
            // 
            this.txt_Purchase.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Purchase.Location = new System.Drawing.Point(158, 70);
            this.txt_Purchase.Name = "txt_Purchase";
            this.txt_Purchase.Size = new System.Drawing.Size(215, 25);
            this.txt_Purchase.TabIndex = 5;
            // 
            // lbl_PrimaryAddress
            // 
            this.lbl_PrimaryAddress.AutoSize = true;
            this.lbl_PrimaryAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrimaryAddress.Location = new System.Drawing.Point(85, 258);
            this.lbl_PrimaryAddress.Name = "lbl_PrimaryAddress";
            this.lbl_PrimaryAddress.Size = new System.Drawing.Size(58, 13);
            this.lbl_PrimaryAddress.TabIndex = 75;
            this.lbl_PrimaryAddress.Text = "Quantity :";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(158, 250);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(215, 25);
            this.txt_Quantity.TabIndex = 11;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // lbl_ProductTaxGroup
            // 
            this.lbl_ProductTaxGroup.AutoSize = true;
            this.lbl_ProductTaxGroup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductTaxGroup.Location = new System.Drawing.Point(107, 289);
            this.lbl_ProductTaxGroup.Name = "lbl_ProductTaxGroup";
            this.lbl_ProductTaxGroup.Size = new System.Drawing.Size(36, 13);
            this.lbl_ProductTaxGroup.TabIndex = 76;
            this.lbl_ProductTaxGroup.Text = "Rate :";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rate.Location = new System.Drawing.Point(158, 281);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(215, 25);
            this.txt_Rate.TabIndex = 12;
            this.txt_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Rate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Net Amount :";
            // 
            // txt_NetAmount
            // 
            this.txt_NetAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NetAmount.Location = new System.Drawing.Point(158, 347);
            this.txt_NetAmount.Name = "txt_NetAmount";
            this.txt_NetAmount.Size = new System.Drawing.Size(215, 25);
            this.txt_NetAmount.TabIndex = 14;
            this.txt_NetAmount.TextChanged += new System.EventHandler(this.txt_NetAmount_TextChanged);
            this.txt_NetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NetAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Comments / Reason :";
            // 
            // txt_Comments
            // 
            this.txt_Comments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comments.Location = new System.Drawing.Point(158, 379);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(215, 25);
            this.txt_Comments.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Credit Note :";
            // 
            // txt_CreditNote
            // 
            this.txt_CreditNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CreditNote.Location = new System.Drawing.Point(158, 410);
            this.txt_CreditNote.Name = "txt_CreditNote";
            this.txt_CreditNote.Size = new System.Drawing.Size(215, 25);
            this.txt_CreditNote.TabIndex = 16;
            this.txt_CreditNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CreditNote_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Debit Note :";
            // 
            // txt_DebitNote
            // 
            this.txt_DebitNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DebitNote.Location = new System.Drawing.Point(158, 442);
            this.txt_DebitNote.Name = "txt_DebitNote";
            this.txt_DebitNote.Size = new System.Drawing.Size(215, 25);
            this.txt_DebitNote.TabIndex = 17;
            this.txt_DebitNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DebitNote_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Concern Person :";
            // 
            // txt_ConcernPerson
            // 
            this.txt_ConcernPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConcernPerson.Location = new System.Drawing.Point(158, 473);
            this.txt_ConcernPerson.Name = "txt_ConcernPerson";
            this.txt_ConcernPerson.Size = new System.Drawing.Size(184, 25);
            this.txt_ConcernPerson.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Design Reference :";
            // 
            // txt_DesignRef
            // 
            this.txt_DesignRef.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DesignRef.Location = new System.Drawing.Point(158, 504);
            this.txt_DesignRef.Name = "txt_DesignRef";
            this.txt_DesignRef.Size = new System.Drawing.Size(215, 25);
            this.txt_DesignRef.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(88, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Division :";
            // 
            // txt_DivisionName
            // 
            this.txt_DivisionName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_DivisionName.Location = new System.Drawing.Point(158, 39);
            this.txt_DivisionName.Name = "txt_DivisionName";
            this.txt_DivisionName.Size = new System.Drawing.Size(184, 25);
            this.txt_DivisionName.TabIndex = 3;
            // 
            // grd_InvoiceManagement
            // 
            this.grd_InvoiceManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_InvoiceManagement.Location = new System.Drawing.Point(385, 3);
            this.grd_InvoiceManagement.MainView = this.gridView1;
            this.grd_InvoiceManagement.Name = "grd_InvoiceManagement";
            this.grd_InvoiceManagement.Size = new System.Drawing.Size(683, 661);
            this.grd_InvoiceManagement.TabIndex = 28;
            this.grd_InvoiceManagement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grd_InvoiceManagement.DoubleClick += new System.EventHandler(this.grd_InvoiceManagement_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.grd_InvoiceManagement;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Remarks :";
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remarks.Location = new System.Drawing.Point(158, 537);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(215, 36);
            this.txt_Remarks.TabIndex = 21;
            // 
            // btn_ConcernPersonCreate
            // 
            this.btn_ConcernPersonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_ConcernPersonCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ConcernPersonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConcernPersonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_ConcernPersonCreate.Image = ((System.Drawing.Image)(resources.GetObject("btn_ConcernPersonCreate.Image")));
            this.btn_ConcernPersonCreate.Location = new System.Drawing.Point(348, 473);
            this.btn_ConcernPersonCreate.Name = "btn_ConcernPersonCreate";
            this.btn_ConcernPersonCreate.Size = new System.Drawing.Size(25, 25);
            this.btn_ConcernPersonCreate.TabIndex = 19;
            this.btn_ConcernPersonCreate.UseVisualStyleBackColor = false;
            this.btn_ConcernPersonCreate.Click += new System.EventHandler(this.btn_ConcernPersonCreate_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(290, 632);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(90, 30);
            this.btn_Refresh.TabIndex = 27;
            this.btn_Refresh.Text = "&Refresh";
            this.btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(100, 632);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 30);
            this.btn_Save.TabIndex = 25;
            this.btn_Save.Text = "&Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Btn_PartialClear
            // 
            this.Btn_PartialClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_PartialClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Btn_PartialClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_PartialClear.FlatAppearance.BorderSize = 0;
            this.Btn_PartialClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.Btn_PartialClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PartialClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_PartialClear.ForeColor = System.Drawing.Color.White;
            this.Btn_PartialClear.Location = new System.Drawing.Point(99, 596);
            this.Btn_PartialClear.Name = "Btn_PartialClear";
            this.Btn_PartialClear.Size = new System.Drawing.Size(90, 30);
            this.Btn_PartialClear.TabIndex = 22;
            this.Btn_PartialClear.Text = "&Semi Clear";
            this.Btn_PartialClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PartialClear.UseVisualStyleBackColor = false;
            this.Btn_PartialClear.Click += new System.EventHandler(this.Btn_PartialClear_Click);
            // 
            // txt_InvoiceNum
            // 
            this.txt_InvoiceNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvoiceNum.Location = new System.Drawing.Point(158, 133);
            this.txt_InvoiceNum.Name = "txt_InvoiceNum";
            this.txt_InvoiceNum.Size = new System.Drawing.Size(215, 25);
            this.txt_InvoiceNum.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 107;
            this.label12.Text = "Date :";
            // 
            // txt_DateTime
            // 
            this.txt_DateTime.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateTime.Location = new System.Drawing.Point(159, 165);
            this.txt_DateTime.Name = "txt_DateTime";
            this.txt_DateTime.Size = new System.Drawing.Size(215, 25);
            this.txt_DateTime.TabIndex = 8;
            // 
            // txt_Status
            // 
            this.txt_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.FormattingEnabled = true;
            this.txt_Status.Items.AddRange(new object[] {
            "CREATED",
            "PROCUREMENT",
            "CLOSED"});
            this.txt_Status.Location = new System.Drawing.Point(158, 223);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(215, 23);
            this.txt_Status.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(98, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 115;
            this.label13.Text = "Status :";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(195, 632);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(90, 30);
            this.btn_Update.TabIndex = 26;
            this.btn_Update.Text = "&Update";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_ClearAll);
            this.panel2.Controls.Add(this.btn_Excel);
            this.panel2.Controls.Add(this.txt_Tax);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_Inward);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_RecSub);
            this.panel2.Controls.Add(this.btn_DivisionCreate);
            this.panel2.Controls.Add(this.btn_VendorCreate);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_Status);
            this.panel2.Controls.Add(this.txt_DateTime);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_InvoiceNum);
            this.panel2.Controls.Add(this.Btn_PartialClear);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.btn_ConcernPersonCreate);
            this.panel2.Controls.Add(this.txt_Remarks);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.grd_InvoiceManagement);
            this.panel2.Controls.Add(this.txt_DivisionName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_DesignRef);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_ConcernPerson);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_DebitNote);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_CreditNote);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Comments);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_NetAmount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Rate);
            this.panel2.Controls.Add(this.lbl_ProductTaxGroup);
            this.panel2.Controls.Add(this.txt_Quantity);
            this.panel2.Controls.Add(this.lbl_PrimaryAddress);
            this.panel2.Controls.Add(this.txt_Purchase);
            this.panel2.Controls.Add(this.txt_VendorName);
            this.panel2.Controls.Add(this.lbl_Product);
            this.panel2.Controls.Add(this.lbl_ProductType);
            this.panel2.Controls.Add(this.lbl_ProductDisplayNumber);
            this.panel2.Location = new System.Drawing.Point(4, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 667);
            this.panel2.TabIndex = 10;
            // 
            // txt_ClearAll
            // 
            this.txt_ClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.txt_ClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_ClearAll.FlatAppearance.BorderSize = 0;
            this.txt_ClearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.txt_ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_ClearAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ClearAll.ForeColor = System.Drawing.Color.White;
            this.txt_ClearAll.Location = new System.Drawing.Point(195, 596);
            this.txt_ClearAll.Name = "txt_ClearAll";
            this.txt_ClearAll.Size = new System.Drawing.Size(90, 30);
            this.txt_ClearAll.TabIndex = 23;
            this.txt_ClearAll.Text = "&Clear All";
            this.txt_ClearAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txt_ClearAll.UseVisualStyleBackColor = false;
            this.txt_ClearAll.Click += new System.EventHandler(this.txt_ClearAll_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Excel.FlatAppearance.BorderSize = 0;
            this.btn_Excel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.Location = new System.Drawing.Point(290, 596);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(90, 30);
            this.btn_Excel.TabIndex = 24;
            this.btn_Excel.Text = "&Excel";
            this.btn_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Excel.UseVisualStyleBackColor = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // txt_Tax
            // 
            this.txt_Tax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tax.Location = new System.Drawing.Point(158, 314);
            this.txt_Tax.Name = "txt_Tax";
            this.txt_Tax.Size = new System.Drawing.Size(215, 25);
            this.txt_Tax.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(113, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 137;
            this.label14.Text = "Tax :";
            // 
            // txt_Inward
            // 
            this.txt_Inward.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Inward.Location = new System.Drawing.Point(158, 101);
            this.txt_Inward.Name = "txt_Inward";
            this.txt_Inward.Size = new System.Drawing.Size(215, 25);
            this.txt_Inward.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(94, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 135;
            this.label11.Text = "Inward :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 133;
            this.label10.Text = "Rec/Sub :";
            // 
            // txt_RecSub
            // 
            this.txt_RecSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RecSub.FormattingEnabled = true;
            this.txt_RecSub.Items.AddRange(new object[] {
            "RECEIVE",
            "SUBMIT"});
            this.txt_RecSub.Location = new System.Drawing.Point(158, 194);
            this.txt_RecSub.Name = "txt_RecSub";
            this.txt_RecSub.Size = new System.Drawing.Size(215, 23);
            this.txt_RecSub.TabIndex = 9;
            // 
            // btn_DivisionCreate
            // 
            this.btn_DivisionCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_DivisionCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DivisionCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DivisionCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_DivisionCreate.Image = ((System.Drawing.Image)(resources.GetObject("btn_DivisionCreate.Image")));
            this.btn_DivisionCreate.Location = new System.Drawing.Point(348, 39);
            this.btn_DivisionCreate.Name = "btn_DivisionCreate";
            this.btn_DivisionCreate.Size = new System.Drawing.Size(25, 25);
            this.btn_DivisionCreate.TabIndex = 4;
            this.btn_DivisionCreate.UseVisualStyleBackColor = false;
            this.btn_DivisionCreate.Click += new System.EventHandler(this.btn_DivisionCreate_Click);
            // 
            // btn_VendorCreate
            // 
            this.btn_VendorCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_VendorCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_VendorCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VendorCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_VendorCreate.Image = ((System.Drawing.Image)(resources.GetObject("btn_VendorCreate.Image")));
            this.btn_VendorCreate.Location = new System.Drawing.Point(348, 8);
            this.btn_VendorCreate.Name = "btn_VendorCreate";
            this.btn_VendorCreate.Size = new System.Drawing.Size(25, 25);
            this.btn_VendorCreate.TabIndex = 2;
            this.btn_VendorCreate.UseVisualStyleBackColor = false;
            this.btn_VendorCreate.Click += new System.EventHandler(this.btn_VendorCreate_Click);
            // 
            // Frm_InvoiceCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1080, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pan_title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_InvoiceCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InvoiceCreate";
            this.pan_title.ResumeLayout(false);
            this.pan_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_InvoiceManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BackToMain;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Label lbl_ProductDisplayNumber;
        private System.Windows.Forms.Label lbl_ProductType;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.TextBox txt_VendorName;
        private System.Windows.Forms.TextBox txt_Purchase;
        private System.Windows.Forms.Label lbl_PrimaryAddress;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_ProductTaxGroup;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NetAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CreditNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DebitNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ConcernPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DesignRef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DivisionName;
        private DevExpress.XtraGrid.GridControl grd_InvoiceManagement;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Button btn_ConcernPersonCreate;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button Btn_PartialClear;
        private System.Windows.Forms.TextBox txt_InvoiceNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txt_DateTime;
        private System.Windows.Forms.ComboBox txt_Status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_DivisionCreate;
        private System.Windows.Forms.Button btn_VendorCreate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txt_RecSub;
        private System.Windows.Forms.TextBox txt_Inward;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Tax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button txt_ClearAll;
    }
}