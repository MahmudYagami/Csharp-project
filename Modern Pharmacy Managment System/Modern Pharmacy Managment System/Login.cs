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
            if(signupName.Text==""|| signupPhone.Text=="")
            {
                MessageBox.Show("Missing Info!!!");

            }
            else
            {
                if(signupName.Text=="Admin"&&signupPhone.Text=="")
                {
                    StaffForm sf = new StaffForm();
                    sf.Show();
                    this.Hide();

                }
                else
                {
                    try
                    {
                        string Query = "Select * from EmployeeTbl where EmpName='{0}' and EmpPass='{1}'";
                        Query = string.Format(Query, signupName.Text, signupPhone.Text);
                        DataTable dt = Con.GetData(Query);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Incorrect Password!!!");
                            signupName.Text = "";
                            signupPhone.Text = "";

                        }
                        else
                        {
                            EmpId = Convert.ToInt32(dt.Rows[0][0].ToString());
                            EmpName = dt.Rows[0][1].ToString();
                            ViewLeave obj = new ViewLeave();
                            obj.Show();
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
