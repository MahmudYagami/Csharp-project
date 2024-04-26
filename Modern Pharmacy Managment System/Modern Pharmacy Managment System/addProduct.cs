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
using System.Data;

namespace Modern_Pharmacy_Managment_System
{
    public partial class addProduct : UserControl
    {
        const string connectionString = @"Data Source=AKID\SQLEXPRESS;Initial Catalog=PMS;Integrated Security=True";
        public addProduct()
        {
            InitializeComponent();
        }

        private void invAddbtn_Click(object sender, EventArgs e)
        {
            if (invprdIdplace.Text == "" || invPdrNameplace.Text == "" || invCompanyplace.Text == "" || invGenericplace.Text == "" || invStockplace.Text == "" || invSellingplace.Text == "" || invBuyingplace.Text == "")
            {
                MessageBox.Show("Empty feild", "Error MEssage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string checkProdId = "SELECT * FROM InventoryTbl WHERE prod_id = @PId";

                    using (SqlCommand checkPID = new SqlCommand(checkProdId, con))
                    {
                        checkPID.Parameters.AddWithValue("@PId", invprdIdplace.Text.Trim());

                        SqlDataAdapter adp = new SqlDataAdapter(checkPID);
                        DataTable table = new DataTable();
                        adp.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(invprdIdplace.Text.Trim() + "is taken already", "Error MEssage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string insertData = " INSERT INTO products (PId,PName,PCompanyName,PGeneric,PStock,PBuyingPrice,PSellingPrice)" + "VALUES(@PId, @PName, @PCompanyName, @PGeneric,@PStock,@PBuyingPrice,@PSellingPrice)";
                            using (SqlCommand cmd = new SqlCommand(insertData, con))
                            {
                                cmd.Parameters.AddWithValue("@PId", invprdIdplace.Text.Trim());
                                cmd.Parameters.AddWithValue("@PName", invPdrNameplace.Text.Trim());
                                cmd.Parameters.AddWithValue("@PCompanyName", invCompanyplace.Text.Trim());
                                cmd.Parameters.AddWithValue("@PGeneric", invGenericplace.Text.Trim());
                                cmd.Parameters.AddWithValue("@PStock", invStockplace.Text.Trim());
                                cmd.Parameters.AddWithValue("@PBuyingPrice", invSellingplace.Text.Trim());
                                cmd.Parameters.AddWithValue("@PSellingPrice", invBuyingplace.Text.Trim());
                                cmd.ExecuteNonQuery();
                                //ClearF();
                                //displayproduct();

                                MessageBox.Show("Added succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
    }
}
