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
    public partial class ListKendaraan : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public ListKendaraan()
        {
            InitializeComponent();
        }

        private void ListKendaraan_Load(object sender, EventArgs e)
        {
            string connString = @"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True";
            conn = new SqlConnection(connString);
            conn.Open();

            lsvKendaraan.View = View.Details;
            lsvKendaraan.FullRowSelect = true;
            lsvKendaraan.Columns.Add("Kode");
            lsvKendaraan.Columns.Add("Kendaraan");
            lsvKendaraan.Columns.Add("Customer");
            lsvKendaraan.Columns.Add("Merk");
            lsvKendaraan.Columns.Add("Tahun");
            lsvKendaraan.Columns.Add("Plat Nomor");

            lsvKendaraan.Columns[0].Width = 50;
            lsvKendaraan.Columns[1].Width = 150;
            lsvKendaraan.Columns[2].Width = 150;
            lsvKendaraan.Columns[5].Width = 120;
            ListViewItem item;
            string ssql = "SELECT a.id, a.customer_id, b.nama_customer, a.nama_kendaraan, a.merk, a.tahun, a.plat_nomor from tb_kendaraan a inner join tb_customer b on a.customer_id = b.id ";
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id"].ToString();
                    item.SubItems.Add(reader["nama_kendaraan"].ToString());
                    item.SubItems.Add(reader["nama_customer"].ToString());
                    item.SubItems.Add(reader["merk"].ToString());
                    item.SubItems.Add(reader["tahun"].ToString());
                    item.SubItems.Add(reader["plat_nomor"].ToString());
                    lsvKendaraan.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void lsvKendaraan_DoubleClick(object sender, EventArgs e)
        {
            Program.idKendaraan = lsvKendaraan.SelectedItems[0].SubItems[0].Text;
            Program.nmKendaraan = lsvKendaraan.SelectedItems[0].SubItems[1].Text;
            Program.nmCustomer = lsvKendaraan.SelectedItems[0].SubItems[2].Text;
            Program.merk = lsvKendaraan.SelectedItems[0].SubItems[3].Text;
            Program.tahun = lsvKendaraan.SelectedItems[0].SubItems[4].Text;
            Program.plat_nomor = lsvKendaraan.SelectedItems[0].SubItems[5].Text;
            this.Close();
        }
    }
}
