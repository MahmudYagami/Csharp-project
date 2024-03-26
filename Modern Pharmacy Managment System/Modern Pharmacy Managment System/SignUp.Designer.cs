
namespace Modern_Pharmacy_Managment_System
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanelSignup = new Guna.UI2.WinForms.Guna2Panel();
            this.signupLoginLabel = new System.Windows.Forms.LinkLabel();
            this.signupAccountLabel = new System.Windows.Forms.Label();
            this.signupPhoneLabel = new System.Windows.Forms.Label();
            this.signupNameLabel = new System.Windows.Forms.Label();
            this.signupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.signupLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.signupPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.signupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanelSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(343, 506);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-19, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanelSignup
            // 
            this.mainPanelSignup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanelSignup.Controls.Add(this.signupLoginLabel);
            this.mainPanelSignup.Controls.Add(this.signupAccountLabel);
            this.mainPanelSignup.Controls.Add(this.signupPhoneLabel);
            this.mainPanelSignup.Controls.Add(this.signupNameLabel);
            this.mainPanelSignup.Controls.Add(this.signupBtn);
            this.mainPanelSignup.Controls.Add(this.signupLabel);
            this.mainPanelSignup.Controls.Add(this.signupPhone);
            this.mainPanelSignup.Controls.Add(this.signupName);
            this.mainPanelSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelSignup.Location = new System.Drawing.Point(343, 0);
            this.mainPanelSignup.Name = "mainPanelSignup";
            this.mainPanelSignup.ShadowDecoration.Parent = this.mainPanelSignup;
            this.mainPanelSignup.Size = new System.Drawing.Size(380, 506);
            this.mainPanelSignup.TabIndex = 1;
            // 
            // signupLoginLabel
            // 
            this.signupLoginLabel.AutoSize = true;
            this.signupLoginLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLoginLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signupLoginLabel.Location = new System.Drawing.Point(208, 376);
            this.signupLoginLabel.Name = "signupLoginLabel";
            this.signupLoginLabel.Size = new System.Drawing.Size(37, 15);
            this.signupLoginLabel.TabIndex = 7;
            this.signupLoginLabel.TabStop = true;
            this.signupLoginLabel.Text = "Login";
            this.signupLoginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLoginLabel_LinkClicked);
            // 
            // signupAccountLabel
            // 
            this.signupAccountLabel.AutoSize = true;
            this.signupAccountLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupAccountLabel.Location = new System.Drawing.Point(60, 376);
            this.signupAccountLabel.Name = "signupAccountLabel";
            this.signupAccountLabel.Size = new System.Drawing.Size(142, 15);
            this.signupAccountLabel.TabIndex = 6;
            this.signupAccountLabel.Text = "Already have an account?";
            this.signupAccountLabel.Click += new System.EventHandler(this.signupAccountLabel_Click);
            // 
            // signupPhoneLabel
            // 
            this.signupPhoneLabel.AutoSize = true;
            this.signupPhoneLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPhoneLabel.Location = new System.Drawing.Point(59, 177);
            this.signupPhoneLabel.Name = "signupPhoneLabel";
            this.signupPhoneLabel.Size = new System.Drawing.Size(102, 19);
            this.signupPhoneLabel.TabIndex = 5;
            this.signupPhoneLabel.Text = "Phone Number";
            // 
            // signupNameLabel
            // 
            this.signupNameLabel.AutoSize = true;
            this.signupNameLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupNameLabel.Location = new System.Drawing.Point(59, 91);
            this.signupNameLabel.Name = "signupNameLabel";
            this.signupNameLabel.Size = new System.Drawing.Size(45, 19);
            this.signupNameLabel.TabIndex = 4;
            this.signupNameLabel.Text = "Name";
            this.signupNameLabel.Click += new System.EventHandler(this.signupNameLabel_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BorderRadius = 12;
            this.signupBtn.CheckedState.Parent = this.signupBtn;
            this.signupBtn.CustomImages.Parent = this.signupBtn;
            this.signupBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.HoverState.Parent = this.signupBtn;
            this.signupBtn.Location = new System.Drawing.Point(59, 286);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.ShadowDecoration.Parent = this.signupBtn;
            this.signupBtn.Size = new System.Drawing.Size(237, 45);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // signupLabel
            // 
            this.signupLabel.BackColor = System.Drawing.Color.Transparent;
            this.signupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.Location = new System.Drawing.Point(132, 26);
            this.signupLabel.Margin = new System.Windows.Forms.Padding(0);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(96, 31);
            this.signupLabel.TabIndex = 2;
            this.signupLabel.Text = "Sign Up";
            this.signupLabel.Click += new System.EventHandler(this.signupLabel_Click);
            // 
            // signupPhone
            // 
            this.signupPhone.BorderRadius = 8;
            this.signupPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupPhone.DefaultText = "";
            this.signupPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupPhone.DisabledState.Parent = this.signupPhone;
            this.signupPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupPhone.FocusedState.Parent = this.signupPhone;
            this.signupPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupPhone.HoverState.Parent = this.signupPhone;
            this.signupPhone.Location = new System.Drawing.Point(59, 205);
            this.signupPhone.Name = "signupPhone";
            this.signupPhone.PasswordChar = '\0';
            this.signupPhone.PlaceholderText = "01111111111";
            this.signupPhone.SelectedText = "";
            this.signupPhone.ShadowDecoration.Parent = this.signupPhone;
            this.signupPhone.Size = new System.Drawing.Size(237, 44);
            this.signupPhone.TabIndex = 1;
            this.signupPhone.TextOffset = new System.Drawing.Point(25, 0);
            this.signupPhone.TextChanged += new System.EventHandler(this.signupPhone_TextChanged);
            // 
            // signupName
            // 
            this.signupName.BorderRadius = 8;
            this.signupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupName.DefaultText = "";
            this.signupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupName.DisabledState.Parent = this.signupName;
            this.signupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupName.FocusedState.Parent = this.signupName;
            this.signupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupName.HoverState.Parent = this.signupName;
            this.signupName.Location = new System.Drawing.Point(59, 114);
            this.signupName.Name = "signupName";
            this.signupName.PasswordChar = '\0';
            this.signupName.PlaceholderText = "Enter Your Name";
            this.signupName.SelectedText = "";
            this.signupName.ShadowDecoration.Parent = this.signupName;
            this.signupName.Size = new System.Drawing.Size(237, 44);
            this.signupName.TabIndex = 0;
            this.signupName.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 506);
            this.Controls.Add(this.mainPanelSignup);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanelSignup.ResumeLayout(false);
            this.mainPanelSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel mainPanelSignup;
        private Guna.UI2.WinForms.Guna2HtmlLabel signupLabel;
        private Guna.UI2.WinForms.Guna2TextBox signupPhone;
        private Guna.UI2.WinForms.Guna2TextBox signupName;
        private Guna.UI2.WinForms.Guna2Button signupBtn;
        private System.Windows.Forms.Label signupNameLabel;
        private System.Windows.Forms.Label signupPhoneLabel;
        private System.Windows.Forms.Label signupAccountLabel;
        private System.Windows.Forms.LinkLabel signupLoginLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}