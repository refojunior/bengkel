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
    public partial class LaporanPenjualan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public void LoadData(string dari=null, string sampai=null, string kategori=null)
        {
            con.Open();
            string q;
            if (dari == null && kategori == null)
            {
                q = "select " +
                       "b.id as nota, " +
                       "c.nama_customer, " +
                       "b.tanggal, " +
                       "d.nama_barang, " +
                       "d.tipe_barang, " +
                       "d.merk, " +
                       "d.harga, " +
                       "a.qty, " +
                       "b.payment_type, " +
                       "a.qty *  d.harga as total " +
                       "from tb_detail_penjualan a " +
                       "inner join tb_penjualan b on a.penjualan_id = b.id " +
                       "inner join tb_customer c on c.id = b.customer_id " +
                       "inner join tb_barang d on d.id = a.barang_id";
            }
            else
            {
                if (kategori != "Semua Kategori")
                {
                    q = "select " +
                          "b.id as nota, " +
                          "c.nama_customer, " +
                          "b.tanggal, " +
                          "d.nama_barang, " +
                          "d.tipe_barang, " +
                          "d.merk, " +
                          "d.harga, " +
                          "a.qty, " +
                          "b.payment_type, " +
                          "a.qty *  d.harga as total " +
                          "from tb_detail_penjualan a " +
                          "inner join tb_penjualan b on a.penjualan_id = b.id " +
                          "inner join tb_customer c on c.id = b.customer_id " +
                          "inner join tb_barang d on d.id = a.barang_id " +
                          "WHERE b.tanggal >= '" + dari + "' AND b.tanggal <= '" + sampai + "' " +
                          "AND d.tipe_barang = '" + kategori + "'";
                }
                else
                {
                    q = "select " +
                      "b.id as nota, " +
                      "c.nama_customer, " +
                      "b.tanggal, " +
                      "d.nama_barang, " +
                      "d.tipe_barang, " +
                      "d.merk, " +
                      "d.harga, " +
                      "a.qty, " +
                      "b.payment_type, " +
                      "a.qty *  d.harga as total " +
                      "from tb_detail_penjualan a " +
                      "inner join tb_penjualan b on a.penjualan_id = b.id " +
                      "inner join tb_customer c on c.id = b.customer_id " +
                      "inner join tb_barang d on d.id = a.barang_id " +
                      "WHERE b.tanggal >= '" + dari + "' AND b.tanggal <= '" + sampai + "' ";
                }
               
            }
           
            SqlDataAdapter sda = new SqlDataAdapter(q, this.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
      
        public LaporanPenjualan()
        {
            InitializeComponent();
        }

        private void LaporanPenjualan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //format tanggal kampret ribet amat convertnya
            string s = dateTimePicker1.Value.ToString();
            var date = DateTime.ParseExact(s, "dd/M/yyyy HH.mm.ss", CultureInfo.InvariantCulture);
            string tgl = date.ToString("yyyy-M-dd HH:mm:ss");
            string tanggal = tgl.Replace(".", ":");
            string[] arr = tanggal.Split(' ');
            string dari = arr[0];

            string ss = dateTimePicker2.Value.AddDays(1).ToString();
            var dates = DateTime.ParseExact(ss, "dd/M/yyyy HH.mm.ss", CultureInfo.InvariantCulture);
            string tgls = dates.ToString("yyyy-M-dd HH:mm:ss");
            string tanggals = tgls.Replace(".", ":");
            string[] arrs = tanggals.Split(' ');
            string sampai = arrs[0];

            if (date > dates)
            {
                MessageBox.Show("Format tanggal tidak valid!!!");
            }
            else
            {
                LoadData(dari, sampai, comboBox1.Text);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
