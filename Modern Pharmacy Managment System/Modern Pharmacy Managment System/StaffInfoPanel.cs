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
using Modern_Pharmacy_Managment_System.Database;

namespace Modern_Pharmacy_Managment_System
{
    public partial class StaffInfoPanel : Form

    {  
        public StaffInfoPanel()
        {
            InitializeComponent();



            using (var con = DatabaseConnection.databaseConnect()) 
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT Count(*) From tbCustomer", con);
                var totalCustomer = cm.ExecuteScalar();
                if (int.Parse(totalCustomer.ToString()) < 10)
                {
                    totalCustomer = "0" + totalCustomer;
                }
                lblCustomerCount.Text = totalCustomer.ToString();
                con.Close();


                // Medicine Count

                con.Open();

                // Check total medicine count
                SqlCommand cm2 = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl", con);
                int totalMedicineCount = (int)cm2.ExecuteScalar();
                string totalMedicineDisplay = totalMedicineCount < 10 ? "0" + totalMedicineCount.ToString() : totalMedicineCount.ToString();
                lblMadiniceCount.Text = totalMedicineDisplay;

                // Check for medicine shortage
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl WHERE PStock < 50", con);
                int shortageCount = (int)cmd.ExecuteScalar();
                string shortageCountDisplay = shortageCount < 10 ? "0" + shortageCount.ToString() : shortageCount.ToString();
                lblMadicineShortage.Text = shortageCountDisplay;

                // If shortage, insert details into MedicineShortageTbl if not already there
                if (shortageCount > 0)
                {
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM MedicineShortageTbl WHERE SId IN (SELECT PId FROM InventoryTbl WHERE PStock < 50)", con);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        SqlCommand insertCmd = new SqlCommand("INSERT INTO MedicineShortageTbl (SId, SName, SQuantity, SBuyingPrice) SELECT PId, PName, PStock, PBuyingPrice FROM InventoryTbl WHERE PStock < 50", con);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                con.Close();


            }



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
            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new addproductPha());
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new CustomerForm());
            this.Hide();
        }

        private void btnMedicineShortage_Click(object sender, EventArgs e)
        {
            MedicineShortage ms = new MedicineShortage();
            ms.Show();
        }
    }
}
