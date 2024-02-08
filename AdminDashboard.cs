using HospitalManagementSystem.Resources;
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
    public partial class AdminDashboard : UserControl
    {
        public AdminDashboard()
        {
            InitializeComponent();
            
        }

        private void doctorsButton_Click(object sender, EventArgs e)
        {
            ViewUser_UserControl viewUserUserControl = new ViewUser_UserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(viewUserUserControl);
        }

        private void patientsButton_Click(object sender, EventArgs e)
        {
            EditUserUserControl patientsListUC = new EditUserUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(patientsListUC);
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

        }

        private void receptionistButton_Click(object sender, EventArgs e)
        {
            AddUser adduser=new AddUser();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(adduser);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
