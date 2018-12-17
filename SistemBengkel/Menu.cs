using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemBengkel
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
           
            WindowState = FormWindowState.Maximized;
        }

       

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //myPanel.Controls.Clear();
            MasterCustomer show = new MasterCustomer();
            show.TopLevel = false;
            myPanel.Controls.Add(show);
            show.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
      
            Application.Exit();
        
        }

        private void kendaraanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //myPanel.Controls.Clear();
            MasterKendaraan kendaraan = new MasterKendaraan();
            kendaraan.TopLevel = false;
            myPanel.Controls.Add(kendaraan);
            kendaraan.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //myPanel.Controls.Clear();
            MasterBarang barang = new MasterBarang();
            barang.TopLevel = false;
            myPanel.Controls.Add(barang);
            barang.Show();
        }

        private void jasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //myPanel.Controls.Clear();
            MasterJasa jasa = new MasterJasa();
            jasa.TopLevel = false;
            myPanel.Controls.Add(jasa);
            jasa.Show();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaksiService service = new TransaksiService();
            service.TopLevel = false;
            myPanel.Controls.Add(service);
            service.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaksiPenjualan pembelian = new TransaksiPenjualan();
            pembelian.TopLevel = false;
            myPanel.Controls.Add(pembelian);
            pembelian.Show();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaksiPembelian pembelian = new TransaksiPembelian();
            pembelian.TopLevel = false;
            myPanel.Controls.Add(pembelian);
            pembelian.Show();
        }

        private void laporanStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanStock variable = new LaporanStock();
            variable.TopLevel = false;
            myPanel.Controls.Add(variable);
            variable.Show();
        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanPenjualan variable = new LaporanPenjualan();
            variable.TopLevel = false;
            myPanel.Controls.Add(variable);
            variable.Show();
        }
    }
}
