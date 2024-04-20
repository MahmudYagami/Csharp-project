using System;
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
    public partial class StaffInfoPanel : Form

    {  
        public StaffInfoPanel()
        {
            InitializeComponent();


            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFABNK;Initial Catalog=hello;Integrated Security=True");
            


            con.Open();
            SqlCommand cm = new SqlCommand("SELECT Count(*) From tbCustomer", con);
            var totalCustomer = cm.ExecuteScalar();
            if (int.Parse(totalCustomer.ToString()) < 10)
            {
                totalCustomer = "0" + totalCustomer;
            }
            lblCustomerCount.Text = totalCustomer.ToString();
            con.Close();



            con.Open();
            SqlCommand cm2 = new SqlCommand("SELECT Count(*) From InventoryTbl", con);
            var totalMedicine = cm2.ExecuteScalar();
            if( int.Parse(totalMedicine.ToString()) < 10)
            {
                totalMedicine = "0" + totalMedicine;
            }
            lblMadiniceCount.Text = totalMedicine.ToString();
            con.Close();
                  


            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl WHERE PStock < 50", con);
            int count = (int)cmd.ExecuteScalar();
            if (count < 10)
            {
                lblMadicineShortage.Text= "0"+ count.ToString();
            }
            else { lblMadicineShortage.Text = count.ToString(); }
            
        }
        public void loadform(object Form)
        {
            StaffDashboard sd = new StaffDashboard();

            if (sd.mainPanel.Controls.Count > 0)
                sd.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            sd.mainPanel.Controls.Add(f);
            sd.mainPanel.Tag = f;
            f.Show();
        }


        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            loadform(new CustomerForm());
        }

        private void btnMedicineShortage_Click(object sender, EventArgs e)
        {
            loadform(new CustomerForm());
        }
    }
}
