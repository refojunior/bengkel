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
    public partial class MasterCustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2SP6M1;Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;


        public MasterCustomer()
        {
            InitializeComponent();
            fillComboBox();
        }

        /* 
         -- CODINGAN MENU TARUH DISINI -- 
        */

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCustomer.Visible = true;
            panelKendaraan.Visible = false;
        }


        private void kendaraanToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelCustomer.Visible = false;
            panelKendaraan.Visible = true;
        }

        private void MasterCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        /* 
         -- END CODINGAN MENU -- 
        */

        public void fillComboBox()
        {
            con.Open();
            string query = "SELECT * FROM tb_customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, this.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                comboBoxCustomer.Items.Add(row["id"] + " - " +row["nama_customer"].ToString());
            }
            con.Close();
        }
        
        public void loadData()
        {
            con.Open();
            string query = "SELECT * FROM tb_customer";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            SDA.Fill(data);
            showCustomersGrid.DataSource = data;
            showCustomersGrid.Refresh();
            con.Close();

        }

        public void resetForm()
        {
            idText.Text = "?";
            namaCustText.Text = "";
            alamatText.Text = "";
            emailText.Text = "";
            telpText.Text = "";
        }

        MasterCustomer obj = (MasterCustomer)Application.OpenForms["Form1"];


        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM tb_customer";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            SDA.Fill(data);
            showCustomersGrid.DataSource = data;

            //table kendaraan
            string queryKendaraan = "SELECT * FROM tb_kendaraan";
            SqlDataAdapter SDAKendaraan = new SqlDataAdapter(queryKendaraan, this.con);
            DataTable dataKendaraan = new DataTable();
            SDAKendaraan.Fill(dataKendaraan);
            showKendaraanGrid.DataSource = dataKendaraan;

            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validasi (data tidak boleh kosong) kalo bisa ini fungsi aja
            if (namaCustText.Text == "" && alamatText.Text == "" && telpText.Text == "" && emailText.Text == "")
            {
                MessageBox.Show("Form tidak boleh kosong!");
            }
            else
            {
                con.Open();
                if (idText.Text == "?")
                {
                    string sql = "INSERT INTO tb_customer VALUES ('" + namaCustText.Text + "','" + alamatText.Text + "','" + emailText.Text + "','" + telpText.Text + "')";
                    cmd = new SqlCommand(sql, this.con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    string sql = "SELECT * FROM tb_customer WHERE id = '" + idText.Text + "'";
                    cmd = new SqlCommand(sql, this.con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        sql = "UPDATE tb_customer SET nama_customer = '" + namaCustText.Text + "', alamat = '" + alamatText.Text + "', email = '" + emailText.Text + "', telp = '" + telpText.Text + "' WHERE id = '" + idText.Text + "'";
                    }
                    reader.Close();
                    cmd = new SqlCommand(sql, this.con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                
                MessageBox.Show("Data berhasil di simpan");

                //reset form & data
                loadData();
                showCustomersGrid.Update();
                showCustomersGrid.Refresh();

                resetForm();

            }
        }

        private void showCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            
            string id = showCustomersGrid.Rows[index].Cells[0].Value.ToString();
            
            //query ke db dengan parameter id yg di select
            con.Open();
            string query = "SELECT * FROM tb_customer WHERE id = '" + id + "'";
            cmd = new SqlCommand(query, this.con);
            reader = cmd.ExecuteReader();
            //tampilkan data di form
            reader.Read();
            idText.Text = reader["id"].ToString();
            namaCustText.Text = reader["nama_customer"].ToString();
            alamatText.Text = reader["alamat"].ToString();
            emailText.Text = reader["email"].ToString();
            telpText.Text = reader["telp"].ToString();

            con.Close();
            //MessageBox.Show(showCustomers.Rows[index].Cells[0].Value.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            string id = idText.Text;
            if (id == "?")
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!!");
            }
            else
            {
                if (MessageBox.Show("Yakin Hapus Data?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    con.Open();
                    string query = "DELETE FROM tb_customer WHERE id = '" + id + "'";
                    cmd = new SqlCommand(query, this.con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil dihapus!");

                    loadData();
                    showCustomersGrid.Update();
                    showCustomersGrid.Refresh();
                    resetForm();
                }
            }
            
            
        }

       
        

        
   
        
        
        

   
      
     
    }
}
