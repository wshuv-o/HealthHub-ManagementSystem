using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class AddMedicineUserControl : UserControl
    {
        public AddMedicineUserControl()
        {
            InitializeComponent();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool a=DBConnection.InsertDataIntoMedicineTable(
                medNametextBox.Text,
                expireDateTimePicker.Value,
                manufactureDateTimePicker.Value,
                int.Parse(quantitytextBox.Text),
                double.Parse(priceTextBox.Text)
            );
            if (a)
            {
                MessageBox.Show("Medicine Added Successfully!");
                medNametextBox.Text = string.Empty;
                expireDateTimePicker.Value = DateTime.Now;
                manufactureDateTimePicker.Value = DateTime.Now;
                quantitytextBox.Text = string.Empty;
                priceTextBox.Text = string.Empty;
            }
            else
                MessageBox.Show("Error Adding new Medicine!");

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
