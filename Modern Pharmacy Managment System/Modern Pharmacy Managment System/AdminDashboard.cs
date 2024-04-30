using Modern_Pharmacy_Managment_System.Database;
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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            using (var con = DatabaseConnection.databaseConnect())
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT Count(*) From EmployeeTbl", con);              
                var totalEmployee = cm.ExecuteScalar();
                lblEmployeeCnt.Text = totalEmployee.ToString();




                SqlCommand cm2 = new SqlCommand("SELECT Count(*) From LeaveTbl  WHERE status = 'Approved'", con);
                var totalLeave = cm2.ExecuteScalar();
                lblLeaveCnt.Text = totalLeave.ToString();
                con.Close();
            }
            UnpaidEmployee();






          //  SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RAFSAN\Desktop\StaffDb.mdf;Integrated Security=True;Connect Timeout=30");
            /*con2.Open();
            SqlCommand cm2 = new SqlCommand("SELECT Count(*) From LeaveTbl", con);
            var totalCustomer2 = cm2.ExecuteScalar();
            lblLeaveCnt.Text = totalCustomer2.ToString();*/
            // con2.Close();
        }


        public void UnpaidEmployee()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand(@"
                SELECT 
                    (SELECT COUNT(DISTINCT EmpId) FROM EmployeeTbl) - 
                    (SELECT COUNT(DISTINCT EmpId) FROM SalaryTbl) AS UnpaidEmployeeCount;", con);
                    object unpaidEmployeeCount = cm.ExecuteScalar();
                    if (unpaidEmployeeCount != null)
                    {
                        UnpaidEmpCnt.Text = unpaidEmployeeCount.ToString();
                    }
                    else
                    {
                        UnpaidEmpCnt.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, e.g., display an error message
                MessageBox.Show("Error: " + ex.Message);
            }
        }





    }
}
