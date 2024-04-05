
namespace Modern_Pharmacy_Managment_System
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.label5 = new System.Windows.Forms.Label();
            this.CategoryList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmpDltBtnCat = new FontAwesome.Sharp.IconButton();
            this.EmpSaveBtn = new FontAwesome.Sharp.IconButton();
            this.EmpEditBtnCat = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpTopPanel = new System.Windows.Forms.Panel();
            this.Emp_manage_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmpLeftPanel = new System.Windows.Forms.Panel();
            this.LeaveBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.StaffFormEmployeesBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList)).BeginInit();
            this.EmpTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.EmpLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(432, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 43;
            this.label5.Text = "Category List";
            // 
            // CategoryList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.CategoryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryList.BackgroundColor = System.Drawing.Color.White;
            this.CategoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CategoryList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryList.DefaultCellStyle = dataGridViewCellStyle6;
            this.CategoryList.EnableHeadersVisualStyles = false;
            this.CategoryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.CategoryList.Location = new System.Drawing.Point(155, 317);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.RowHeadersVisible = false;
            this.CategoryList.RowHeadersWidth = 51;
            this.CategoryList.RowTemplate.Height = 27;
            this.CategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryList.Size = new System.Drawing.Size(828, 267);
            this.CategoryList.TabIndex = 42;
            this.CategoryList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoryList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoryList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.CategoryList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.CategoryList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoryList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoryList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoryList.ThemeStyle.HeaderStyle.Height = 30;
            this.CategoryList.ThemeStyle.ReadOnly = false;
            this.CategoryList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.CategoryList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CategoryList.ThemeStyle.RowsStyle.Height = 27;
            this.CategoryList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.CategoryList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CategoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryList_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.panel3.Location = new System.Drawing.Point(137, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 10);
            this.panel3.TabIndex = 41;
            // 
            // EmpDltBtnCat
            // 
            this.EmpDltBtnCat.BackColor = System.Drawing.Color.Crimson;
            this.EmpDltBtnCat.FlatAppearance.BorderSize = 0;
            this.EmpDltBtnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpDltBtnCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpDltBtnCat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpDltBtnCat.IconColor = System.Drawing.Color.Black;
            this.EmpDltBtnCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpDltBtnCat.Location = new System.Drawing.Point(730, 178);
            this.EmpDltBtnCat.Name = "EmpDltBtnCat";
            this.EmpDltBtnCat.Size = new System.Drawing.Size(133, 42);
            this.EmpDltBtnCat.TabIndex = 37;
            this.EmpDltBtnCat.Text = "Delete";
            this.EmpDltBtnCat.UseVisualStyleBackColor = false;
            this.EmpDltBtnCat.Click += new System.EventHandler(this.EmpDltBtnCat_Click);
            // 
            // EmpSaveBtn
            // 
            this.EmpSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(1)))), ((int)(((byte)(113)))));
            this.EmpSaveBtn.FlatAppearance.BorderSize = 0;
            this.EmpSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSaveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSaveBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpSaveBtn.IconColor = System.Drawing.Color.Black;
            this.EmpSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpSaveBtn.Location = new System.Drawing.Point(730, 130);
            this.EmpSaveBtn.Name = "EmpSaveBtn";
            this.EmpSaveBtn.Size = new System.Drawing.Size(133, 42);
            this.EmpSaveBtn.TabIndex = 36;
            this.EmpSaveBtn.Text = "Save";
            this.EmpSaveBtn.UseVisualStyleBackColor = false;
            this.EmpSaveBtn.Click += new System.EventHandler(this.EmpSaveBtn_Click);
            // 
            // EmpEditBtnCat
            // 
            this.EmpEditBtnCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.EmpEditBtnCat.FlatAppearance.BorderSize = 0;
            this.EmpEditBtnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpEditBtnCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpEditBtnCat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpEditBtnCat.IconColor = System.Drawing.Color.Black;
            this.EmpEditBtnCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpEditBtnCat.Location = new System.Drawing.Point(730, 82);
            this.EmpEditBtnCat.Name = "EmpEditBtnCat";
            this.EmpEditBtnCat.Size = new System.Drawing.Size(133, 42);
            this.EmpEditBtnCat.TabIndex = 35;
            this.EmpEditBtnCat.Text = "Edit";
            this.EmpEditBtnCat.UseVisualStyleBackColor = false;
            this.EmpEditBtnCat.Click += new System.EventHandler(this.EmpEditBtnCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(435, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Category Name";
            // 
            // CategoryNameTb
            // 
            this.CategoryNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTb.Location = new System.Drawing.Point(438, 145);
            this.CategoryNameTb.Multiline = true;
            this.CategoryNameTb.Name = "CategoryNameTb";
            this.CategoryNameTb.Size = new System.Drawing.Size(183, 40);
            this.CategoryNameTb.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(432, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Manage Employees";
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
            // EmpLeftPanel
            // 
            this.EmpLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.EmpLeftPanel.Controls.Add(this.LeaveBtn);
            this.EmpLeftPanel.Controls.Add(this.iconButton5);
            this.EmpLeftPanel.Controls.Add(this.StaffFormEmployeesBtn);
            this.EmpLeftPanel.Controls.Add(this.pictureBox1);
            this.EmpLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmpLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpLeftPanel.Name = "EmpLeftPanel";
            this.EmpLeftPanel.Size = new System.Drawing.Size(137, 614);
            this.EmpLeftPanel.TabIndex = 26;
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.LeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LeaveBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.LeaveBtn.IconColor = System.Drawing.Color.White;
            this.LeaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LeaveBtn.Location = new System.Drawing.Point(0, 282);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(137, 52);
            this.LeaveBtn.TabIndex = 6;
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
            this.iconButton5.Location = new System.Drawing.Point(0, 353);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(137, 52);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "Categories";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // StaffFormEmployeesBtn
            // 
            this.StaffFormEmployeesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.StaffFormEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffFormEmployeesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StaffFormEmployeesBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.StaffFormEmployeesBtn.IconColor = System.Drawing.Color.White;
            this.StaffFormEmployeesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StaffFormEmployeesBtn.IconSize = 30;
            this.StaffFormEmployeesBtn.Location = new System.Drawing.Point(0, 209);
            this.StaffFormEmployeesBtn.Name = "StaffFormEmployeesBtn";
            this.StaffFormEmployeesBtn.Size = new System.Drawing.Size(137, 52);
            this.StaffFormEmployeesBtn.TabIndex = 4;
            this.StaffFormEmployeesBtn.Text = "Employees";
            this.StaffFormEmployeesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StaffFormEmployeesBtn.UseVisualStyleBackColor = false;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 614);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EmpDltBtnCat);
            this.Controls.Add(this.EmpSaveBtn);
            this.Controls.Add(this.EmpEditBtnCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpTopPanel);
            this.Controls.Add(this.EmpLeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList)).EndInit();
            this.EmpTopPanel.ResumeLayout(false);
            this.EmpTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.EmpLeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView CategoryList;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton EmpDltBtnCat;
        private FontAwesome.Sharp.IconButton EmpSaveBtn;
        private FontAwesome.Sharp.IconButton EmpEditBtnCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel EmpTopPanel;
        private System.Windows.Forms.Label Emp_manage_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel EmpLeftPanel;
        private FontAwesome.Sharp.IconButton LeaveBtn;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton StaffFormEmployeesBtn;
    }
}