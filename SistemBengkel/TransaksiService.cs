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

        private void ResetForm()
        {
            kendaraanText.Text = "Click Here...";
            kendaraanText.ForeColor = System.Drawing.Color.Silver;
            kdKendaraanLabel.Text = "...";
            platNomorLabel.Text = "...";
            tahunLabel.Text = "...";
            customerLabel.Text = "...";
            lvService.Items.Clear();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (kdKendaraanLabel.Text != "..." && lvService.Items.Count != 0)
            {
                //format tanggal kampret ribet amat convertnya
                string s = dateService.Value.ToString();
                var date = DateTime.ParseExact(s, "dd/M/yyyy HH.mm.ss", CultureInfo.InvariantCulture);
                string tgl = date.ToString("yyyy-M-dd HH:mm:ss");
                string tanggal = tgl.Replace(".", ":");


                if (bayarText.Text.Length != 0)
                {
                    int total = int.Parse(totalText.Text);
                    int bayar = int.Parse(bayarText.Text);
                    if (total > bayar)
                    {
                        MessageBox.Show("Pembayaran Kurang!!");
                    }
                    else
                    {
                        con.Open();
                        //masuk tabel service utama
                        string sql = "INSERT INTO tb_service VALUES ('" + tanggal.ToString() + "', '" + kdKendaraanLabel.Text + "', '', '" + totalText.Text + "')";

                        cmd = new SqlCommand(sql, this.con);
                        cmd.ExecuteNonQuery();
                        
                        //masukan detail service disini
                        string max = "SELECT MAX(id) AS last_id from tb_service";
                        cmd = new SqlCommand(max, this.con);
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        string latest_id = reader["last_id"].ToString();
                        con.Close();

                        con.Open();
                        int n = lvService.Items.Count - 1;
                        for (int i = 0; i <= n; i++)
                        {
                            string insertDetail = "INSERT INTO tb_detail_service VALUES ('" + latest_id + "', '" + lvService.Items[i].SubItems[0].Text + "', '')";
                            cmd = new SqlCommand(insertDetail, this.con);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Transaksi Service berhasil");
                        con.Close();
                        ResetForm();
                    }
                }
                else
                {
                    MessageBox.Show("Masukan Nominal Pembayaran!");
                }
            }
            else
            {
                MessageBox.Show("ISI SELURUH FORM TERLEBIH DAHULU!!!!");
            }
           
            
        }

        

        



    }
}
