
namespace Modern_Pharmacy_Managment_System
{
    partial class StaffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Emp_manage_label = new System.Windows.Forms.Label();
            this.EmpLeftPanel = new System.Windows.Forms.Panel();
            this.LeaveBtn = new FontAwesome.Sharp.IconButton();
            this.CategoryBtnStaff = new FontAwesome.Sharp.IconButton();
            this.EmpTopPanel = new System.Windows.Forms.Panel();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpEditBtnStaff = new FontAwesome.Sharp.IconButton();
            this.EmpSaveBtnStaff = new FontAwesome.Sharp.IconButton();
            this.EmpDltBtnStaff = new FontAwesome.Sharp.IconButton();
            this.EmpAddressTb = new System.Windows.Forms.TextBox();
            this.EmpPassTb = new System.Windows.Forms.TextBox();
            this.EmpPhoneTb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmployeeList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpGenderCb = new System.Windows.Forms.ComboBox();
            this.EmpSalaryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeJoiningCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EmployeeJoiningDate = new System.Windows.Forms.Label();
            this.EmpTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // Emp_manage_label
            // 
            this.Emp_manage_label.AutoSize = true;
            this.Emp_manage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_manage_label.ForeColor = System.Drawing.Color.White;
            this.Emp_manage_label.Location = new System.Drawing.Point(233, 0);
            this.Emp_manage_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emp_manage_label.Name = "Emp_manage_label";
            this.Emp_manage_label.Size = new System.Drawing.Size(260, 22);
            this.Emp_manage_label.TabIndex = 0;
            this.Emp_manage_label.Text = "EMPLOYEE MANAGEMENT";
            // 
            // EmpLeftPanel
            // 
            this.EmpLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.EmpLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmpLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpLeftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpLeftPanel.Name = "EmpLeftPanel";
            this.EmpLeftPanel.Size = new System.Drawing.Size(11, 499);
            this.EmpLeftPanel.TabIndex = 1;
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.LeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LeaveBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.LeaveBtn.IconColor = System.Drawing.Color.White;
            this.LeaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LeaveBtn.IconSize = 35;
            this.LeaveBtn.Location = new System.Drawing.Point(753, 82);
            this.LeaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(100, 34);
            this.LeaveBtn.TabIndex = 2;
            this.LeaveBtn.Text = "Leaves";
            this.LeaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LeaveBtn.UseVisualStyleBackColor = false;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // CategoryBtnStaff
            // 
            this.CategoryBtnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.CategoryBtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtnStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CategoryBtnStaff.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.CategoryBtnStaff.IconColor = System.Drawing.Color.White;
            this.CategoryBtnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CategoryBtnStaff.IconSize = 35;
            this.CategoryBtnStaff.Location = new System.Drawing.Point(753, 121);
            this.CategoryBtnStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryBtnStaff.Name = "CategoryBtnStaff";
            this.CategoryBtnStaff.Size = new System.Drawing.Size(100, 34);
            this.CategoryBtnStaff.TabIndex = 1;
            this.CategoryBtnStaff.Text = "Categories";
            this.CategoryBtnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CategoryBtnStaff.UseVisualStyleBackColor = false;
            this.CategoryBtnStaff.Click += new System.EventHandler(this.CategoryBtnStaff_Click);
            // 
            // EmpTopPanel
            // 
            this.EmpTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.EmpTopPanel.Controls.Add(this.Emp_manage_label);
            this.EmpTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpTopPanel.Location = new System.Drawing.Point(11, 0);
            this.EmpTopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpTopPanel.Name = "EmpTopPanel";
            this.EmpTopPanel.Size = new System.Drawing.Size(971, 24);
            this.EmpTopPanel.TabIndex = 2;
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTb.Location = new System.Drawing.Point(30, 73);
            this.EmpNameTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpNameTb.Multiline = true;
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(106, 27);
            this.EmpNameTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(168, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(315, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(31, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(166, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address";
            // 
            // EmpEditBtnStaff
            // 
            this.EmpEditBtnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.EmpEditBtnStaff.FlatAppearance.BorderSize = 0;
            this.EmpEditBtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpEditBtnStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpEditBtnStaff.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpEditBtnStaff.IconColor = System.Drawing.Color.Black;
            this.EmpEditBtnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpEditBtnStaff.Location = new System.Drawing.Point(638, 59);
            this.EmpEditBtnStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpEditBtnStaff.Name = "EmpEditBtnStaff";
            this.EmpEditBtnStaff.Size = new System.Drawing.Size(100, 34);
            this.EmpEditBtnStaff.TabIndex = 15;
            this.EmpEditBtnStaff.Text = "Edit";
            this.EmpEditBtnStaff.UseVisualStyleBackColor = false;
            this.EmpEditBtnStaff.Click += new System.EventHandler(this.EmpEditBtnStaff_Click);
            // 
            // EmpSaveBtnStaff
            // 
            this.EmpSaveBtnStaff.BackColor = System.Drawing.Color.Black;
            this.EmpSaveBtnStaff.FlatAppearance.BorderSize = 0;
            this.EmpSaveBtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSaveBtnStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSaveBtnStaff.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpSaveBtnStaff.IconColor = System.Drawing.Color.Black;
            this.EmpSaveBtnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpSaveBtnStaff.Location = new System.Drawing.Point(638, 102);
            this.EmpSaveBtnStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpSaveBtnStaff.Name = "EmpSaveBtnStaff";
            this.EmpSaveBtnStaff.Size = new System.Drawing.Size(100, 34);
            this.EmpSaveBtnStaff.TabIndex = 16;
            this.EmpSaveBtnStaff.Text = "Save";
            this.EmpSaveBtnStaff.UseVisualStyleBackColor = false;
            this.EmpSaveBtnStaff.Click += new System.EventHandler(this.EmpSaveBtnStaff_Click);
            // 
            // EmpDltBtnStaff
            // 
            this.EmpDltBtnStaff.BackColor = System.Drawing.Color.Gray;
            this.EmpDltBtnStaff.FlatAppearance.BorderSize = 0;
            this.EmpDltBtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpDltBtnStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpDltBtnStaff.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpDltBtnStaff.IconColor = System.Drawing.Color.Black;
            this.EmpDltBtnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpDltBtnStaff.Location = new System.Drawing.Point(638, 145);
            this.EmpDltBtnStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpDltBtnStaff.Name = "EmpDltBtnStaff";
            this.EmpDltBtnStaff.Size = new System.Drawing.Size(100, 34);
            this.EmpDltBtnStaff.TabIndex = 17;
            this.EmpDltBtnStaff.Text = "Delete";
            this.EmpDltBtnStaff.UseVisualStyleBackColor = false;
            this.EmpDltBtnStaff.Click += new System.EventHandler(this.EmpDltBtnStaff_Click);
            // 
            // EmpAddressTb
            // 
            this.EmpAddressTb.Location = new System.Drawing.Point(169, 154);
            this.EmpAddressTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpAddressTb.Multiline = true;
            this.EmpAddressTb.Name = "EmpAddressTb";
            this.EmpAddressTb.Size = new System.Drawing.Size(106, 27);
            this.EmpAddressTb.TabIndex = 19;
            // 
            // EmpPassTb
            // 
            this.EmpPassTb.Location = new System.Drawing.Point(30, 154);
            this.EmpPassTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpPassTb.Multiline = true;
            this.EmpPassTb.Name = "EmpPassTb";
            this.EmpPassTb.Size = new System.Drawing.Size(106, 27);
            this.EmpPassTb.TabIndex = 20;
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.Location = new System.Drawing.Point(318, 81);
            this.EmpPhoneTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpPhoneTb.Multiline = true;
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.Size = new System.Drawing.Size(106, 27);
            this.EmpPhoneTb.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.panel3.Location = new System.Drawing.Point(11, 214);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 8);
            this.panel3.TabIndex = 22;
            // 
            // EmployeeList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeList.ColumnHeadersHeight = 30;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.EmployeeList.Location = new System.Drawing.Point(30, 280);
            this.EmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.RowHeadersVisible = false;
            this.EmployeeList.RowHeadersWidth = 51;
            this.EmployeeList.RowTemplate.Height = 24;
            this.EmployeeList.Size = new System.Drawing.Size(869, 193);
            this.EmployeeList.TabIndex = 23;
            this.EmployeeList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.EmployeeList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.EmployeeList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmployeeList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeList.ThemeStyle.HeaderStyle.Height = 30;
            this.EmployeeList.ThemeStyle.ReadOnly = false;
            this.EmployeeList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.EmployeeList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.EmployeeList.ThemeStyle.RowsStyle.Height = 24;
            this.EmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.EmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(431, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Employee List";
            // 
            // EmpGenderCb
            // 
            this.EmpGenderCb.FormattingEnabled = true;
            this.EmpGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenderCb.Location = new System.Drawing.Point(171, 80);
            this.EmpGenderCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpGenderCb.Name = "EmpGenderCb";
            this.EmpGenderCb.Size = new System.Drawing.Size(92, 21);
            this.EmpGenderCb.TabIndex = 25;
            // 
            // EmpSalaryBox
            // 
            this.EmpSalaryBox.Location = new System.Drawing.Point(318, 161);
            this.EmpSalaryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpSalaryBox.Multiline = true;
            this.EmpSalaryBox.Name = "EmpSalaryBox";
            this.EmpSalaryBox.Size = new System.Drawing.Size(106, 27);
            this.EmpSalaryBox.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(315, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Salary";
            // 
            // EmployeeJoiningCalender
            // 
            this.EmployeeJoiningCalender.Checked = true;
            this.EmployeeJoiningCalender.FillColor = System.Drawing.Color.Black;
            this.EmployeeJoiningCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeJoiningCalender.ForeColor = System.Drawing.Color.White;
            this.EmployeeJoiningCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.EmployeeJoiningCalender.Location = new System.Drawing.Point(433, 80);
            this.EmployeeJoiningCalender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmployeeJoiningCalender.MaxDate = new System.DateTime(9988, 12, 31, 0, 0, 0, 0);
            this.EmployeeJoiningCalender.MinDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.EmployeeJoiningCalender.Name = "EmployeeJoiningCalender";
            this.EmployeeJoiningCalender.Size = new System.Drawing.Size(158, 29);
            this.EmployeeJoiningCalender.TabIndex = 57;
            this.EmployeeJoiningCalender.Value = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            // 
            // EmployeeJoiningDate
            // 
            this.EmployeeJoiningDate.AutoSize = true;
            this.EmployeeJoiningDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeJoiningDate.ForeColor = System.Drawing.Color.Black;
            this.EmployeeJoiningDate.Location = new System.Drawing.Point(433, 60);
            this.EmployeeJoiningDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeJoiningDate.Name = "EmployeeJoiningDate";
            this.EmployeeJoiningDate.Size = new System.Drawing.Size(94, 19);
            this.EmployeeJoiningDate.TabIndex = 56;
            this.EmployeeJoiningDate.Text = "Joining Date";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(982, 499);
            this.Controls.Add(this.EmployeeJoiningCalender);
            this.Controls.Add(this.EmployeeJoiningDate);
            this.Controls.Add(this.EmpSalaryBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryBtnStaff);
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.EmpGenderCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EmpPhoneTb);
            this.Controls.Add(this.EmpPassTb);
            this.Controls.Add(this.EmpAddressTb);
            this.Controls.Add(this.EmpDltBtnStaff);
            this.Controls.Add(this.EmpSaveBtnStaff);
            this.Controls.Add(this.EmpEditBtnStaff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.EmpTopPanel);
            this.Controls.Add(this.EmpLeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.EmpTopPanel.ResumeLayout(false);
            this.EmpTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Emp_manage_label;
        private System.Windows.Forms.Panel EmpLeftPanel;
        private System.Windows.Forms.Panel EmpTopPanel;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton EmpEditBtnStaff;
        private FontAwesome.Sharp.IconButton EmpSaveBtnStaff;
        private FontAwesome.Sharp.IconButton EmpDltBtnStaff;
        private System.Windows.Forms.TextBox EmpAddressTb;
        private System.Windows.Forms.TextBox EmpPassTb;
        private System.Windows.Forms.TextBox EmpPhoneTb;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton LeaveBtn;
        private FontAwesome.Sharp.IconButton CategoryBtnStaff;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EmpGenderCb;
        private System.Windows.Forms.TextBox EmpSalaryBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker EmployeeJoiningCalender;
        private System.Windows.Forms.Label EmployeeJoiningDate;
    }
}