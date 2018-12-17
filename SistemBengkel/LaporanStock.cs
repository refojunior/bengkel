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
    public partial class LaporanStock : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True");
        SqlConnection conn2 = new SqlConnection(@"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        SqlCommand cmd2 = null;
        SqlDataReader reader2 = null;

        public LaporanStock()
        {
            InitializeComponent();
        }

        private string calculateStock(string id)
        {
            conn2.Open();
            string pembelian = "select sum(qty) as beli from tb_detail_pembelian where barang_id = " + id;
            cmd2 = new SqlCommand(pembelian, this.conn2);
            reader2 = cmd2.ExecuteReader();
            reader2.Read();
            //fungsi sompret ribet amat di c#
            int jumlah_beli;
            if (!DBNull.Value.Equals(reader2["beli"]))
            {
                jumlah_beli = int.Parse(reader2["beli"].ToString());
            }
            else
            {
                jumlah_beli = 0;
            }
            conn2.Close();

            conn2.Open();
            string penjualan = "select sum(qty) as jual from tb_detail_penjualan where barang_id = " + id;
            cmd2 = new SqlCommand(penjualan, this.conn2);
            reader2 = cmd2.ExecuteReader();
            reader2.Read();
            int jumlah_jual;
            if (!DBNull.Value.Equals(reader2["jual"]))
            {
                jumlah_jual = int.Parse(reader2["jual"].ToString());
            }
            else
            {
                jumlah_jual = 0;
            }
            
            conn2.Close();

            int stock = jumlah_beli - jumlah_jual;

            return stock.ToString();
        }

        private void LaporanStock_Load(object sender, EventArgs e)
        {
            conn.Open();
            lvBarang.View = View.Details;
            lvBarang.FullRowSelect = true;
            lvBarang.Columns.Add("Kode");
            lvBarang.Columns.Add("Nama Barang");
            lvBarang.Columns.Add("Type");
            lvBarang.Columns.Add("Merk");
            lvBarang.Columns.Add("Harga");
            lvBarang.Columns.Add("Stok");

            lvBarang.Columns[1].Width = 180;
            lvBarang.Columns[2].Width = 110;
            lvBarang.Columns[4].Width = 95;

            ListViewItem item;
            string query = "SELECT * FROM tb_barang";
            cmd = new SqlCommand(query, conn);
      
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = "BR-"+reader["id"].ToString();
                    item.SubItems.Add(reader["nama_barang"].ToString());
                    item.SubItems.Add(reader["tipe_barang"].ToString());
                    item.SubItems.Add(reader["merk"].ToString());
                    item.SubItems.Add(reader["harga"].ToString());
              
                    item.SubItems.Add(calculateStock(reader["id"].ToString()));
                   
                    lvBarang.Items.Add(item);

                }
            }
            reader.Close();
            conn.Close();
        }
    }
}
