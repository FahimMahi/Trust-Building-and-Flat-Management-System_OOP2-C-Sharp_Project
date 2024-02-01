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
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            UserNameLb.Text = LoginPage.UserName;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\h\OneDrive\Documents\FlatDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || FSizeTB.Text == "" || QtyTb.Text == "" || BPriceTb.Text == "" || BAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BTable values('" + BNameTb.Text + "', '" + FSizeTB.Text + "','" + QtyTb.Text + "', '" + BPriceTb.Text + "','" + BAddressTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Posted Successfully");
                    Con.Close();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Reset()
        {
            BNameTb.Text = "";
            FSizeTB.Text = "";
            QtyTb.Text = "";
            BPriceTb.Text = "";
            BAddressTb.Text = "";

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
