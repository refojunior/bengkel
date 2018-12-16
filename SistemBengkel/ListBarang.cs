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
    public partial class ListBarang : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public ListBarang()
        {
            InitializeComponent();
        }

        private void ListBarang_Load(object sender, EventArgs e)
        {
            string connString = @"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True";
            conn = new SqlConnection(connString);
            conn.Open();

            lsvBarang.View = View.Details;
            lsvBarang.FullRowSelect = true;
            lsvBarang.Columns.Add("ID");
            lsvBarang.Columns.Add("Nama Barang");
            lsvBarang.Columns.Add("Type");
            lsvBarang.Columns.Add("Merk");
            lsvBarang.Columns.Add("Harga");

            lsvBarang.Columns[1].Width = 150;
            lsvBarang.Columns[2].Width = 120;
            lsvBarang.Columns[3].Width = 80;
            lsvBarang.Columns[4].Width = 90;

            ListViewItem item;
            string ssql = "SELECT * FROM tb_barang";
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id"].ToString();
                    item.SubItems.Add(reader["nama_barang"].ToString());
                    item.SubItems.Add(reader["tipe_barang"].ToString());
                    item.SubItems.Add(reader["merk"].ToString());
                    item.SubItems.Add(reader["harga"].ToString());
                    lsvBarang.Items.Add(item);

                }
            }
            reader.Close();
            conn.Close();
        }

        private void lsvCustomer_DoubleClick(object sender, EventArgs e)
        {
            Program.idBarang = lsvBarang.SelectedItems[0].SubItems[0].Text;
            Program.namaBarang = lsvBarang.SelectedItems[0].SubItems[1].Text;
            Program.typeBarang = lsvBarang.SelectedItems[0].SubItems[2].Text;
            Program.merkBarang = lsvBarang.SelectedItems[0].SubItems[3].Text;
            Program.hargaBarang = lsvBarang.SelectedItems[0].SubItems[4].Text;

            this.Close();
        }
    }
}
