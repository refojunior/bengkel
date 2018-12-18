using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace SistemBengkel
{
    public partial class LaporanService : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public LaporanService()
        {
            InitializeComponent();
        }

        public void LoadData(string dari = null, string sampai = null)
        {
            con.Open();
            string q;
            if (dari == null && sampai == null)
            {
                q = "select d.tanggal, b.nama_kendaraan, c.nama_customer, e.nama_jasa, e.harga from tb_detail_service a inner join tb_service d on a.service_id = d.id inner join tb_kendaraan b on d.kendaraan_id = b.id inner join tb_customer c on c.id = b.customer_id inner join tb_jasa e on e.id = a.jasa_id  ";
            }
            else
            {
                q = "select d.tanggal, b.nama_kendaraan, c.nama_customer, e.nama_jasa, e.harga from tb_detail_service a inner join tb_service d on a.service_id = d.id inner join tb_kendaraan b on d.kendaraan_id = b.id inner join tb_customer c on c.id = b.customer_id inner join tb_jasa e on e.id = a.jasa_id  " +
                    "WHERE d.tanggal >= '" + dari + "' AND d.tanggal <= '" + sampai + "' ";
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

        private void LaporanService_Load(object sender, EventArgs e)
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
                LoadData(dari, sampai);
            }



            
        }
    }
}
