using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingAndFlatManagementSystemMainProject
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(UPassTb.Text == "20-1")
            {
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UPassTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(UPassTb.Text))
            {
                e.Cancel = true;
                UPassTb.Focus();
                errorProvider1.SetError(UPassTb, "Please Enter your Password !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider1.SetError(UPassTb, null);
            }
        }
    }
}
