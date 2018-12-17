namespace SistemBengkel
{
    partial class TransaksiPembelian
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePenjualan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.qtyText = new System.Windows.Forms.TextBox();
            this.hargaText = new System.Windows.Forms.TextBox();
            this.typeBarangText = new System.Windows.Forms.TextBox();
            this.nmBarangText = new System.Windows.Forms.TextBox();
            this.kdBarangText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvPembelian = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.grandTotalText = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(113, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "AUTO";
            // 
            // datePenjualan
            // 
            this.datePenjualan.Location = new System.Drawing.Point(573, 21);
            this.datePenjualan.Name = "datePenjualan";
            this.datePenjualan.Size = new System.Drawing.Size(200, 20);
            this.datePenjualan.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(716, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 68;
            this.label7.Text = "Tambah";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(720, 105);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(53, 22);
            this.btnTambah.TabIndex = 67;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // qtyText
            // 
            this.qtyText.Location = new System.Drawing.Point(648, 106);
            this.qtyText.Name = "qtyText";
            this.qtyText.Size = new System.Drawing.Size(66, 20);
            this.qtyText.TabIndex = 66;
            this.qtyText.Text = "0";
            // 
            // hargaText
            // 
            this.hargaText.Location = new System.Drawing.Point(473, 105);
            this.hargaText.Name = "hargaText";
            this.hargaText.Size = new System.Drawing.Size(163, 20);
            this.hargaText.TabIndex = 65;
            // 
            // typeBarangText
            // 
            this.typeBarangText.Location = new System.Drawing.Point(344, 106);
            this.typeBarangText.Name = "typeBarangText";
            this.typeBarangText.Size = new System.Drawing.Size(118, 20);
            this.typeBarangText.TabIndex = 64;
            // 
            // nmBarangText
            // 
            this.nmBarangText.Location = new System.Drawing.Point(117, 105);
            this.nmBarangText.Name = "nmBarangText";
            this.nmBarangText.Size = new System.Drawing.Size(214, 20);
            this.nmBarangText.TabIndex = 63;
            // 
            // kdBarangText
            // 
            this.kdBarangText.Location = new System.Drawing.Point(16, 106);
            this.kdBarangText.Name = "kdBarangText";
            this.kdBarangText.Size = new System.Drawing.Size(82, 20);
            this.kdBarangText.TabIndex = 62;
            this.kdBarangText.Text = "Click Here";
            this.kdBarangText.Click += new System.EventHandler(this.kdBarangText_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(644, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 23);
            this.label12.TabIndex = 61;
            this.label12.Text = "Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(340, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 23);
            this.label11.TabIndex = 60;
            this.label11.Text = "Type Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(469, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 23);
            this.label10.TabIndex = 59;
            this.label10.Text = "Harga";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(113, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Nama Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 57;
            this.label8.Text = "Kode Barang";
            // 
            // lvPembelian
            // 
            this.lvPembelian.Location = new System.Drawing.Point(16, 142);
            this.lvPembelian.Name = "lvPembelian";
            this.lvPembelian.Size = new System.Drawing.Size(757, 159);
            this.lvPembelian.TabIndex = 69;
            this.lvPembelian.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(582, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Grand Total";
            // 
            // grandTotalText
            // 
            this.grandTotalText.Location = new System.Drawing.Point(667, 309);
            this.grandTotalText.Name = "grandTotalText";
            this.grandTotalText.Size = new System.Drawing.Size(108, 20);
            this.grandTotalText.TabIndex = 71;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimpan.Location = new System.Drawing.Point(667, 352);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(108, 33);
            this.btnSimpan.TabIndex = 72;
            this.btnSimpan.Text = "Simpan Transaksi";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // TransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 430);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.grandTotalText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvPembelian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.qtyText);
            this.Controls.Add(this.hargaText);
            this.Controls.Add(this.typeBarangText);
            this.Controls.Add(this.nmBarangText);
            this.Controls.Add(this.kdBarangText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePenjualan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "TransaksiPembelian";
            this.Text = "TransaksiPembelian";
            this.Load += new System.EventHandler(this.TransaksiPembelian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePenjualan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox qtyText;
        private System.Windows.Forms.TextBox hargaText;
        private System.Windows.Forms.TextBox typeBarangText;
        private System.Windows.Forms.TextBox nmBarangText;
        private System.Windows.Forms.TextBox kdBarangText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvPembelian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grandTotalText;
        private System.Windows.Forms.Button btnSimpan;
    }
}