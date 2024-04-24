namespace Modern_Pharmacy_Managment_System
{
    partial class CustomerDashboard
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customer_logout_btn = new FontAwesome.Sharp.IconButton();
            this.Customer_settings_Btn = new FontAwesome.Sharp.IconButton();
            this.Buy_Medicine_btn = new FontAwesome.Sharp.IconButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.CustomerMainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.CustomerNameTxt = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.LeftPanel.Controls.Add(this.panel1);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 59);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(268, 700);
            this.LeftPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Customer_logout_btn);
            this.panel1.Controls.Add(this.Customer_settings_Btn);
            this.panel1.Controls.Add(this.Buy_Medicine_btn);
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 363);
            this.panel1.TabIndex = 3;
            // 
            // Customer_logout_btn
            // 
            this.Customer_logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.Customer_logout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customer_logout_btn.FlatAppearance.BorderSize = 0;
            this.Customer_logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_logout_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customer_logout_btn.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.Customer_logout_btn.IconColor = System.Drawing.Color.White;
            this.Customer_logout_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Customer_logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customer_logout_btn.Location = new System.Drawing.Point(0, 174);
            this.Customer_logout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customer_logout_btn.Name = "Customer_logout_btn";
            this.Customer_logout_btn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.Customer_logout_btn.Size = new System.Drawing.Size(265, 87);
            this.Customer_logout_btn.TabIndex = 11;
            this.Customer_logout_btn.Text = "Logout";
            this.Customer_logout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Customer_logout_btn.UseVisualStyleBackColor = false;
            // 
            // Customer_settings_Btn
            // 
            this.Customer_settings_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.Customer_settings_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customer_settings_Btn.FlatAppearance.BorderSize = 0;
            this.Customer_settings_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_settings_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customer_settings_Btn.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.Customer_settings_Btn.IconColor = System.Drawing.Color.White;
            this.Customer_settings_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Customer_settings_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customer_settings_Btn.Location = new System.Drawing.Point(0, 84);
            this.Customer_settings_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customer_settings_Btn.Name = "Customer_settings_Btn";
            this.Customer_settings_Btn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.Customer_settings_Btn.Size = new System.Drawing.Size(265, 90);
            this.Customer_settings_Btn.TabIndex = 10;
            this.Customer_settings_Btn.Text = "Settings";
            this.Customer_settings_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Customer_settings_Btn.UseVisualStyleBackColor = false;
            this.Customer_settings_Btn.Click += new System.EventHandler(this.Customer_settings_Btn_Click);
            // 
            // Buy_Medicine_btn
            // 
            this.Buy_Medicine_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.Buy_Medicine_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Buy_Medicine_btn.FlatAppearance.BorderSize = 0;
            this.Buy_Medicine_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buy_Medicine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_Medicine_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Buy_Medicine_btn.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.Buy_Medicine_btn.IconColor = System.Drawing.Color.White;
            this.Buy_Medicine_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Buy_Medicine_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buy_Medicine_btn.Location = new System.Drawing.Point(0, 0);
            this.Buy_Medicine_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buy_Medicine_btn.Name = "Buy_Medicine_btn";
            this.Buy_Medicine_btn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.Buy_Medicine_btn.Size = new System.Drawing.Size(265, 84);
            this.Buy_Medicine_btn.TabIndex = 9;
            this.Buy_Medicine_btn.Text = "Buy Medicine";
            this.Buy_Medicine_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buy_Medicine_btn.UseVisualStyleBackColor = false;
            this.Buy_Medicine_btn.Click += new System.EventHandler(this.Buy_Medicine_btn_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(268, 83);
            this.LogoPanel.TabIndex = 0;
            // 
            // CustomerMainPanel
            // 
            this.CustomerMainPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.CustomerMainPanel.Location = new System.Drawing.Point(292, 81);
            this.CustomerMainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerMainPanel.Name = "CustomerMainPanel";
            this.CustomerMainPanel.Size = new System.Drawing.Size(1212, 673);
            this.CustomerMainPanel.TabIndex = 6;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.topPanel.Controls.Add(this.CustomerNameTxt);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1516, 59);
            this.topPanel.TabIndex = 5;
            // 
            // CustomerNameTxt
            // 
            this.CustomerNameTxt.AutoSize = true;
            this.CustomerNameTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerNameTxt.Location = new System.Drawing.Point(1108, 9);
            this.CustomerNameTxt.Name = "CustomerNameTxt";
            this.CustomerNameTxt.Size = new System.Drawing.Size(87, 30);
            this.CustomerNameTxt.TabIndex = 2;
            this.CustomerNameTxt.Text = "Name";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 759);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.CustomerMainPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashboard";
            this.LeftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Customer_logout_btn;
        private FontAwesome.Sharp.IconButton Customer_settings_Btn;
        private FontAwesome.Sharp.IconButton Buy_Medicine_btn;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel CustomerMainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label CustomerNameTxt;
    }
}