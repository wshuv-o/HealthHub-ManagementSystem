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
    public partial class UpdateMedicine_UserControl : UserControl
    {
        public UpdateMedicine_UserControl()
        {
            InitializeComponent();
            LoadMedicineData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quantitytextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMedicineData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM [dbo].[Medicine]";
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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                priceTextBox.Text = selectedRow.Cells["Unit_price"].Value.ToString();
                quantitytextBox.Text = selectedRow.Cells["Quantity"].Value.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    double newPrice = double.Parse(priceTextBox.Text);
                    int newQuantity = int.Parse(quantitytextBox.Text);
                    dataGridView1.Rows[selectedIndex].Cells["Unit_price"].Value = newPrice;
                    dataGridView1.Rows[selectedIndex].Cells["Quantity"].Value = newQuantity;
                    int medicineID = int.Parse(dataGridView1.Rows[selectedIndex].Cells["Medicine_ID"].Value.ToString());
                    DBConnection.UpdateRowInDatabase(medicineID, selectedIndex, newPrice, newQuantity);
                    dataGridView1.ClearSelection();
                    priceTextBox.Clear();
                    quantitytextBox.Clear();

                    MessageBox.Show("Row updated successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a row before updating.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating row: " + ex.Message);
            }
        }

        }
    }

