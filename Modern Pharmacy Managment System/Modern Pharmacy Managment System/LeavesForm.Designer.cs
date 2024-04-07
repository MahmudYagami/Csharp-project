
namespace Modern_Pharmacy_Managment_System
{
    partial class LeavesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeavesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateEndCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateStartCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.EmployeeCb = new System.Windows.Forms.ComboBox();
            this.EmpLeftPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeaveBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.EmployeesBtn = new FontAwesome.Sharp.IconButton();
            this.LeaveCategoriesLabel = new System.Windows.Forms.Label();
            this.Emp_manage_label = new System.Windows.Forms.Label();
            this.EmpTopPanel = new System.Windows.Forms.Panel();
            this.LeaveLabel = new System.Windows.Forms.Label();
            this.LeaveEmpLabel = new System.Windows.Forms.Label();
            this.DateStartLabel = new System.Windows.Forms.Label();
            this.DateEndLabel = new System.Windows.Forms.Label();
            this.LeaveStatusLabel = new System.Windows.Forms.Label();
            this.EmpEditBtnLeave = new FontAwesome.Sharp.IconButton();
            this.EmpSaveBtnLeave = new FontAwesome.Sharp.IconButton();
            this.EmpDltBtnLeave = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LeaveList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoriesCb = new System.Windows.Forms.ComboBox();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            this.EmpLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.EmpTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveList)).BeginInit();
            this.SuspendLayout();
            // 
            // DateEndCalender
            // 
            this.DateEndCalender.CheckedState.Parent = this.DateEndCalender;
            this.DateEndCalender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.DateEndCalender.ForeColor = System.Drawing.Color.White;
            this.DateEndCalender.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEndCalender.HoverState.Parent = this.DateEndCalender;
            this.DateEndCalender.Location = new System.Drawing.Point(331, 176);
            this.DateEndCalender.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEndCalender.MinDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.DateEndCalender.Name = "DateEndCalender";
            this.DateEndCalender.ShadowDecoration.Parent = this.DateEndCalender;
            this.DateEndCalender.Size = new System.Drawing.Size(168, 36);
            this.DateEndCalender.TabIndex = 48;
            this.DateEndCalender.Value = new System.DateTime(2024, 4, 5, 17, 31, 20, 106);
            // 
            // DateStartCalender
            // 
            this.DateStartCalender.CheckedState.Parent = this.DateStartCalender;
            this.DateStartCalender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.DateStartCalender.ForeColor = System.Drawing.Color.White;
            this.DateStartCalender.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStartCalender.HoverState.Parent = this.DateStartCalender;
            this.DateStartCalender.Location = new System.Drawing.Point(534, 114);
            this.DateStartCalender.MaxDate = new System.DateTime(9988, 12, 31, 0, 0, 0, 0);
            this.DateStartCalender.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.DateStartCalender.Name = "DateStartCalender";
            this.DateStartCalender.ShadowDecoration.Parent = this.DateStartCalender;
            this.DateStartCalender.Size = new System.Drawing.Size(168, 36);
            this.DateStartCalender.TabIndex = 47;
            this.DateStartCalender.Value = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            // 
            // StatusCb
            // 
            this.StatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.StatusCb.Location = new System.Drawing.Point(534, 176);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(168, 33);
            this.StatusCb.TabIndex = 46;
            // 
            // EmployeeCb
            // 
            this.EmployeeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeCb.FormattingEnabled = true;
            this.EmployeeCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmployeeCb.Location = new System.Drawing.Point(173, 114);
            this.EmployeeCb.Name = "EmployeeCb";
            this.EmployeeCb.Size = new System.Drawing.Size(121, 33);
            this.EmployeeCb.TabIndex = 45;
            // 
            // EmpLeftPanel
            // 
            this.EmpLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.EmpLeftPanel.Controls.Add(this.pictureBox1);
            this.EmpLeftPanel.Controls.Add(this.LeaveBtn);
            this.EmpLeftPanel.Controls.Add(this.iconButton5);
            this.EmpLeftPanel.Controls.Add(this.EmployeesBtn);
            this.EmpLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmpLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpLeftPanel.Name = "EmpLeftPanel";
            this.EmpLeftPanel.Size = new System.Drawing.Size(137, 614);
            this.EmpLeftPanel.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.LeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LeaveBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.LeaveBtn.IconColor = System.Drawing.Color.White;
            this.LeaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LeaveBtn.Location = new System.Drawing.Point(0, 317);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(137, 52);
            this.LeaveBtn.TabIndex = 2;
            this.LeaveBtn.Text = "Leaves";
            this.LeaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LeaveBtn.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 35;
            this.iconButton5.Location = new System.Drawing.Point(0, 388);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(137, 52);
            this.iconButton5.TabIndex = 1;
            this.iconButton5.Text = "Categories";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.EmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmployeesBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.EmployeesBtn.IconColor = System.Drawing.Color.White;
            this.EmployeesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmployeesBtn.IconSize = 30;
            this.EmployeesBtn.Location = new System.Drawing.Point(0, 244);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(137, 52);
            this.EmployeesBtn.TabIndex = 0;
            this.EmployeesBtn.Text = "Employees";
            this.EmployeesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeesBtn.UseVisualStyleBackColor = false;
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // LeaveCategoriesLabel
            // 
            this.LeaveCategoriesLabel.AutoSize = true;
            this.LeaveCategoriesLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveCategoriesLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LeaveCategoriesLabel.Location = new System.Drawing.Point(344, 94);
            this.LeaveCategoriesLabel.Name = "LeaveCategoriesLabel";
            this.LeaveCategoriesLabel.Size = new System.Drawing.Size(80, 17);
            this.LeaveCategoriesLabel.TabIndex = 31;
            this.LeaveCategoriesLabel.Text = "Categories";
            // 
            // Emp_manage_label
            // 
            this.Emp_manage_label.AutoSize = true;
            this.Emp_manage_label.Font = new System.Drawing.Font("ISOCTEUR", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_manage_label.ForeColor = System.Drawing.Color.White;
            this.Emp_manage_label.Location = new System.Drawing.Point(188, -2);
            this.Emp_manage_label.Name = "Emp_manage_label";
            this.Emp_manage_label.Size = new System.Drawing.Size(395, 34);
            this.Emp_manage_label.TabIndex = 0;
            this.Emp_manage_label.Text = "EMPLOYEE MANAGEMENT";
            // 
            // EmpTopPanel
            // 
            this.EmpTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(1)))), ((int)(((byte)(113)))));
            this.EmpTopPanel.Controls.Add(this.Emp_manage_label);
            this.EmpTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpTopPanel.Location = new System.Drawing.Point(137, 0);
            this.EmpTopPanel.Name = "EmpTopPanel";
            this.EmpTopPanel.Size = new System.Drawing.Size(858, 32);
            this.EmpTopPanel.TabIndex = 28;
            // 
            // LeaveLabel
            // 
            this.LeaveLabel.AutoSize = true;
            this.LeaveLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LeaveLabel.Location = new System.Drawing.Point(431, 33);
            this.LeaveLabel.Name = "LeaveLabel";
            this.LeaveLabel.Size = new System.Drawing.Size(200, 32);
            this.LeaveLabel.TabIndex = 27;
            this.LeaveLabel.Text = "Manage Leaves";
            // 
            // LeaveEmpLabel
            // 
            this.LeaveEmpLabel.AutoSize = true;
            this.LeaveEmpLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveEmpLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LeaveEmpLabel.Location = new System.Drawing.Point(170, 94);
            this.LeaveEmpLabel.Name = "LeaveEmpLabel";
            this.LeaveEmpLabel.Size = new System.Drawing.Size(80, 17);
            this.LeaveEmpLabel.TabIndex = 30;
            this.LeaveEmpLabel.Text = "Employees";
            // 
            // DateStartLabel
            // 
            this.DateStartLabel.AutoSize = true;
            this.DateStartLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStartLabel.ForeColor = System.Drawing.Color.Maroon;
            this.DateStartLabel.Location = new System.Drawing.Point(531, 94);
            this.DateStartLabel.Name = "DateStartLabel";
            this.DateStartLabel.Size = new System.Drawing.Size(74, 17);
            this.DateStartLabel.TabIndex = 32;
            this.DateStartLabel.Text = "Date Start";
            // 
            // DateEndLabel
            // 
            this.DateEndLabel.AutoSize = true;
            this.DateEndLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEndLabel.ForeColor = System.Drawing.Color.Maroon;
            this.DateEndLabel.Location = new System.Drawing.Point(328, 156);
            this.DateEndLabel.Name = "DateEndLabel";
            this.DateEndLabel.Size = new System.Drawing.Size(69, 17);
            this.DateEndLabel.TabIndex = 33;
            this.DateEndLabel.Text = "Date End";
            // 
            // LeaveStatusLabel
            // 
            this.LeaveStatusLabel.AutoSize = true;
            this.LeaveStatusLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveStatusLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LeaveStatusLabel.Location = new System.Drawing.Point(531, 156);
            this.LeaveStatusLabel.Name = "LeaveStatusLabel";
            this.LeaveStatusLabel.Size = new System.Drawing.Size(48, 17);
            this.LeaveStatusLabel.TabIndex = 34;
            this.LeaveStatusLabel.Text = "Status";
            // 
            // EmpEditBtnLeave
            // 
            this.EmpEditBtnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.EmpEditBtnLeave.FlatAppearance.BorderSize = 0;
            this.EmpEditBtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpEditBtnLeave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpEditBtnLeave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpEditBtnLeave.IconColor = System.Drawing.Color.Black;
            this.EmpEditBtnLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpEditBtnLeave.Location = new System.Drawing.Point(729, 82);
            this.EmpEditBtnLeave.Name = "EmpEditBtnLeave";
            this.EmpEditBtnLeave.Size = new System.Drawing.Size(133, 42);
            this.EmpEditBtnLeave.TabIndex = 35;
            this.EmpEditBtnLeave.Text = "Edit";
            this.EmpEditBtnLeave.UseVisualStyleBackColor = false;
            this.EmpEditBtnLeave.Click += new System.EventHandler(this.EmpEditBtnLeave_Click);
            // 
            // EmpSaveBtnLeave
            // 
            this.EmpSaveBtnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(1)))), ((int)(((byte)(113)))));
            this.EmpSaveBtnLeave.FlatAppearance.BorderSize = 0;
            this.EmpSaveBtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSaveBtnLeave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSaveBtnLeave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpSaveBtnLeave.IconColor = System.Drawing.Color.Black;
            this.EmpSaveBtnLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpSaveBtnLeave.Location = new System.Drawing.Point(729, 130);
            this.EmpSaveBtnLeave.Name = "EmpSaveBtnLeave";
            this.EmpSaveBtnLeave.Size = new System.Drawing.Size(133, 42);
            this.EmpSaveBtnLeave.TabIndex = 36;
            this.EmpSaveBtnLeave.Text = "Save";
            this.EmpSaveBtnLeave.UseVisualStyleBackColor = false;
            this.EmpSaveBtnLeave.Click += new System.EventHandler(this.EmpSaveBtnLeave_Click);
            // 
            // EmpDltBtnLeave
            // 
            this.EmpDltBtnLeave.BackColor = System.Drawing.Color.Crimson;
            this.EmpDltBtnLeave.FlatAppearance.BorderSize = 0;
            this.EmpDltBtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpDltBtnLeave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpDltBtnLeave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpDltBtnLeave.IconColor = System.Drawing.Color.Black;
            this.EmpDltBtnLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpDltBtnLeave.Location = new System.Drawing.Point(729, 178);
            this.EmpDltBtnLeave.Name = "EmpDltBtnLeave";
            this.EmpDltBtnLeave.Size = new System.Drawing.Size(133, 42);
            this.EmpDltBtnLeave.TabIndex = 37;
            this.EmpDltBtnLeave.Text = "Delete";
            this.EmpDltBtnLeave.UseVisualStyleBackColor = false;
            this.EmpDltBtnLeave.Click += new System.EventHandler(this.EmpDltBtnLeave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.panel3.Location = new System.Drawing.Point(127, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 10);
            this.panel3.TabIndex = 41;
            // 
            // LeaveList
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.LeaveList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.LeaveList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeaveList.BackgroundColor = System.Drawing.Color.White;
            this.LeaveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeaveList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LeaveList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.LeaveList.ColumnHeadersHeight = 28;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LeaveList.DefaultCellStyle = dataGridViewCellStyle18;
            this.LeaveList.EnableHeadersVisualStyles = false;
            this.LeaveList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.LeaveList.Location = new System.Drawing.Point(145, 374);
            this.LeaveList.Name = "LeaveList";
            this.LeaveList.RowHeadersVisible = false;
            this.LeaveList.RowHeadersWidth = 51;
            this.LeaveList.RowTemplate.Height = 24;
            this.LeaveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LeaveList.Size = new System.Drawing.Size(828, 210);
            this.LeaveList.TabIndex = 42;
            this.LeaveList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LeaveList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.LeaveList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.LeaveList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LeaveList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LeaveList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LeaveList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LeaveList.ThemeStyle.HeaderStyle.Height = 28;
            this.LeaveList.ThemeStyle.ReadOnly = false;
            this.LeaveList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.LeaveList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LeaveList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LeaveList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.LeaveList.ThemeStyle.RowsStyle.Height = 24;
            this.LeaveList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.LeaveList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.LeaveList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeaveList_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(431, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 43;
            this.label5.Text = "Leaves List";
            // 
            // CategoriesCb
            // 
            this.CategoriesCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesCb.FormattingEnabled = true;
            this.CategoriesCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CategoriesCb.Location = new System.Drawing.Point(347, 114);
            this.CategoriesCb.Name = "CategoriesCb";
            this.CategoriesCb.Size = new System.Drawing.Size(121, 33);
            this.CategoriesCb.TabIndex = 44;
            // 
            // SearchCb
            // 
            this.SearchCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.SearchCb.Location = new System.Drawing.Point(427, 307);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(168, 33);
            this.SearchCb.TabIndex = 49;
            this.SearchCb.SelectedIndexChanged += new System.EventHandler(this.SearchCb_SelectedIndexChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(1)))), ((int)(((byte)(113)))));
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RefreshBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.RefreshBtn.IconColor = System.Drawing.Color.Black;
            this.RefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshBtn.Location = new System.Drawing.Point(601, 307);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(133, 33);
            this.RefreshBtn.TabIndex = 50;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // LeavesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 614);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchCb);
            this.Controls.Add(this.DateEndCalender);
            this.Controls.Add(this.DateStartCalender);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.EmployeeCb);
            this.Controls.Add(this.CategoriesCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LeaveList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EmpDltBtnLeave);
            this.Controls.Add(this.EmpSaveBtnLeave);
            this.Controls.Add(this.EmpEditBtnLeave);
            this.Controls.Add(this.LeaveStatusLabel);
            this.Controls.Add(this.DateEndLabel);
            this.Controls.Add(this.DateStartLabel);
            this.Controls.Add(this.LeaveEmpLabel);
            this.Controls.Add(this.LeaveLabel);
            this.Controls.Add(this.EmpTopPanel);
            this.Controls.Add(this.LeaveCategoriesLabel);
            this.Controls.Add(this.EmpLeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeavesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeavesForm";
            this.EmpLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.EmpTopPanel.ResumeLayout(false);
            this.EmpTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DateEndCalender;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStartCalender;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.ComboBox EmployeeCb;
        private System.Windows.Forms.Panel EmpLeftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton LeaveBtn;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton EmployeesBtn;
        private System.Windows.Forms.Label LeaveCategoriesLabel;
        private System.Windows.Forms.Label Emp_manage_label;
        private System.Windows.Forms.Panel EmpTopPanel;
        private System.Windows.Forms.Label LeaveLabel;
        private System.Windows.Forms.Label LeaveEmpLabel;
        private System.Windows.Forms.Label DateStartLabel;
        private System.Windows.Forms.Label DateEndLabel;
        private System.Windows.Forms.Label LeaveStatusLabel;
        private FontAwesome.Sharp.IconButton EmpEditBtnLeave;
        private FontAwesome.Sharp.IconButton EmpSaveBtnLeave;
        private FontAwesome.Sharp.IconButton EmpDltBtnLeave;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView LeaveList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CategoriesCb;
        private System.Windows.Forms.ComboBox SearchCb;
        private FontAwesome.Sharp.IconButton RefreshBtn;
    }
}