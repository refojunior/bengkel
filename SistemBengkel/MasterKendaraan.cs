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
    public partial class MasterKendaraan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2SP6M1;Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public MasterKendaraan()
        {
            InitializeComponent();
            fillComboBox();
        }


        public void fillComboBox()
        {
            con.Open();
            string query = "SELECT * FROM tb_customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, this.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                comboBoxCustomer.Items.Add(row["id"] + " - " + row["nama_customer"].ToString());
            }
            con.Close();
        }

        public void loadData()
        {
            //table kendaraan
            con.Open();
            string queryKendaraan = " SELECT a.id, a.customer_id, b.nama_customer, a.nama_kendaraan, a.merk, a.tahun, a.plat_nomor from tb_kendaraan a inner join tb_customer b on a.customer_id = b.id ";
            SqlDataAdapter SDAKendaraan = new SqlDataAdapter(queryKendaraan, this.con);
            DataTable dataKendaraan = new DataTable();
            SDAKendaraan.Fill(dataKendaraan);
            showKendaraanGrid.DataSource = dataKendaraan;

            con.Close();
        }

        public void resetForm()
        {
            
            namaKendaraanText.ReadOnly = false;
            comboBoxCustomer.Enabled = true;

            comboBoxCustomer.Text = "- Pilih ";
            namaKendaraanText.Clear();
            merkText.Clear();
            tahunText.Clear();
            platNomorText.Clear();
        }

        private void MasterKendaraan_Load(object sender, EventArgs e)
        {
            //table kendaraan
            con.Open();
            string queryKendaraan = " SELECT a.id, a.customer_id, b.nama_customer, a.nama_kendaraan, a.merk, a.tahun, a.plat_nomor from tb_kendaraan a inner join tb_customer b on a.customer_id = b.id ";
            SqlDataAdapter SDAKendaraan = new SqlDataAdapter(queryKendaraan, this.con);
            DataTable dataKendaraan = new DataTable();
            SDAKendaraan.Fill(dataKendaraan);
            showKendaraanGrid.DataSource = dataKendaraan;

            con.Close();
        }

        private void btnSaveKendaraan_Click(object sender, EventArgs e)
        {
            string customer = comboBoxCustomer.Text;
            String.Join(" ", customer);
            string cust_id = customer[0].ToString();
            //MessageBox.Show(customer[0].ToString());
            
            if (customer != "- Pilih -" && namaKendaraanText.Text != "" && tahunText.Text != "" && platNomorText.Text != "")
            {
                con.Open();
                string q = "SELECT * FROM tb_kendaraan WHERE customer_id = '" + cust_id + "' AND nama_kendaraan = '" + namaKendaraanText.Text + "'";
                cmd = new SqlCommand(q, this.con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    con.Close();
                    con.Open();

                    string update = "UPDATE tb_kendaraan SET merk = '" + merkText.Text + "', tahun = '" + tahunText.Text + "', plat_nomor = '" + platNomorText.Text + "' WHERE customer_id = '" + cust_id + "' AND nama_kendaraan = '" +namaKendaraanText.Text +"'";
                    cmd = new SqlCommand(update, this.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengedit data!");

                }
                else
                {
                    //close connection sebelumnya dan buka lagi biar bisa insert
                    con.Close();
                    con.Open();
                    //ROW TIDAK ADA LAKUKAN PROSES INSERT
                    
                    string insert = "INSERT INTO tb_kendaraan VALUES ('" + cust_id + "', '" + namaKendaraanText.Text + "', '" + merkText.Text + "', '" + tahunText.Text + "', '" + platNomorText.Text + "')";
                    cmd = new SqlCommand(insert, this.con);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Berhasil menambahkan kendaraan");

                }
                con.Close();
                
                loadData();
                showKendaraanGrid.Update();
                showKendaraanGrid.Refresh();

                resetForm();
            }
            else
            {
                MessageBox.Show("Form ada yang kosong!!");
            }
        }

        private void showKendaraanGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;

            string id = showKendaraanGrid.Rows[index].Cells[1].Value.ToString();
            string kendaraan = showKendaraanGrid.Rows[index].Cells[3].Value.ToString();
            //read only kan
            namaKendaraanText.ReadOnly = true;
            comboBoxCustomer.Enabled = false;

            //query ke db dengan parameter id yg di select
            con.Open();
            string q = "SELECT a.id, a.customer_id, b.nama_customer, a.nama_kendaraan, a.merk, a.tahun, a.plat_nomor from tb_kendaraan a inner join tb_customer b on a.customer_id = b.id WHERE a.customer_id = '" + id + "' AND a.nama_kendaraan = '" + kendaraan + "'";
            cmd = new SqlCommand(q, this.con);
            reader = cmd.ExecuteReader();
            //tampilkan data di form
            reader.Read();
            
            id_kendaraan.Text = reader["id"].ToString();
            id_kendaraan.Visible = false;
            comboBoxCustomer.Text = reader["customer_id"].ToString() + " - " + reader["nama_customer"].ToString();
            namaKendaraanText.Text = reader["nama_kendaraan"].ToString();
            merkText.Text = reader["merk"].ToString();
            tahunText.Text = reader["tahun"].ToString();
            platNomorText.Text = reader["plat_nomor"].ToString();

            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Hapus Data?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = id_kendaraan.Text;
                con.Open();
                string query = "DELETE FROM tb_kendaraan WHERE id = '" + id + "'";
                cmd = new SqlCommand(query, this.con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil dihapus!");

                loadData();
                showKendaraanGrid.Update();
                showKendaraanGrid.Refresh();
            }

        }

        
    }
}
