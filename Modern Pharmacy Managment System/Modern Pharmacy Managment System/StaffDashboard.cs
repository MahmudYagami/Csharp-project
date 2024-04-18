﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Modern_Pharmacy_Managment_System
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();

            lblName.Text = Login.EmpName + "";
            //lblId.Text = Login.EmpId + " ";
            loadform(new StaffInfoPanel());

        }



        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        

        

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            loadform(new StaffInfoPanel());
        }


        private void btnLeave_Click_1(object sender, EventArgs e)
        {
            loadform(new ViewLeave());
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            loadform(new CustomerForm());
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            loadform(new StaffSettings());
        }
    }
}
