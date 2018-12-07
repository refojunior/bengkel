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
    public partial class MasterKendaraan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2SP6M1;Initial Catalog=bengkel;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public MasterKendaraan()
        {
            InitializeComponent();
            fillComboBox();
        }

        public void fillComboBox()
        {
            con.Open();
            string query = "SELECT * FROM tb_customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, this.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                comboBoxCustomer.Items.Add(row["id"] + " - " + row["nama_customer"].ToString());
            }
            con.Close();
        }


        private void MasterKendaraan_Load(object sender, EventArgs e)
        {
            //table kendaraan
            string queryKendaraan = "SELECT * FROM tb_kendaraan";
            SqlDataAdapter SDAKendaraan = new SqlDataAdapter(queryKendaraan, this.con);
            DataTable dataKendaraan = new DataTable();
            SDAKendaraan.Fill(dataKendaraan);
            showKendaraanGrid.DataSource = dataKendaraan;

            con.Close();
        }

        private void btnSaveKendaraan_Click(object sender, EventArgs e)
        {
            string customer = comboBoxCustomer.Text;
            String.Join(" ", customer);
            string cust_id = customer[0].ToString();
            //MessageBox.Show(customer[0].ToString());
            
            if (customer != "- Pilih -" && namaKendaraanText.Text != "" && tahunText.Text != "" && platNomorText.Text != "")
            {
                con.Open();
                string insert = "INSERT INTO tb_kendaraan VALUES ('" + cust_id + "', '" + namaKendaraanText.Text + "', '" + merkText.Text + "', '" + tahunText.Text + "', '" + platNomorText.Text + "')";
                cmd = new SqlCommand(insert, this.con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil menambahkan kendaraan");
            }
            else
            {
                MessageBox.Show("Form ada yang kosong!!");
            }
        }
    }
}
