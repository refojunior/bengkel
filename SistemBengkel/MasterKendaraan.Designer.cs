namespace SistemBengkel
{
    partial class MasterKendaraan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kendaraanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.kendaraanToolStripMenuItem,
            this.barangToolStripMenuItem,
            this.jasaToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click_1);
            // 
            // kendaraanToolStripMenuItem
            // 
            this.kendaraanToolStripMenuItem.Name = "kendaraanToolStripMenuItem";
            this.kendaraanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kendaraanToolStripMenuItem.Text = "Kendaraan";
            this.kendaraanToolStripMenuItem.Click += new System.EventHandler(this.kendaraanToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            // 
            // jasaToolStripMenuItem
            // 
            this.jasaToolStripMenuItem.Name = "jasaToolStripMenuItem";
            this.jasaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.jasaToolStripMenuItem.Text = "Jasa";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceToolStripMenuItem,
            this.penjualanToolStripMenuItem,
            this.pembelianToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            // 
            // pembelianToolStripMenuItem
            // 
            this.pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
            this.pembelianToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.pembelianToolStripMenuItem.Text = "Pembelian";
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanPenjualanToolStripMenuItem,
            this.laporanPembelianToolStripMenuItem,
            this.laporanServiceToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            this.laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            this.laporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.laporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            // 
            // laporanPembelianToolStripMenuItem
            // 
            this.laporanPembelianToolStripMenuItem.Name = "laporanPembelianToolStripMenuItem";
            this.laporanPembelianToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.laporanPembelianToolStripMenuItem.Text = "Laporan Pembelian";
            // 
            // laporanServiceToolStripMenuItem
            // 
            this.laporanServiceToolStripMenuItem.Name = "laporanServiceToolStripMenuItem";
            this.laporanServiceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.laporanServiceToolStripMenuItem.Text = "Laporan Service";
            // 
            // MasterKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MasterKendaraan";
            this.Text = "Kendaraan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterKendaraan_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kendaraanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanServiceToolStripMenuItem;
    }
}