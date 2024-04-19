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


            // Total Number of customer.
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ES6IRGF\MSSQLSERVER01;Initial Catalog=helloUpdated;Integrated Security=True");
            
            con.Open();
            SqlCommand cm = new SqlCommand("SELECT Count(*) From tbCustomer", con);
            var totalCustomer = cm.ExecuteScalar();
            lblCustomerCount.Text = totalCustomer.ToString();
            con.Close();

            con.Open();
            SqlCommand cm2 = new SqlCommand("SELECT Count(*) From InventoryTbl", con);
            var totalMedicine = cm2.ExecuteScalar();
            lblMadiniceCount.Text = totalMedicine.ToString();
            con.Close();
                  
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl WHERE PStock < 50", con);
            int count = (int)cmd.ExecuteScalar(); 
            lblMadicineShortage.Text = count.ToString();
            
           

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
