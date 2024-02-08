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
    public partial class ViewUser_UserControl : UserControl
    {
        public ViewUser_UserControl()
        {
            InitializeComponent();
            LoadPharmacistData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPharmacistData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM [dbo].[Pharmacist]";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pharmacist data: " + ex.Message);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchPharmacist(searchTextBox.Text);
        }
        private void SearchPharmacist(string searchName = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM [dbo].[Pharmacist]";
                    if (!string.IsNullOrWhiteSpace(searchName))
                    {
                        sqlSelect += $" WHERE ph_firstname LIKE '%{searchName}%'";
                    }
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pharmacist data: " + ex.Message);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
