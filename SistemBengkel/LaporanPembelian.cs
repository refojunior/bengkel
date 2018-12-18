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
    public partial class LaporanPembelian : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public LaporanPembelian()
        {
            InitializeComponent();
        }

        public void LoadData(string dari = null, string sampai = null, string kategori = null)
        {
            con.Open();
            string q;
            if (dari == null && kategori == null)
            {
                q = "select " +
                       "b.id as nota, " +
                       "b.tanggal, " +
                       "d.nama_barang, " +
                       "d.tipe_barang, " +
                       "d.merk, " +
                       "d.harga, " +
                       "a.qty ," +
                       "a.qty *  d.harga as total " +
                       "from tb_detail_pembelian a " +
                       "inner join tb_pembelian b on a.pembelian_id = b.id " +
                       "inner join tb_barang d on d.id = a.barang_id";
            }
            else
            {
                if (kategori != "Semua Kategori")
                {
                    q = "select " +
                          "b.id as nota, " +
                          "b.tanggal, " +
                          "d.nama_barang, " +
                          "d.tipe_barang, " +
                          "d.merk, " +
                          "d.harga, " +
                          "a.qty ," +
                          "a.qty *  d.harga as total " +
                          "from tb_detail_pembelian a " +
                          "inner join tb_pembelian b on a.pembelian_id = b.id " +
                          "inner join tb_barang d on d.id = a.barang_id " +
                          "WHERE b.tanggal >= '" + dari + "' AND b.tanggal <= '" + sampai + "' " +
                          "AND d.tipe_barang = '" + kategori + "'";
                }
                else
                {
                    q = "select " +
                      "b.id as nota, " +
                      "b.tanggal, " +
                      "d.nama_barang, " +
                      "d.tipe_barang, " +
                      "d.merk, " +
                      "d.harga, " +
                      "a.qty ," +
                      "a.qty *  d.harga as total " +
                      "from tb_detail_pembelian a " +
                      "inner join tb_pembelian b on a.pembelian_id = b.id " +
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LaporanPembelian_Load(object sender, EventArgs e)
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



            LoadData(dari, sampai, comboBox1.Text);
        }
    }
}
