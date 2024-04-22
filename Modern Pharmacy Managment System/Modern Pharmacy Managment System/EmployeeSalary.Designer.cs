
namespace Modern_Pharmacy_Managment_System
{
    partial class EmployeeSalary
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalaryAmountTxt = new System.Windows.Forms.TextBox();
            this.PayDateCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryView = new System.Windows.Forms.DataGridView();
            this.SalaryPaidButton = new FontAwesome.Sharp.IconButton();
            this.EmpIdTxt = new System.Windows.Forms.TextBox();
            this.DeleteSalaryBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(169, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "EmpId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(169, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Salary Amount";
            // 
            // SalaryAmountTxt
            // 
            this.SalaryAmountTxt.Location = new System.Drawing.Point(173, 142);
            this.SalaryAmountTxt.Multiline = true;
            this.SalaryAmountTxt.Name = "SalaryAmountTxt";
            this.SalaryAmountTxt.Size = new System.Drawing.Size(218, 38);
            this.SalaryAmountTxt.TabIndex = 8;
            // 
            // PayDateCalender
            // 
            this.PayDateCalender.Checked = true;
            this.PayDateCalender.FillColor = System.Drawing.Color.Silver;
            this.PayDateCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PayDateCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PayDateCalender.Location = new System.Drawing.Point(173, 230);
            this.PayDateCalender.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PayDateCalender.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PayDateCalender.Name = "PayDateCalender";
            this.PayDateCalender.Size = new System.Drawing.Size(200, 36);
            this.PayDateCalender.TabIndex = 10;
            this.PayDateCalender.Value = new System.DateTime(2024, 4, 21, 21, 9, 19, 426);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(169, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pay Date";
            // 
            // SalaryView
            // 
            this.SalaryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryView.Location = new System.Drawing.Point(12, 312);
            this.SalaryView.Name = "SalaryView";
            this.SalaryView.RowHeadersWidth = 51;
            this.SalaryView.RowTemplate.Height = 24;
            this.SalaryView.Size = new System.Drawing.Size(962, 224);
            this.SalaryView.TabIndex = 12;
            // 
            // SalaryPaidButton
            // 
            this.SalaryPaidButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SalaryPaidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryPaidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryPaidButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.SalaryPaidButton.IconColor = System.Drawing.Color.Black;
            this.SalaryPaidButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SalaryPaidButton.Location = new System.Drawing.Point(418, 230);
            this.SalaryPaidButton.Name = "SalaryPaidButton";
            this.SalaryPaidButton.Size = new System.Drawing.Size(179, 54);
            this.SalaryPaidButton.TabIndex = 13;
            this.SalaryPaidButton.Text = "Pay ";
            this.SalaryPaidButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalaryPaidButton.UseVisualStyleBackColor = false;
            this.SalaryPaidButton.Click += new System.EventHandler(this.SalaryPaidButton_Click);
            // 
            // EmpIdTxt
            // 
            this.EmpIdTxt.Location = new System.Drawing.Point(173, 62);
            this.EmpIdTxt.Multiline = true;
            this.EmpIdTxt.Name = "EmpIdTxt";
            this.EmpIdTxt.Size = new System.Drawing.Size(218, 37);
            this.EmpIdTxt.TabIndex = 0;
            // 
            // DeleteSalaryBtn
            // 
            this.DeleteSalaryBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteSalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSalaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSalaryBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.DeleteSalaryBtn.IconColor = System.Drawing.Color.Black;
            this.DeleteSalaryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteSalaryBtn.Location = new System.Drawing.Point(621, 230);
            this.DeleteSalaryBtn.Name = "DeleteSalaryBtn";
            this.DeleteSalaryBtn.Size = new System.Drawing.Size(179, 54);
            this.DeleteSalaryBtn.TabIndex = 14;
            this.DeleteSalaryBtn.Text = "Delete";
            this.DeleteSalaryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteSalaryBtn.UseVisualStyleBackColor = false;
            this.DeleteSalaryBtn.Click += new System.EventHandler(this.DeleteSalaryBtn_Click);
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 669);
            this.Controls.Add(this.DeleteSalaryBtn);
            this.Controls.Add(this.SalaryPaidButton);
            this.Controls.Add(this.SalaryView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PayDateCalender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalaryAmountTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpIdTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSalary";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalaryAmountTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker PayDateCalender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SalaryView;
        private FontAwesome.Sharp.IconButton SalaryPaidButton;
        private System.Windows.Forms.TextBox EmpIdTxt;
        private FontAwesome.Sharp.IconButton DeleteSalaryBtn;
    }
}