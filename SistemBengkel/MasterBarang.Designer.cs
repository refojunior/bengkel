namespace SistemBengkel
{
    partial class MasterBarang
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
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.showBarangGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.idBarangText = new System.Windows.Forms.Label();
            this.hargaText = new System.Windows.Forms.TextBox();
            this.merkText = new System.Windows.Forms.TextBox();
            this.namaBarangText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipeComboBox = new System.Windows.Forms.ComboBox();
            this.panelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showBarangGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.showBarangGrid);
            this.panelCustomer.Controls.Add(this.groupBox1);
            this.panelCustomer.Location = new System.Drawing.Point(12, 12);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(624, 380);
            this.panelCustomer.TabIndex = 4;
            // 
            // showBarangGrid
            // 
            this.showBarangGrid.AllowUserToAddRows = false;
            this.showBarangGrid.AllowUserToDeleteRows = false;
            this.showBarangGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showBarangGrid.Location = new System.Drawing.Point(10, 212);
            this.showBarangGrid.MultiSelect = false;
            this.showBarangGrid.Name = "showBarangGrid";
            this.showBarangGrid.ReadOnly = true;
            this.showBarangGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showBarangGrid.Size = new System.Drawing.Size(579, 150);
            this.showBarangGrid.TabIndex = 1;
            this.showBarangGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showBarangGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipeComboBox);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.idBarangText);
            this.groupBox1.Controls.Add(this.hargaText);
            this.groupBox1.Controls.Add(this.merkText);
            this.groupBox1.Controls.Add(this.namaBarangText);
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
            this.groupBox1.Text = "Form Barang";
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
            // idBarangText
            // 
            this.idBarangText.AutoSize = true;
            this.idBarangText.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBarangText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idBarangText.Location = new System.Drawing.Point(147, 37);
            this.idBarangText.Name = "idBarangText";
            this.idBarangText.Size = new System.Drawing.Size(16, 23);
            this.idBarangText.TabIndex = 10;
            this.idBarangText.Text = "?";
            // 
            // hargaText
            // 
            this.hargaText.Location = new System.Drawing.Point(151, 141);
            this.hargaText.Name = "hargaText";
            this.hargaText.Size = new System.Drawing.Size(275, 21);
            this.hargaText.TabIndex = 9;
            // 
            // merkText
            // 
            this.merkText.Location = new System.Drawing.Point(151, 115);
            this.merkText.Name = "merkText";
            this.merkText.Size = new System.Drawing.Size(275, 21);
            this.merkText.TabIndex = 8;
            // 
            // namaBarangText
            // 
            this.namaBarangText.Location = new System.Drawing.Point(151, 89);
            this.namaBarangText.Name = "namaBarangText";
            this.namaBarangText.Size = new System.Drawing.Size(275, 21);
            this.namaBarangText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(24, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Merk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipe Barang";
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
            // tipeComboBox
            // 
            this.tipeComboBox.FormattingEnabled = true;
            this.tipeComboBox.Items.AddRange(new object[] {
            "Kendaraan",
            "Sparepart"});
            this.tipeComboBox.Location = new System.Drawing.Point(151, 62);
            this.tipeComboBox.Name = "tipeComboBox";
            this.tipeComboBox.Size = new System.Drawing.Size(275, 23);
            this.tipeComboBox.TabIndex = 15;
            this.tipeComboBox.Text = "- Pilih -";
            // 
            // MasterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 445);
            this.Controls.Add(this.panelCustomer);
            this.Name = "MasterBarang";
            this.Text = "MasterBarang";
            this.Load += new System.EventHandler(this.MasterBarang_Load);
            this.panelCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showBarangGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.DataGridView showBarangGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label idBarangText;
        private System.Windows.Forms.TextBox hargaText;
        private System.Windows.Forms.TextBox merkText;
        private System.Windows.Forms.TextBox namaBarangText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipeComboBox;
    }
}