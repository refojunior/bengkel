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
    public partial class TransaksiPembelian : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public TransaksiPembelian()
        {
            InitializeComponent();
        }

        private string hitungTotalPenjualan()
        {
            int n = lvPembelian.Items.Count - 1;
            double total = 0;
            for (int i = 0; i <= n; i++)
            {
                total = total + double.Parse(lvPembelian.Items[i].SubItems[5].Text);
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
            lvPembelian.Items.Clear();
            grandTotalText.Text = "0";
          
        }

        private void TransaksiPembelian_Load(object sender, EventArgs e)
        {
            lvPembelian.View = View.Details;
            lvPembelian.FullRowSelect = true;
            lvPembelian.Columns.Add("Kode");
            lvPembelian.Columns.Add("Nama Barang");
            lvPembelian.Columns.Add("Type");
            lvPembelian.Columns.Add("Harga");
            lvPembelian.Columns.Add("Qty");
            lvPembelian.Columns.Add("Total");

            lvPembelian.Columns[1].Width = 150;
            lvPembelian.Columns[2].Width = 110;
            lvPembelian.Columns[3].Width = 90;
            lvPembelian.Columns[5].Width = 120;
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
                lvPembelian.Items.Add(item);

                grandTotalText.Text = hitungTotalPenjualan();
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
            string s = datePenjualan.Value.ToString();
            var date = DateTime.ParseExact(s, "dd/M/yyyy HH.mm.ss", CultureInfo.InvariantCulture);
            string tgl = date.ToString("yyyy-M-dd HH:mm:ss");
            string tanggal = tgl.Replace(".", ":");

            if (lvPembelian.Items.Count != 0)
            {
                con.Open();
                string sql = "INSERT INTO tb_pembelian VALUES ('" + tanggal.ToString() + "', '" + grandTotalText.Text + "')";
                cmd = new SqlCommand(sql, this.con);
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                string max = "SELECT MAX(id) AS last_id from tb_pembelian";
                cmd = new SqlCommand(max, this.con);
                reader = cmd.ExecuteReader();
                reader.Read();
                string latest_id = reader["last_id"].ToString();
                con.Close();

                //looping list view
                con.Open();
                int n = lvPembelian.Items.Count - 1;
                for (int i = 0; i <= n; i++)
                {
                    string insertDetail = "INSERT INTO tb_detail_pembelian VALUES ('" + latest_id + "', '" + lvPembelian.Items[i].SubItems[0].Text + "', '" + lvPembelian.Items[i].SubItems[4].Text + "' , '" + lvPembelian.Items[i].SubItems[5].Text + "')";
                    cmd = new SqlCommand(insertDetail, this.con);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Transaksi Pembelian berhasil");
                con.Close();

                ResetForm();
            }
            else
            {
                MessageBox.Show("Mohon memasukan penjualan minimal 1!!!");
            }
        }
    }
}
