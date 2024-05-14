using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Modern_Pharmacy_Managment_System.Database;

namespace Modern_Pharmacy_Managment_System
{
    public partial class DashBoard : Form
    {
        private bool isCollapsed;
        public DashBoard()
        {
            InitializeComponent();


            //initializing events
            ManagementBtn.MouseEnter += ManagementBtn_MouseEnter;
            ManagementBtn.MouseLeave += ManagementBtn_MouseLeave;
            Settings.MouseEnter += logoutBtn_MouseEnter;
            Settings.MouseLeave += logoutBtn_MouseLeave;
            InventoryBtn.MouseEnter += InventoryBtn_MouseEnter;
            InventoryBtn.MouseLeave += InventoryBtn_MouseLeave;
            RevenueBtn.MouseEnter += RevenueBtn_MouseEnter;
            RevenueBtn.MouseLeave += RevenueBtn_MouseLeave;
            DashBoardBtn.MouseEnter += DashBoardBtn_MouseEnter;
            DashBoardBtn.MouseLeave += DashBoardBtn_MouseLeave;

            StaffBtn.MouseEnter += StaffBtn_MouseEnter;
            StaffBtn.MouseLeave += StaffBtn_MouseLeave;

            SalaryPayBtn.MouseEnter += SalaryPayBtn_MouseEnter;
            SalaryPayBtn.MouseLeave += SalaryPayBtn_MouseLeave;
           loadform(new AdminMainDashboard());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
               
                DropdownPanel.Height += 10;
                if(DropdownPanel.Size==DropdownPanel.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }


            }
            else
            {
                DropdownPanel.Height -= 10;
                if (DropdownPanel.Size == DropdownPanel.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }

        }

        private void ManagementBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void experimentBtn_Click(object sender, EventArgs e)
        {

        }

        //cahnge color while hovering the mouse
        private void ManagementBtn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            ManagementBtn.BackColor = Color.Cyan; // Change to desired color
        }
        private void ManagementBtn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color back to normal when mouse leaves
            ManagementBtn.BackColor = Color.FromArgb(40, 51, 66); // Change to the default background color of your form
        }

        private void DashBoardBtn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            DashBoardBtn.BackColor = Color.Cyan; // Change to desired color
        }
        private void DashBoardBtn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color back to normal when mouse leaves
            DashBoardBtn.BackColor = Color.FromArgb(40, 51, 66); // Change to the default background color of your form
        }
        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            Settings.BackColor = Color.Cyan; // Change to desired color
        }
        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color back to normal when mouse leaves
            Settings.BackColor = Color.FromArgb(40, 51, 66); // Change to the default background color of your form
        }
        private void InventoryBtn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            InventoryBtn.BackColor = Color.Cyan; // Change to desired color
        }
        private void InventoryBtn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color back to normal when mouse leaves
            InventoryBtn.BackColor = Color.FromArgb(40, 51, 66); // Change to the default background color of your form
        }
        private void RevenueBtn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            RevenueBtn.BackColor = Color.Cyan; // Change to desired color
        }
        private void RevenueBtn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color back to normal when mouse leaves
            RevenueBtn.BackColor = Color.FromArgb(40, 51, 66); // Change to the default background color of your form
        }

        private void StaffBtn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            StaffBtn.BackColor = Color.Red; // Change to desired color
        }
        private void StaffBtn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color back to normal when mouse leaves
            StaffBtn.BackColor = Color.FromArgb(29, 36, 46); // Change to the default background color of your form
        }

        private void SalaryPayBtn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            SalaryPayBtn.BackColor = Color.Purple; // Change to desired color
        }
        private void SalaryPayBtn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color back to normal when mouse leaves
            SalaryPayBtn.BackColor = Color.FromArgb(29, 36, 46); // Change to the default background color of your form
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimeShow_Tick(object sender, EventArgs e)
        {
           /* TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();*/


        }


        //DISPLAY INDIVIDUAL FORMS

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void CustomerBtn_Click(object sender, EventArgs e)
        {
          loadform(new CustomerForm());
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
           loadform(new StaffForm());
        }


        private void TimerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            loadform(new AdminMainDashboard());
        }

        private void SalaryPayBtn_Click(object sender, EventArgs e)
        {
            loadform(new EmployeeSalary());
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            loadform(new addproductPha());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loadform(new AdminForgotPass());
           
        }

        private void RevenueBtn_Click(object sender, EventArgs e)
        {
            loadform(new Revenue());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

            // Collect references to forms to close
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form is LeavesForm || form is StaffForm)
                {
                    formsToClose.Add(form);
                }
            }

            // Close collected forms
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }


    }
}
