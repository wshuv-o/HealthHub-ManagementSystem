using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ViewMedicine_UserControl : UserControl
    {
        public ViewMedicine_UserControl()
        {
            InitializeComponent();
            string sqlSelect = "SELECT * FROM [dbo].[Medicine]";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, DBConnection.ConnectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void searchbox()
        {
            try
            {

            string s = "";
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                s = $" SELECT * FROM [dbo].[Medicine] WHERE Medicine_name LIKE '%{searchTextBox.Text}%'";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(s, DBConnection.ConnectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception) { }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchbox();
        }
        private void LoadMedicineData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect;
                    if (validComboBox.SelectedItem.ToString() == "All Medicine")
                    {
                        sqlSelect = "SELECT * FROM [dbo].[Medicine]";
                    }
                    else if (validComboBox.SelectedItem.ToString() == "Expired Medicine")
                    {
                        sqlSelect = "SELECT * FROM [dbo].[Medicine] WHERE Medicine_expirydate < GETDATE()";
                    }
                    else if (validComboBox.SelectedItem.ToString() == "Valid Medicine ")
                    {
                        sqlSelect = "SELECT * FROM [dbo].[Medicine] WHERE Medicine_expirydate >= GETDATE()";
                    }
                    else
                    {
                        return;
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicine data: " + ex.Message);
            }
        }
        private void RefreshMedicineData()
        {
            LoadMedicineData();
        }
        private void validComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMedicineData();
        }


    }
}
