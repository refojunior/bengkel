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
    public partial class ListCustomer : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public ListCustomer()
        {
            InitializeComponent();
        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {
            string connString = @"Data Source=(local);Initial Catalog=bengkel;Integrated Security=True";
            conn = new SqlConnection(connString);
            conn.Open();

            lsvCustomer.View = View.Details;
            lsvCustomer.FullRowSelect = true;
            lsvCustomer.Columns.Add("ID");
            lsvCustomer.Columns.Add("Nama Customer");
            lsvCustomer.Columns.Add("Alamat");
            lsvCustomer.Columns.Add("Email");
            lsvCustomer.Columns.Add("Telp");

            lsvCustomer.Columns[1].Width = 150;
            lsvCustomer.Columns[2].Width = 120;
            lsvCustomer.Columns[3].Width = 130;
            lsvCustomer.Columns[4].Width = 90;

            ListViewItem item;
            string ssql = "SELECT * FROM tb_customer";
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();
            if(reader.HasRows){
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id"].ToString();
                    item.SubItems.Add(reader["nama_customer"].ToString());
                    item.SubItems.Add(reader["alamat"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    item.SubItems.Add(reader["telp"].ToString());
                    lsvCustomer.Items.Add(item);

                }
            }
            reader.Close();
            conn.Close();
        }

        private void lsvCustomer_DoubleClick(object sender, EventArgs e)
        {
            Program.idCust = lsvCustomer.SelectedItems[0].SubItems[0].Text;
            Program.namaCustomer = lsvCustomer.SelectedItems[0].SubItems[1].Text;
            Program.alamat = lsvCustomer.SelectedItems[0].SubItems[2].Text;
            Program.email = lsvCustomer.SelectedItems[0].SubItems[3].Text;
            Program.telp = lsvCustomer.SelectedItems[0].SubItems[4].Text;
            
            this.Close();
        }
    }
}
