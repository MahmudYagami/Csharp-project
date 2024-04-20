using System;
using System.Data;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class Login : Form
    {
        Functions Con;
        public Login()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signupLabel_Click(object sender, EventArgs e)
        {

        }

        public static int EmpId;
        public static string EmpName = "";

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (signupName.Text == "" || signupPhone.Text == "")
            {
                MessageBox.Show("Missing Info!!!");
            }
            else
            {
                // Check if it's admin login
                if (signupName.Text == "Admin" && signupPhone.Text == "")
                {
                    StaffForm sf = new StaffForm();
                    sf.Show();
                    this.Hide();
                }
                else
                {
                    try
                    {
                        // Check in the EmployeeTbl first
                        string empQuery = "Select * from EmployeeTbl where EmpName='{0}' and EmpPass='{1}'";
                        empQuery = string.Format(empQuery, signupName.Text, signupPhone.Text);
                        DataTable empDt = Con.GetData(empQuery);

                        // If not found in EmployeeTbl, check in the tbCustomer
                        if (empDt.Rows.Count == 0)
                        {
                            // Check in the AdminTbl for admin login
                            string adminQuery = "Select * from AdminTbl where AdminUsername='{0}' and AdminPassword='{1}'";
                            adminQuery = string.Format(adminQuery, signupName.Text, signupPhone.Text);
                            DataTable adminDt = Con.GetData(adminQuery);

                            // If found in AdminTbl, login as admin
                            if (adminDt.Rows.Count > 0)
                            {
                                MessageBox.Show("Admin Login Success!");
                                // Now you can navigate to the AdminDashboard or perform other actions for admins
                                DashBoard ad = new DashBoard();
                                ad.Show();
                                this.Hide();
                            }
                            else
                            {
                                // If not found in AdminTbl, check in tbCustomer
                                string customerQuery = "Select * from tbCustomer where cphone='{0}' and cpassword='{1}'";
                                customerQuery = string.Format(customerQuery, signupName.Text, signupPhone.Text);
                                DataTable customerDt = Con.GetData(customerQuery);

                                // If found in tbCustomer, login as customer
                                if (customerDt.Rows.Count > 0)
                                {
                                    MessageBox.Show("Customer Login Success!");
                                    // Now you can navigate to the CustomerDashboard or perform other actions for customers
                                    string customerName = customerDt.Rows[0]["cname"].ToString();
                                    CustomerDashboard cd = new CustomerDashboard(customerName);
                                    cd.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Phone Number or Password!!!");
                                    signupName.Text = "";
                                    signupPhone.Text = "";
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Staff Login Success!");
                            // If it's found in EmployeeTbl, it's staff login. Now open the StaffDashboard form.
                            EmpId = Convert.ToInt32(empDt.Rows[0][0].ToString());
                            EmpName = empDt.Rows[0][1].ToString(); // Set the staff name
                            StaffDashboard sd = new StaffDashboard();
                            sd.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }
    }
}
