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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ishti\OneDrive\Desktop\Csharp-project\DATABASE TABLE\StaffDbDemo.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cm = new SqlCommand("SELECT Count(*) From tbCustomer", con);
            var totalCustomer = cm.ExecuteScalar();
            lblCustomerCount.Text = totalCustomer.ToString();
            con.Close();

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
