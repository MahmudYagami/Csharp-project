using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard(string customerName)
        {
            InitializeComponent();
            Buy_Medicine_btn.MouseEnter += Buy_Medicine_btn_MouseEnter;
            Buy_Medicine_btn.MouseLeave += Buy_Medicine_btn_MouseLeave;

            CustomerNameTxt.Text = "Welcome, " + customerName + "!";


        }

        private void Buy_Medicine_btn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            Buy_Medicine_btn.BackColor = Color.FromArgb(8, 224, 255); // Change to desired color
        }

        private void Buy_Medicine_btn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            Buy_Medicine_btn.BackColor = Color.FromArgb(40, 51, 66); // Change to desired color
        }


        public void loadform(object Form)
        {
            if (this.CustomerMainPanel.Controls.Count > 0)
                this.CustomerMainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.CustomerMainPanel.Controls.Add(f);
            this.CustomerMainPanel.Tag = f;
            f.Show();
        }

        private void Buy_Medicine_btn_Click(object sender, EventArgs e)
        {
            loadform(new OrderForm());
        }
    }
}
