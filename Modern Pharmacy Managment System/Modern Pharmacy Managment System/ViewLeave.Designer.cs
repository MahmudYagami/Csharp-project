
namespace Modern_Pharmacy_Managment_System
{
    partial class ViewLeave
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmpTopPanel = new System.Windows.Forms.Panel();
            this.Emp_manage_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpIdLbl = new System.Windows.Forms.Label();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.LeaveList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EmpTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(338, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 32);
            this.label5.TabIndex = 43;
            this.label5.Text = "Your\'s Leave Situation";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 246);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 10);
            this.panel3.TabIndex = 41;
            // 
            // EmpTopPanel
            // 
            this.EmpTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpTopPanel.Controls.Add(this.Emp_manage_label);
            this.EmpTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpTopPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmpTopPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpTopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpTopPanel.Name = "EmpTopPanel";
            this.EmpTopPanel.Size = new System.Drawing.Size(995, 32);
            this.EmpTopPanel.TabIndex = 28;
            // 
            // Emp_manage_label
            // 
            this.Emp_manage_label.AutoSize = true;
            this.Emp_manage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_manage_label.ForeColor = System.Drawing.Color.White;
            this.Emp_manage_label.Location = new System.Drawing.Point(312, 0);
            this.Emp_manage_label.Name = "Emp_manage_label";
            this.Emp_manage_label.Size = new System.Drawing.Size(382, 31);
            this.Emp_manage_label.TabIndex = 0;
            this.Emp_manage_label.Text = "EMPLOYEE MANAGEMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(306, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(532, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Employee Name";
            // 
            // EmpIdLbl
            // 
            this.EmpIdLbl.AutoSize = true;
            this.EmpIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmpIdLbl.Location = new System.Drawing.Point(340, 102);
            this.EmpIdLbl.Name = "EmpIdLbl";
            this.EmpIdLbl.Size = new System.Drawing.Size(115, 23);
            this.EmpIdLbl.TabIndex = 46;
            this.EmpIdLbl.Text = "Employee Id";
            this.EmpIdLbl.Click += new System.EventHandler(this.EmpIdLbl_Click);
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmpNameLbl.Location = new System.Drawing.Point(579, 102);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(115, 23);
            this.EmpNameLbl.TabIndex = 47;
            this.EmpNameLbl.Text = "Employee Id";
            // 
            // LeaveList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LeaveList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.LeaveList.ColumnHeadersHeight = 28;
            this.LeaveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LeaveList.DefaultCellStyle = dataGridViewCellStyle6;
            this.LeaveList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.LeaveList.Location = new System.Drawing.Point(25, 320);
            this.LeaveList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeaveList.Name = "LeaveList";
            this.LeaveList.RowHeadersVisible = false;
            this.LeaveList.RowHeadersWidth = 51;
            this.LeaveList.RowTemplate.Height = 24;
            this.LeaveList.Size = new System.Drawing.Size(946, 210);
            this.LeaveList.TabIndex = 48;
            this.LeaveList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LeaveList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.LeaveList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LeaveList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LeaveList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LeaveList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LeaveList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LeaveList.ThemeStyle.HeaderStyle.Height = 28;
            this.LeaveList.ThemeStyle.ReadOnly = false;
            this.LeaveList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.LeaveList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LeaveList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LeaveList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeaveList.ThemeStyle.RowsStyle.Height = 24;
            this.LeaveList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.LeaveList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ViewLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 614);
            this.Controls.Add(this.LeaveList);
            this.Controls.Add(this.EmpNameLbl);
            this.Controls.Add(this.EmpIdLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EmpTopPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewLeave";
            this.Text = "ViewLeave";
            this.EmpTopPanel.ResumeLayout(false);
            this.EmpTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel EmpTopPanel;
        private System.Windows.Forms.Label Emp_manage_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EmpIdLbl;
        private System.Windows.Forms.Label EmpNameLbl;
        private Guna.UI2.WinForms.Guna2DataGridView LeaveList;
    }
}