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
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }



        private void useNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void useNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void sumitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = firstNametextBox.Text;
                string lastName = lastNametextBox.Text;
                DateTime dob = dateTimePicker1.Value;
                string gender = genderComboBox.SelectedItem.ToString(); 
                string contact = contactTextBox.Text;
                decimal salary = decimal.Parse(salaryTextBox.Text);
                string username = useNameTextBox.Text;
                string password = passwordTextBox.Text;
                bool success = DBConnection.InsertDataIntoPharmacistTable(firstName, lastName, dob, gender, contact, salary, username, password);

                if (success)
                {
                    MessageBox.Show("Pharmacist added successfully!");
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Error adding new Pharmacist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearInputFields()
        {
            firstNametextBox.Clear();
            lastNametextBox.Clear();
            dateTimePicker1.Value = DateTime.Now;
            genderComboBox.SelectedIndex = -1;
            contactTextBox.Clear();
            salaryTextBox.Clear();
            useNameTextBox.Clear();
            passwordTextBox.Clear();
        }

    }
}
