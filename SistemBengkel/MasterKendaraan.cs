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
    public partial class MasterKendaraan : Form
    {
        public MasterKendaraan()
        {
            InitializeComponent();
        }

        private void MasterKendaraan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void MasterCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MasterCustomer mc = new MasterCustomer();
            mc.ShowDialog();
        }

        private void kendaraanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterKendaraan mk = new MasterKendaraan();
            mk.ShowDialog();
        }
    }
}
