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
    public partial class MasterJasa : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2SP6M1;Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;


        public void LoadData()
        {
            con.Open();
            string q = "SELECT * FROM tb_jasa";
            SqlDataAdapter sda = new SqlDataAdapter(q, this.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            showJasaGrid.DataSource = dt;
            con.Close();
        }

        public void resetForm()
        {
            namaJasaText.Clear();
            hargaJasaText.Clear();
        }

        public MasterJasa()
        {
            InitializeComponent();
        }

        private void MasterJasa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (namaJasaText.Text == "" && hargaJasaText.Text == "")
            {
                MessageBox.Show("Form ada yang kosong!");
            }
            else
            {
                con.Open();
                if (idJasaText.Text == "?")
                {
                    string sql = "INSERT INTO tb_jasa VALUES ('" + namaJasaText.Text + "', '" + hargaJasaText.Text + "')";
                    cmd = new SqlCommand(sql, this.con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    string sql = "SELECT * FROM tb_jasa WHERE id = '" + idJasaText.Text + "'";
                    cmd = new SqlCommand(sql, this.con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        sql = "UPDATE tb_jasa SET nama_jasa = '" + namaJasaText.Text + "', harga = '" + hargaJasaText.Text + "' WHERE id = '" + idJasaText.Text + "'";
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

                MessageBox.Show("Data jasa berhasil disimpan!");

                LoadData();
                showJasaGrid.Update();
                showJasaGrid.Refresh();

                resetForm();
            }

        }

        private void showJasaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;

            string id = showJasaGrid.Rows[index].Cells[0].Value.ToString();

            //query ke db dengan parameter id yg di select
            con.Open();
            string query = "SELECT * FROM tb_jasa WHERE id = '" + id + "'";
            cmd = new SqlCommand(query, this.con);
            reader = cmd.ExecuteReader();
            //tampilkan data di form
            reader.Read();
            idJasaText.Text = reader["id"].ToString();
            namaJasaText.Text = reader["nama_jasa"].ToString();
            hargaJasaText.Text = reader["harga"].ToString();
           

            con.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idJasaText.Text;
            if (id == "?")
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!!");
            }
            else
            {
                if (MessageBox.Show("Yakin Hapus Data?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    string query = "DELETE FROM tb_jasa WHERE id = '" + id + "'";
                    cmd = new SqlCommand(query, this.con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil dihapus!");

                    LoadData();
                    showJasaGrid.Update();
                    showJasaGrid.Refresh();
                    resetForm();
                }
            }
        }
    }
}
