using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemBengkel
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2SP6M1;Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (usernameText.Text == "" && passwordText.Text == "")
            {
                MessageBox.Show("Masukan Username dan Password!!!");
            }
            else
            {
                string username = usernameText.Text;
                string password = passwordText.Text;
                con.Open();
                string query = "SELECT * FROM tb_user WHERE username = '" + username + "' AND password = '" + password + "'";
                
               
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    this.Hide();
                    MasterCustomer mc = new MasterCustomer();
                    mc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Gagal, username / password salah!!");
                    usernameText.Clear();
                    passwordText.Clear();
                } 
               
                reader.Close();
            }
        }

        
    }
}
