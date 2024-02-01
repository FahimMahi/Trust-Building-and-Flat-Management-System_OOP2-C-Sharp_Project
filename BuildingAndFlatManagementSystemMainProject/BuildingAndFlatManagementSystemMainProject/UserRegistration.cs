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

namespace BuildingAndFlatManagementSystemMainProject
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\h\OneDrive\Documents\FlatDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Create_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTable values('" + UNameTb.Text + "', '" + PhoneTb.Text + "', '" + AddTb.Text + "','" + PassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Account Created Successfully");
                    Con.Close();
                    Reset();
                    LoginPage loginPage = new LoginPage();
                    this.Hide();
                    loginPage.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Reset()
        {
            UNameTb.Text = "";
            PassTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
