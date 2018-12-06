namespace SistemBengkel
{
    partial class MasterCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.Label();
            this.telpText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.alamatText = new System.Windows.Forms.TextBox();
            this.namaCustText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showCustomersGrid = new System.Windows.Forms.DataGridView();
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
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panelKendaraan = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveKendaraan = new System.Windows.Forms.Button();
            this.tahunText = new System.Windows.Forms.TextBox();
            this.merkText = new System.Windows.Forms.TextBox();
            this.namaKendaraanText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.platNomorText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showKendaraanGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showCustomersGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelKendaraan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showKendaraanGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.telpText);
            this.groupBox1.Controls.Add(this.emailText);
            this.groupBox1.Controls.Add(this.alamatText);
            this.groupBox1.Controls.Add(this.namaCustText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Form";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(462, 46);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(462, 132);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 29);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(462, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idText.Location = new System.Drawing.Point(147, 37);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(16, 23);
            this.idText.TabIndex = 10;
            this.idText.Text = "?";
            // 
            // telpText
            // 
            this.telpText.Location = new System.Drawing.Point(151, 141);
            this.telpText.Name = "telpText";
            this.telpText.Size = new System.Drawing.Size(275, 21);
            this.telpText.TabIndex = 9;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(151, 115);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(275, 21);
            this.emailText.TabIndex = 8;
            // 
            // alamatText
            // 
            this.alamatText.Location = new System.Drawing.Point(151, 89);
            this.alamatText.Name = "alamatText";
            this.alamatText.Size = new System.Drawing.Size(275, 21);
            this.alamatText.TabIndex = 7;
            // 
            // namaCustText
            // 
            this.namaCustText.Location = new System.Drawing.Point(151, 63);
            this.namaCustText.Name = "namaCustText";
            this.namaCustText.Size = new System.Drawing.Size(275, 21);
            this.namaCustText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(24, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // showCustomersGrid
            // 
            this.showCustomersGrid.AllowUserToAddRows = false;
            this.showCustomersGrid.AllowUserToDeleteRows = false;
            this.showCustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showCustomersGrid.Location = new System.Drawing.Point(10, 212);
            this.showCustomersGrid.MultiSelect = false;
            this.showCustomersGrid.Name = "showCustomersGrid";
            this.showCustomersGrid.ReadOnly = true;
            this.showCustomersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showCustomersGrid.Size = new System.Drawing.Size(579, 150);
            this.showCustomersGrid.TabIndex = 1;
            this.showCustomersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showCustomers_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
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
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            // 
            // jasaToolStripMenuItem
            // 
            this.jasaToolStripMenuItem.Name = "jasaToolStripMenuItem";
            this.jasaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.showCustomersGrid);
            this.panelCustomer.Controls.Add(this.groupBox1);
            this.panelCustomer.Location = new System.Drawing.Point(12, 27);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(624, 380);
            this.panelCustomer.TabIndex = 3;
            // 
            // panelKendaraan
            // 
            this.panelKendaraan.Controls.Add(this.showKendaraanGrid);
            this.panelKendaraan.Controls.Add(this.groupBox2);
            this.panelKendaraan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKendaraan.Location = new System.Drawing.Point(0, 24);
            this.panelKendaraan.Name = "panelKendaraan";
            this.panelKendaraan.Size = new System.Drawing.Size(649, 396);
            this.panelKendaraan.TabIndex = 2;
            this.panelKendaraan.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.platNomorText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxCustomer);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnSaveKendaraan);
            this.groupBox2.Controls.Add(this.tahunText);
            this.groupBox2.Controls.Add(this.merkText);
            this.groupBox2.Controls.Add(this.namaKendaraanText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kendaraan Form";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(462, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(462, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSaveKendaraan
            // 
            this.btnSaveKendaraan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveKendaraan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveKendaraan.Location = new System.Drawing.Point(462, 89);
            this.btnSaveKendaraan.Name = "btnSaveKendaraan";
            this.btnSaveKendaraan.Size = new System.Drawing.Size(75, 29);
            this.btnSaveKendaraan.TabIndex = 11;
            this.btnSaveKendaraan.Text = "Save";
            this.btnSaveKendaraan.UseVisualStyleBackColor = false;
            // 
            // tahunText
            // 
            this.tahunText.Location = new System.Drawing.Point(151, 124);
            this.tahunText.Name = "tahunText";
            this.tahunText.Size = new System.Drawing.Size(275, 21);
            this.tahunText.TabIndex = 9;
            // 
            // merkText
            // 
            this.merkText.Location = new System.Drawing.Point(151, 95);
            this.merkText.Name = "merkText";
            this.merkText.Size = new System.Drawing.Size(275, 21);
            this.merkText.TabIndex = 8;
            // 
            // namaKendaraanText
            // 
            this.namaKendaraanText.Location = new System.Drawing.Point(151, 65);
            this.namaKendaraanText.Name = "namaKendaraanText";
            this.namaKendaraanText.Size = new System.Drawing.Size(275, 21);
            this.namaKendaraanText.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(24, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tahun";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(24, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Merk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(24, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nama Kendaraan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(24, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Customer";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(151, 34);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(275, 23);
            this.comboBoxCustomer.TabIndex = 15;
            // 
            // platNomorText
            // 
            this.platNomorText.Location = new System.Drawing.Point(151, 154);
            this.platNomorText.Name = "platNomorText";
            this.platNomorText.Size = new System.Drawing.Size(275, 21);
            this.platNomorText.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(24, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Plat Nomor";
            // 
            // showKendaraanGrid
            // 
            this.showKendaraanGrid.AllowUserToAddRows = false;
            this.showKendaraanGrid.AllowUserToDeleteRows = false;
            this.showKendaraanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showKendaraanGrid.Location = new System.Drawing.Point(22, 231);
            this.showKendaraanGrid.Name = "showKendaraanGrid";
            this.showKendaraanGrid.ReadOnly = true;
            this.showKendaraanGrid.Size = new System.Drawing.Size(579, 150);
            this.showKendaraanGrid.TabIndex = 2;
            // 
            // MasterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(649, 420);
            this.Controls.Add(this.panelKendaraan);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterCustomer";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterCustomer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showCustomersGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelKendaraan.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showKendaraanGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.TextBox telpText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox alamatText;
        private System.Windows.Forms.TextBox namaCustText;
        private System.Windows.Forms.DataGridView showCustomersGrid;
        private System.Windows.Forms.Button btnReset;
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
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Panel panelKendaraan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveKendaraan;
        private System.Windows.Forms.TextBox tahunText;
        private System.Windows.Forms.TextBox merkText;
        private System.Windows.Forms.TextBox namaKendaraanText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox platNomorText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView showKendaraanGrid;
    }
}

