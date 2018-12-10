using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SistemBengkel
{
    public partial class MasterBarang : Form
    {
        CultureInfo idn = new CultureInfo("id-ID");

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2SP6M1;Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public void LoadData()
        {
            con.Open();
            string q = "SELECT * FROM tb_barang";
            SqlDataAdapter sda = new SqlDataAdapter(q, this.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            showBarangGrid.DataSource = dt;
            con.Close();
        }

        public void resetForm()
        {
            tipeComboBox.Text = "- Pilih -";
            namaBarangText.Clear();
            merkText.Clear();
            hargaText.Clear();
        }

        private void MasterBarang_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public MasterBarang()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (namaBarangText.Text == "" && merkText.Text == "" && hargaText.Text == "")
            {
                MessageBox.Show("Form ada yang kosong!");
            }
            else
            {
                con.Open();
                if (idBarangText.Text == "?")
                {
                    string sql = "INSERT INTO tb_barang VALUES ('" + tipeComboBox.Text + "', '" + namaBarangText.Text + "', '" + merkText.Text + "', '" + hargaText.Text + "')";
                    cmd = new SqlCommand(sql, this.con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    string sql = "SELECT * FROM tb_barang WHERE id = '" + idBarangText.Text + "'";
                    cmd = new SqlCommand(sql, this.con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        sql = "UPDATE tb_barang SET tipe_barang = '" + tipeComboBox.Text + "', nama_barang = '" + namaBarangText.Text + "', merk = '" + merkText.Text + "', harga = '" + hargaText.Text + "' WHERE id = '" + idBarangText.Text + "'";
                    }
                    else
                    {
                        MessageBox.Show("Update gagal, data barang tidak di temukan!!");
                    }
                    reader.Close();
                    cmd = new SqlCommand(sql, this.con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Data barang berhasil disimpan!");

                LoadData();
                showBarangGrid.Update();
                showBarangGrid.Refresh();

                resetForm();
            }

            
        }

        private void showBarangGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0){
                return;
            }

            int index = e.RowIndex;

            string id = showBarangGrid.Rows[index].Cells[0].Value.ToString();

            //query ke db dengan parameter id yg di select
            con.Open();
            string query = "SELECT * FROM tb_barang WHERE id = '" + id + "'";
            cmd = new SqlCommand(query, this.con);
            reader = cmd.ExecuteReader();
            //tampilkan data di form
            reader.Read();
            idBarangText.Text = reader["id"].ToString();
            namaBarangText.Text = reader["nama_barang"].ToString();
            tipeComboBox.Text = reader["tipe_barang"].ToString();
            merkText.Text = reader["merk"].ToString();
            hargaText.Text = reader["harga"].ToString();
            
            con.Close();
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idBarangText.Text;
            if (id == "?")
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!!");
            }
            else
            {
                if (MessageBox.Show("Yakin Hapus Data?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    string query = "DELETE FROM tb_barang WHERE id = '" + id + "'";
                    cmd = new SqlCommand(query, this.con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil dihapus!");

                    LoadData();
                    showBarangGrid.Update();
                    showBarangGrid.Refresh();
                    resetForm();
                }
            }
            
        }

    }
}
