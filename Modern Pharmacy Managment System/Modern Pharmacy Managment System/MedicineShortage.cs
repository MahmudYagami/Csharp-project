﻿using Modern_Pharmacy_Managment_System.Database;
using Modern_Pharmacy_Managment_System.Classes;
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
    public partial class MedicineShortage : Form
    {
        Functions Con;
        public MedicineShortage()
        {
            InitializeComponent();
            // DisplayMedicineShortage();
            Con = new Functions();
            showMedicineList();
        }

        

                
       public void showMedicineList()
        {
            string Query = "SELECT SId, SName, SQuantity, SBuyingPrice FROM MedicineShortageTbl";
            dgvMedicineShortage.DataSource = Con.GetData(Query);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DisplayMedicineShortage()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT SId, SName, SQuantity, SBuyingPrice FROM MedicineShortageTbl", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgvMedicineShortage.Rows.Add(reader["SId"], reader["SName"], reader["SQuantity"], reader["SBuyingPrice"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dgvMedicineShortage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedicineShortage.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMedicineShortage.SelectedRows[0];
                txtId.Text = selectedRow.Cells[0].Value.ToString();

                // Assuming SName, SQuantity, SBuyingPrice are the column names in dgvMedicineShortage
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtUnitPrice.Text = selectedRow.Cells[3].Value.ToString();

                CalculateTotalPrice();
            }
        }

        private void txtStockValue_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            if (!string.IsNullOrEmpty(txtRestockValue.Text) && !string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                int restockValue = int.Parse(txtRestockValue.Text);
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                decimal totalPrice = restockValue * unitPrice;
                txtTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Update InventoryTbl PStock
                    SqlCommand updateCmd = new SqlCommand("UPDATE InventoryTbl SET PStock = PStock + @RestockValue WHERE PId = @Id", con);
                    updateCmd.Parameters.AddWithValue("@RestockValue", int.Parse(txtRestockValue.Text));
                    updateCmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    updateCmd.ExecuteNonQuery();

                    // Update MedicineShortageTbl SQuantity
                    SqlCommand updateShortageCmd = new SqlCommand("UPDATE MedicineShortageTbl SET SQuantity = SQuantity + @RestockValue WHERE SId = @Id", con);
                    updateShortageCmd.Parameters.AddWithValue("@RestockValue", int.Parse(txtRestockValue.Text));
                    updateShortageCmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    updateShortageCmd.ExecuteNonQuery();

                    // Check if the item is still in shortage
                    SqlCommand checkCmd = new SqlCommand("SELECT SQuantity FROM MedicineShortageTbl WHERE SId = @Id", con);
                    checkCmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    int SQuantity = (int)checkCmd.ExecuteScalar();

                    // If SQuantity is > 50, remove the item from MedicineShortageTbl
                    if (SQuantity > 50)
                    {
                        SqlCommand deleteCmd = new SqlCommand("DELETE FROM MedicineShortageTbl WHERE SId = @Id", con);
                        deleteCmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                        deleteCmd.ExecuteNonQuery();
                    }

                    // Insert expense into AccountTbl
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO AccountTbl (Expense, Date) VALUES (@Expense, @Date)", con);
                    insertCmd.Parameters.AddWithValue("@Expense", float.Parse(txtTotalPrice.Text)); // Assuming Expense is float
                    insertCmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    insertCmd.ExecuteNonQuery();

                    showMedicineList();
                    MessageBox.Show("Restock successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtUnitPrice.Clear();
            txtRestockValue.Clear();
            txtTotalPrice.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showMedicineList();
            // DisplayMedicineShortage();
        }
    }
}