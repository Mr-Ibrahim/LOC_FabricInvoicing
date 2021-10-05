
namespace LOC_FabricInvoicing.ApplicationForms
{
    partial class Frm_PurchOrderInwardCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PurchOrderInwardCreate));
            this.pnl_MainPanel = new System.Windows.Forms.Panel();
            this.btn_BackToMain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddDivision = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Inward = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PurchOrder = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Separator2 = new System.Windows.Forms.Button();
            this.btn_Separator1 = new System.Windows.Forms.Button();
            this.lbl_ValuesInward = new System.Windows.Forms.Label();
            this.lbl_ValuesPurchOrder = new System.Windows.Forms.Label();
            this.pnl_MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MainPanel
            // 
            this.pnl_MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MainPanel.Controls.Add(this.btn_BackToMain);
            this.pnl_MainPanel.Controls.Add(this.btn_Exit);
            this.pnl_MainPanel.Controls.Add(this.lbl_Header);
            this.pnl_MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MainPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainPanel.Name = "pnl_MainPanel";
            this.pnl_MainPanel.Size = new System.Drawing.Size(530, 45);
            this.pnl_MainPanel.TabIndex = 39;
            this.pnl_MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_MainPanel_MouseDown);
            // 
            // btn_BackToMain
            // 
            this.btn_BackToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_BackToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackToMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackToMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_BackToMain.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackToMain.Image")));
            this.btn_BackToMain.Location = new System.Drawing.Point(445, 2);
            this.btn_BackToMain.Name = "btn_BackToMain";
            this.btn_BackToMain.Size = new System.Drawing.Size(40, 40);
            this.btn_BackToMain.TabIndex = 10;
            this.btn_BackToMain.UseVisualStyleBackColor = false;
            this.btn_BackToMain.Click += new System.EventHandler(this.btn_BackToMain_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(489, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(13, 13);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(275, 21);
            this.lbl_Header.TabIndex = 7;
            this.lbl_Header.Text = "Create Purchase Against Inward Order";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_AddDivision);
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 155);
            this.panel2.TabIndex = 46;
            // 
            // btn_AddDivision
            // 
            this.btn_AddDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_AddDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_AddDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_AddDivision.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddDivision.Image")));
            this.btn_AddDivision.Location = new System.Drawing.Point(3, 6);
            this.btn_AddDivision.Name = "btn_AddDivision";
            this.btn_AddDivision.Size = new System.Drawing.Size(54, 54);
            this.btn_AddDivision.TabIndex = 3;
            this.btn_AddDivision.UseVisualStyleBackColor = false;
            this.btn_AddDivision.Click += new System.EventHandler(this.btn_AddDivision_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.Location = new System.Drawing.Point(3, 66);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(54, 54);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(47, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Purch Order :";
            // 
            // txt_Inward
            // 
            this.txt_Inward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Inward.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inward.Location = new System.Drawing.Point(234, 154);
            this.txt_Inward.Name = "txt_Inward";
            this.txt_Inward.Size = new System.Drawing.Size(248, 29);
            this.txt_Inward.TabIndex = 51;
            this.txt_Inward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Inward_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(84, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Inward :";
            // 
            // txt_PurchOrder
            // 
            this.txt_PurchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PurchOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PurchOrder.Location = new System.Drawing.Point(234, 79);
            this.txt_PurchOrder.Name = "txt_PurchOrder";
            this.txt_PurchOrder.Size = new System.Drawing.Size(248, 29);
            this.txt_PurchOrder.TabIndex = 49;
            this.txt_PurchOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PurchOrder_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Separator2);
            this.panel1.Controls.Add(this.btn_Separator1);
            this.panel1.Controls.Add(this.lbl_ValuesInward);
            this.panel1.Controls.Add(this.lbl_ValuesPurchOrder);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(60, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 152);
            this.panel1.TabIndex = 55;
            // 
            // btn_Separator2
            // 
            this.btn_Separator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Separator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Separator2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Separator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Separator2.Image = ((System.Drawing.Image)(resources.GetObject("btn_Separator2.Image")));
            this.btn_Separator2.Location = new System.Drawing.Point(428, 109);
            this.btn_Separator2.Name = "btn_Separator2";
            this.btn_Separator2.Size = new System.Drawing.Size(29, 29);
            this.btn_Separator2.TabIndex = 55;
            this.btn_Separator2.UseVisualStyleBackColor = false;
            this.btn_Separator2.Click += new System.EventHandler(this.btn_Separator2_Click);
            // 
            // btn_Separator1
            // 
            this.btn_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Separator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Separator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Separator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btn_Separator1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Separator1.Image")));
            this.btn_Separator1.Location = new System.Drawing.Point(428, 34);
            this.btn_Separator1.Name = "btn_Separator1";
            this.btn_Separator1.Size = new System.Drawing.Size(29, 29);
            this.btn_Separator1.TabIndex = 4;
            this.btn_Separator1.UseVisualStyleBackColor = false;
            this.btn_Separator1.Click += new System.EventHandler(this.btn_Separator1_Click);
            // 
            // lbl_ValuesInward
            // 
            this.lbl_ValuesInward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValuesInward.BackColor = System.Drawing.Color.White;
            this.lbl_ValuesInward.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValuesInward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lbl_ValuesInward.Location = new System.Drawing.Point(87, 85);
            this.lbl_ValuesInward.Name = "lbl_ValuesInward";
            this.lbl_ValuesInward.Size = new System.Drawing.Size(371, 21);
            this.lbl_ValuesInward.TabIndex = 54;
            this.lbl_ValuesInward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ValuesPurchOrder
            // 
            this.lbl_ValuesPurchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValuesPurchOrder.BackColor = System.Drawing.Color.White;
            this.lbl_ValuesPurchOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValuesPurchOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lbl_ValuesPurchOrder.Location = new System.Drawing.Point(86, 10);
            this.lbl_ValuesPurchOrder.Name = "lbl_ValuesPurchOrder";
            this.lbl_ValuesPurchOrder.Size = new System.Drawing.Size(371, 21);
            this.lbl_ValuesPurchOrder.TabIndex = 53;
            this.lbl_ValuesPurchOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_PurchOrderInwardCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(530, 200);
            this.Controls.Add(this.txt_Inward);
            this.Controls.Add(this.txt_PurchOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PurchOrderInwardCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EntityCreate";
            this.pnl_MainPanel.ResumeLayout(false);
            this.pnl_MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MainPanel;
        private System.Windows.Forms.Button btn_BackToMain;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_AddDivision;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Inward;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PurchOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ValuesInward;
        private System.Windows.Forms.Label lbl_ValuesPurchOrder;
        private System.Windows.Forms.Button btn_Separator2;
        private System.Windows.Forms.Button btn_Separator1;
    }
}