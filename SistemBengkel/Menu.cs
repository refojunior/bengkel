﻿using System;
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
            myPanel.Controls.Clear();
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
            myPanel.Controls.Clear();
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
    }
}
