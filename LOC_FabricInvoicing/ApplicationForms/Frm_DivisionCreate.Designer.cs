
namespace LOC_FabricInvoicing.ApplicationForms
{
    partial class Frm_DivisionCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DivisionCreate));
            this.pnl_MainPanel = new System.Windows.Forms.Panel();
            this.btn_BackToMain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddDivision = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Initials = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DivisionName = new System.Windows.Forms.TextBox();
            this.txt_Entity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.lbl_Header.Size = new System.Drawing.Size(173, 21);
            this.lbl_Header.TabIndex = 7;
            this.lbl_Header.Text = "Create Product Division";
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
            this.label6.Location = new System.Drawing.Point(126, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Division Name :";
            // 
            // txt_Initials
            // 
            this.txt_Initials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Initials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Initials.Location = new System.Drawing.Point(270, 108);
            this.txt_Initials.Name = "txt_Initials";
            this.txt_Initials.Size = new System.Drawing.Size(248, 29);
            this.txt_Initials.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(183, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Initials :";
            // 
            // txt_DivisionName
            // 
            this.txt_DivisionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DivisionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DivisionName.Location = new System.Drawing.Point(270, 61);
            this.txt_DivisionName.Name = "txt_DivisionName";
            this.txt_DivisionName.Size = new System.Drawing.Size(248, 29);
            this.txt_DivisionName.TabIndex = 49;
            // 
            // txt_Entity
            // 
            this.txt_Entity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Entity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Entity.Location = new System.Drawing.Point(270, 157);
            this.txt_Entity.Name = "txt_Entity";
            this.txt_Entity.Size = new System.Drawing.Size(248, 29);
            this.txt_Entity.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "Entity :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(60, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 152);
            this.panel1.TabIndex = 55;
            // 
            // Frm_DivisionCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(530, 200);
            this.Controls.Add(this.txt_Entity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Initials);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DivisionName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DivisionCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EntityCreate";
            this.pnl_MainPanel.ResumeLayout(false);
            this.pnl_MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txt_Initials;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DivisionName;
        private System.Windows.Forms.TextBox txt_Entity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}