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
    public partial class TransaksiPembelian : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public TransaksiPembelian()
        {
            InitializeComponent();
        }

        private void customerText_Click(object sender, EventArgs e)
        {
            ListCustomer customer = new ListCustomer();
            customer.ShowDialog();
            customerText.Text = Program.namaCustomer;
            kdCustLabel.Text = Program.idCust;
            telpCustLabel.Text = "+62"+Program.telp;
            paymentType.Focus();
        }

        private string hitungTotalPenjualan()
        {
            int n = lvPenjualan.Items.Count - 1;
            double total = 0;
            for (int i = 0; i <= n; i++)
            {
                total = total + double.Parse(lvPenjualan.Items[i].SubItems[5].Text);
            }

            return total.ToString();
        }

        private void ResetForm()
        {
            //kosongkan form
            kdBarangText.Text = "Click Here...";
            nmBarangText.Clear();
            typeBarangText.Clear();
            hargaText.Clear();
            qtyText.Text = "0";
            customerText.Text = "Click Here...";
            telpCustLabel.Text = "...";
            kdCustLabel.Text = "...";
            paymentType.SelectedIndex = -1;
            lvPenjualan.Items.Clear();
            totalText.Text = "0";
            bayarText.Text = "0";
            kembaliText.Text = "0";
        }

        private void TransaksiPembelian_Load(object sender, EventArgs e)
        {
            lvPenjualan.View = View.Details;
            lvPenjualan.FullRowSelect = true;
            lvPenjualan.Columns.Add("Kode");
            lvPenjualan.Columns.Add("Nama Barang");
            lvPenjualan.Columns.Add("Type");
            lvPenjualan.Columns.Add("Harga");
            lvPenjualan.Columns.Add("Qty");
            lvPenjualan.Columns.Add("Total");

            lvPenjualan.Columns[1].Width = 150;
            lvPenjualan.Columns[2].Width = 110;
            lvPenjualan.Columns[3].Width = 90;
            lvPenjualan.Columns[5].Width = 120;

        }

        private void kdBarangText_Click(object sender, EventArgs e)
        {
            ListBarang barang = new ListBarang();
            barang.ShowDialog();
            kdBarangText.Text = Program.idBarang;
            nmBarangText.Text = Program.namaBarang;
            typeBarangText.Text = Program.typeBarang;
            hargaText.Text = Program.hargaBarang;
            qtyText.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (kdBarangText.Text != "Click Here..." && qtyText.Text != "0")
            {
                //do action
                ListViewItem item;
                item = new ListViewItem();
                item.Text = kdBarangText.Text;
                item.SubItems.Add(nmBarangText.Text);
                item.SubItems.Add(typeBarangText.Text);
                item.SubItems.Add(hargaText.Text);
                item.SubItems.Add(qtyText.Text);
                int total = int.Parse(hargaText.Text) * int.Parse(qtyText.Text);
                item.SubItems.Add(total.ToString());
                lvPenjualan.Items.Add(item);

                totalText.Text = hitungTotalPenjualan();
            }
            else
            {
                MessageBox.Show("Pilih Barang dan isi Qty terlebih dahulu!!!");
            }

            //kosongkan form
            kdBarangText.Text = "Click Here...";
            nmBarangText.Clear();
            typeBarangText.Clear();
            hargaText.Clear();
            qtyText.Text = "0";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (paymentType.SelectedIndex != -1 && customerText.Text != "Click Here...")
            {
                string s = datePembelian.Value.ToString();
                var date = DateTime.ParseExact(s, "dd/M/yyyy HH.mm.ss", CultureInfo.InvariantCulture);
                string tgl = date.ToString("yyyy-M-dd HH:mm:ss");
                string tanggal = tgl.Replace(".", ":");

                if (bayarText.Text.Length != 0 && lvPenjualan.Items.Count != 0)
                {
                    int total = int.Parse(totalText.Text);
                    int bayar = int.Parse(bayarText.Text);
                    if (total > bayar)
                    {
                        MessageBox.Show("Pembayaran Kurang!!");
                    }
                    else
                    {
                        //masuk tabel penjualan utama
                        con.Open();
                        string sql = "INSERT INTO tb_penjualan VALUES ('" + tanggal.ToString() + "', '" + kdCustLabel.Text + "', '" + paymentType.Text + "', '" + totalText.Text + "')";
                        cmd = new SqlCommand(sql, this.con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //stelah dapet kode jual, masukan detail disini
                        con.Open();
                        string max = "SELECT MAX(id) AS last_id from tb_penjualan";
                        cmd = new SqlCommand(max, this.con);
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        string latest_id = reader["last_id"].ToString();
                        con.Close();

                        //looping list view
                        con.Open();
                        int n = lvPenjualan.Items.Count - 1;
                        for (int i = 0; i <= n; i++)
                        {
                            string insertDetail = "INSERT INTO tb_detail_penjualan VALUES ('" + latest_id + "', '" + lvPenjualan.Items[i].SubItems[0].Text + "', '" + lvPenjualan.Items[i].SubItems[4].Text + "' , '" + lvPenjualan.Items[i].SubItems[5].Text + "')";
                            cmd = new SqlCommand(insertDetail, this.con);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Transaksi Pembelian berhasil");
                        con.Close();
                        ResetForm();
                    }
                }
                else
                {
                    MessageBox.Show("Isi Semua Form terlebih dahulu!!!!");
                }
                
            }
            else
            {
                MessageBox.Show("Customer & Payment type masih kosong!!!");
            }
        }

      

        private void bayarText_TextChanged(object sender, EventArgs e)
        {
            kembaliText.Text = Convert.ToString(Convert.ToDouble(bayarText.Text) - Convert.ToDouble(totalText.Text));
        }

      

        
    }
}
