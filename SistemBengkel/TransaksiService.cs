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
    public partial class TransaksiService : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public TransaksiService()
        {
            InitializeComponent();
            fillComboBox();
        }

        public void fillComboBox()
        {
            con.Open();
            string q = "SELECT * from tb_jasa ";
            SqlDataAdapter sdaService = new SqlDataAdapter(q, this.con);
            DataTable dt = new DataTable();
            sdaService.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                JasaComboBox.Items.Add(row["id"].ToString() + " - " + row["nama_jasa"].ToString());
            }
            con.Close();
        }

        private string HitungTotalService()
        {
            int n = lvService.Items.Count - 1;
            double total = 0;
            for (int i = 0; i <= n; i++ )
            {
                total = total + double.Parse(lvService.Items[i].SubItems[2].Text);
            }

            return total.ToString();
        }

        private void TransaksiService_Load(object sender, EventArgs e)
        {
            lvService.View = View.Details;
            lvService.FullRowSelect = true;
            lvService.Columns.Add("Kode");
            lvService.Columns.Add("Nama Jasa");
            lvService.Columns.Add("Harga");
           
            lvService.Columns[0].Width = 50;
            lvService.Columns[1].Width = 150;
            lvService.Columns[2].Width = 150;
           
        }

        

        private void panelService_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kendaraanText_Click(object sender, EventArgs e)
        {
            ListKendaraan kendaraan = new ListKendaraan();
            kendaraan.ShowDialog();
            kendaraanText.ForeColor = System.Drawing.Color.Black;
            kdKendaraanLabel.Text = Program.idKendaraan;
            kendaraanText.Text = Program.merk + " - " + Program.nmKendaraan;
            customerLabel.Text = Program.nmCustomer;
            platNomorLabel.Text = Program.plat_nomor;
            tahunLabel.Text = Program.tahun;
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            
            if (kendaraanText.Text != "Click Here...")
            {
                if (JasaComboBox.Text.Count() != 0)
                {
                    string jasa = JasaComboBox.Text;
                    string[] arr = jasa.Split('-');

                    string jasaID = arr[0].ToString();
                    string namaJasa = arr[1].ToString();

                    con.Open();
                    string q = "SELECT * FROM tb_jasa WHERE id = '" + jasaID + "'";
                    cmd = new SqlCommand(q, this.con);
                    reader = cmd.ExecuteReader();
                    reader.Read();


                    ListViewItem item;
                    item = new ListViewItem();
                    item.Text = jasaID;
                    item.SubItems.Add(reader["nama_jasa"].ToString());
                    item.SubItems.Add(reader["harga"].ToString());
                    lvService.Items.Add(item);

                    con.Close();

                    totalText.Text = HitungTotalService();
                }
                else
                {
                    MessageBox.Show("Pilih Service terlebih dahulu!");
                }
                

            }
            else
            {
                MessageBox.Show("Pilih kendaraan customer terlebih dahulu!");
            }

            JasaComboBox.SelectedIndex = -1;

        }

        private void bayarText_TextChanged(object sender, EventArgs e)
        {
            kembaliText.Text = Convert.ToString(Convert.ToDouble(bayarText.Text) - Convert.ToDouble(totalText.Text));
        }

        

        



    }
}
