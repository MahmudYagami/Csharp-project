using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modern_Pharmacy_Managment_System.Classes;
using Modern_Pharmacy_Managment_System.Database;


namespace Modern_Pharmacy_Managment_System
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard(string customerName)
        {
            InitializeComponent();
            btncstOrder.MouseEnter += Buy_Medicine_btn_MouseEnter;
            btncstOrder.MouseLeave += Buy_Medicine_btn_MouseLeave;

            CustomerNameTxt.Text = customerName;


        }

        private void Buy_Medicine_btn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            btncstOrder.BackColor = Color.FromArgb(8, 224, 255); // Change to desired color
        }

        private void Buy_Medicine_btn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            btncstOrder.BackColor = Color.FromArgb(40, 51, 66); // Change to desired color
        }


        public void loadform(object Form)
        {
            if (this.CustomPanel.Controls.Count > 0)
                this.CustomPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.CustomPanel.Controls.Add(f);
            this.CustomPanel.Tag = f;
            f.Show();
        }

        private void Customer_settings_Btn_Click(object sender, EventArgs e)
        {
            loadform(new CustomerSettings());
        }

        private void btncstOrder_Click(object sender, EventArgs e)
        {
            loadform(new OrderForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadform(new CustomerSettings());
        }

        private void btncstLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboardForm = new CustomerDashboard(CustomerNameTxt.Text);
            customerDashboardForm.Show();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
