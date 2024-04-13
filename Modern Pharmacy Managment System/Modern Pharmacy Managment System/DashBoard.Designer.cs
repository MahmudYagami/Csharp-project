
namespace Modern_Pharmacy_Managment_System
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.AdminPictureBox = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.flowdropdownpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DropdownPanel = new System.Windows.Forms.Panel();
            this.StaffBtn = new FontAwesome.Sharp.IconButton();
            this.CustomerBtn = new FontAwesome.Sharp.IconButton();
            this.ManagementBtn = new FontAwesome.Sharp.IconButton();
            this.RevenueBtn = new FontAwesome.Sharp.IconButton();
            this.InventoryBtn = new FontAwesome.Sharp.IconButton();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.DashBoardBtn = new FontAwesome.Sharp.IconButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.TimerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateTimeShow = new System.Windows.Forms.Timer(this.components);
            this.mainpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.flowdropdownpanel.SuspendLayout();
            this.DropdownPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.TimerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(268, 59);
            this.LogoPanel.TabIndex = 0;
            // 
            // AdminPictureBox
            // 
            this.AdminPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AdminPictureBox.Image")));
            this.AdminPictureBox.Location = new System.Drawing.Point(0, 59);
            this.AdminPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPictureBox.Name = "AdminPictureBox";
            this.AdminPictureBox.Size = new System.Drawing.Size(268, 84);
            this.AdminPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminPictureBox.TabIndex = 1;
            this.AdminPictureBox.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.LeftPanel.Controls.Add(this.flowdropdownpanel);
            this.LeftPanel.Controls.Add(this.DashBoardBtn);
            this.LeftPanel.Controls.Add(this.AdminPictureBox);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(268, 673);
            this.LeftPanel.TabIndex = 0;
            // 
            // flowdropdownpanel
            // 
            this.flowdropdownpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.flowdropdownpanel.Controls.Add(this.DropdownPanel);
            this.flowdropdownpanel.Controls.Add(this.RevenueBtn);
            this.flowdropdownpanel.Controls.Add(this.InventoryBtn);
            this.flowdropdownpanel.Controls.Add(this.logoutBtn);
            this.flowdropdownpanel.Location = new System.Drawing.Point(0, 209);
            this.flowdropdownpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowdropdownpanel.Name = "flowdropdownpanel";
            this.flowdropdownpanel.Size = new System.Drawing.Size(268, 427);
            this.flowdropdownpanel.TabIndex = 2;
            // 
            // DropdownPanel
            // 
            this.DropdownPanel.Controls.Add(this.StaffBtn);
            this.DropdownPanel.Controls.Add(this.CustomerBtn);
            this.DropdownPanel.Controls.Add(this.ManagementBtn);
            this.DropdownPanel.Location = new System.Drawing.Point(3, 2);
            this.DropdownPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DropdownPanel.MaximumSize = new System.Drawing.Size(268, 181);
            this.DropdownPanel.MinimumSize = new System.Drawing.Size(268, 62);
            this.DropdownPanel.Name = "DropdownPanel";
            this.DropdownPanel.Size = new System.Drawing.Size(268, 63);
            this.DropdownPanel.TabIndex = 1;
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.StaffBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaffBtn.FlatAppearance.BorderSize = 0;
            this.StaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StaffBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.StaffBtn.IconColor = System.Drawing.Color.White;
            this.StaffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StaffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffBtn.Location = new System.Drawing.Point(0, 120);
            this.StaffBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.StaffBtn.Size = new System.Drawing.Size(268, 62);
            this.StaffBtn.TabIndex = 5;
            this.StaffBtn.Text = "Staff";
            this.StaffBtn.UseVisualStyleBackColor = false;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.CustomerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerBtn.FlatAppearance.BorderSize = 0;
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomerBtn.IconChar = FontAwesome.Sharp.IconChar.Children;
            this.CustomerBtn.IconColor = System.Drawing.Color.White;
            this.CustomerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CustomerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerBtn.Location = new System.Drawing.Point(0, 60);
            this.CustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.CustomerBtn.Size = new System.Drawing.Size(268, 60);
            this.CustomerBtn.TabIndex = 4;
            this.CustomerBtn.Text = "Customer";
            this.CustomerBtn.UseVisualStyleBackColor = false;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // ManagementBtn
            // 
            this.ManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagementBtn.FlatAppearance.BorderSize = 0;
            this.ManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagementBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManagementBtn.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.ManagementBtn.IconColor = System.Drawing.Color.White;
            this.ManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagementBtn.Location = new System.Drawing.Point(0, 0);
            this.ManagementBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManagementBtn.Name = "ManagementBtn";
            this.ManagementBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.ManagementBtn.Size = new System.Drawing.Size(268, 60);
            this.ManagementBtn.TabIndex = 3;
            this.ManagementBtn.Text = "Management";
            this.ManagementBtn.UseVisualStyleBackColor = false;
            this.ManagementBtn.Click += new System.EventHandler(this.ManagementBtn_Click);
            // 
            // RevenueBtn
            // 
            this.RevenueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.RevenueBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RevenueBtn.FlatAppearance.BorderSize = 0;
            this.RevenueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevenueBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RevenueBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.RevenueBtn.IconColor = System.Drawing.Color.White;
            this.RevenueBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RevenueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RevenueBtn.Location = new System.Drawing.Point(3, 69);
            this.RevenueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RevenueBtn.Name = "RevenueBtn";
            this.RevenueBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.RevenueBtn.Size = new System.Drawing.Size(268, 66);
            this.RevenueBtn.TabIndex = 2;
            this.RevenueBtn.Text = "Revenue";
            this.RevenueBtn.UseVisualStyleBackColor = false;
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.InventoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryBtn.FlatAppearance.BorderSize = 0;
            this.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InventoryBtn.IconChar = FontAwesome.Sharp.IconChar.Indent;
            this.InventoryBtn.IconColor = System.Drawing.Color.White;
            this.InventoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBtn.Location = new System.Drawing.Point(3, 139);
            this.InventoryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.InventoryBtn.Size = new System.Drawing.Size(268, 65);
            this.InventoryBtn.TabIndex = 4;
            this.InventoryBtn.Text = "Inventory";
            this.InventoryBtn.UseVisualStyleBackColor = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.logoutBtn.IconColor = System.Drawing.Color.White;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(3, 208);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.logoutBtn.Size = new System.Drawing.Size(268, 63);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // DashBoardBtn
            // 
            this.DashBoardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoardBtn.FlatAppearance.BorderSize = 0;
            this.DashBoardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoardBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashBoardBtn.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.DashBoardBtn.IconColor = System.Drawing.Color.White;
            this.DashBoardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashBoardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoardBtn.Location = new System.Drawing.Point(0, 143);
            this.DashBoardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashBoardBtn.Name = "DashBoardBtn";
            this.DashBoardBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.DashBoardBtn.Size = new System.Drawing.Size(268, 60);
            this.DashBoardBtn.TabIndex = 2;
            this.DashBoardBtn.Text = "Dashboard";
            this.DashBoardBtn.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.topPanel.Controls.Add(this.TimerPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(268, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(993, 59);
            this.topPanel.TabIndex = 1;
            // 
            // TimerPanel
            // 
            this.TimerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TimerPanel.Controls.Add(this.pictureBox1);
            this.TimerPanel.Controls.Add(this.DateLabel);
            this.TimerPanel.Controls.Add(this.TimeLabel);
            this.TimerPanel.Location = new System.Drawing.Point(782, 2);
            this.TimerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.Size = new System.Drawing.Size(211, 57);
            this.TimerPanel.TabIndex = 0;
            this.TimerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TimerPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(3, 36);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(45, 20);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(3, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(46, 20);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // DateTimeShow
            // 
            this.DateTimeShow.Enabled = true;
            this.DateTimeShow.Tick += new System.EventHandler(this.DateTimeShow_Tick);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(268, 59);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(993, 614);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.LeftPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.flowdropdownpanel.ResumeLayout(false);
            this.DropdownPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.TimerPanel.ResumeLayout(false);
            this.TimerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox AdminPictureBox;
        private System.Windows.Forms.Panel LeftPanel;
        private FontAwesome.Sharp.IconButton DashBoardBtn;
        private System.Windows.Forms.Panel DropdownPanel;
        private FontAwesome.Sharp.IconButton StaffBtn;
        private FontAwesome.Sharp.IconButton CustomerBtn;
        private FontAwesome.Sharp.IconButton ManagementBtn;
        private System.Windows.Forms.FlowLayoutPanel flowdropdownpanel;
        private FontAwesome.Sharp.IconButton RevenueBtn;
        private FontAwesome.Sharp.IconButton InventoryBtn;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer DateTimeShow;
        private System.Windows.Forms.Panel TimerPanel;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel mainpanel;
    }
}