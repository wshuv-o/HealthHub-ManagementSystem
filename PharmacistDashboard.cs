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
    public partial class PharmacistDashboard : UserControl
    {
        public PharmacistsClass phc;
        public PharmacistDashboard(PharmacistsClass phc)
        {

            InitializeComponent();
            this.phc = phc;
            this.label3.Text = this.phc.PhFirstName;
        }

        private void addMedicineButton_Click(object sender, EventArgs e)
        {
            AddMedicineUserControl addMed = new AddMedicineUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(addMed);
        }

        private void viewMedicineButton_Click(object sender, EventArgs e)
        {
            ViewMedicine_UserControl viewMed = new ViewMedicine_UserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(viewMed);
        }

        private void updateMedicineButton_Click(object sender, EventArgs e)
        {
            UpdateMedicine_UserControl updateMed= new UpdateMedicine_UserControl(); 
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(updateMed);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
