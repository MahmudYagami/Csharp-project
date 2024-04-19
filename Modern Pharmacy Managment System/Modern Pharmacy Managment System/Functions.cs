using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Modern_Pharmacy_Managment_System
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;



        public Functions()
        {
            ConStr = @"Data Source=DESKTOP-VQFABNK;Initial Catalog=hello;Integrated Security=True";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
            
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Con);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if(Con.State==ConnectionState.Closed)
            {
                Con.Open();

            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            return Cnt;
        }

        public int insertData(SqlCommand cmd)
        {
            int rowsAffected = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                cmd.Connection = Con;
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return rowsAffected;
        }
    }
}
