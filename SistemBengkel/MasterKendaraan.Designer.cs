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
            this.panelKendaraan = new System.Windows.Forms.Panel();
            this.showKendaraanGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id_kendaraan = new System.Windows.Forms.Label();
            this.platNomorText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveKendaraan = new System.Windows.Forms.Button();
            this.tahunText = new System.Windows.Forms.TextBox();
            this.merkText = new System.Windows.Forms.TextBox();
            this.namaKendaraanText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelKendaraan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showKendaraanGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKendaraan
            // 
            this.panelKendaraan.Controls.Add(this.showKendaraanGrid);
            this.panelKendaraan.Controls.Add(this.groupBox2);
            this.panelKendaraan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKendaraan.Location = new System.Drawing.Point(0, 0);
            this.panelKendaraan.Name = "panelKendaraan";
            this.panelKendaraan.Size = new System.Drawing.Size(739, 445);
            this.panelKendaraan.TabIndex = 4;
            // 
            // showKendaraanGrid
            // 
            this.showKendaraanGrid.AllowUserToAddRows = false;
            this.showKendaraanGrid.AllowUserToDeleteRows = false;
            this.showKendaraanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showKendaraanGrid.Location = new System.Drawing.Point(22, 231);
            this.showKendaraanGrid.Name = "showKendaraanGrid";
            this.showKendaraanGrid.ReadOnly = true;
            this.showKendaraanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showKendaraanGrid.Size = new System.Drawing.Size(696, 150);
            this.showKendaraanGrid.TabIndex = 2;
            this.showKendaraanGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showKendaraanGrid_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.id_kendaraan);
            this.groupBox2.Controls.Add(this.platNomorText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxCustomer);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnDelete);
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
            // id_kendaraan
            // 
            this.id_kendaraan.AutoSize = true;
            this.id_kendaraan.Location = new System.Drawing.Point(28, 21);
            this.id_kendaraan.Name = "id_kendaraan";
            this.id_kendaraan.Size = new System.Drawing.Size(85, 15);
            this.id_kendaraan.TabIndex = 17;
            this.id_kendaraan.Text = "id_kendaraan";
            this.id_kendaraan.Visible = false;
            // 
            // platNomorText
            // 
            this.platNomorText.Location = new System.Drawing.Point(151, 154);
            this.platNomorText.Name = "platNomorText";
            this.platNomorText.Size = new System.Drawing.Size(275, 21);
            this.platNomorText.TabIndex = 10;
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
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(151, 34);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(275, 23);
            this.comboBoxCustomer.TabIndex = 15;
            this.comboBoxCustomer.Text = "- Pilih -";
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(462, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSaveKendaraan.Click += new System.EventHandler(this.btnSaveKendaraan_Click);
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
            // MasterKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 445);
            this.Controls.Add(this.panelKendaraan);
            this.Name = "MasterKendaraan";
            this.Text = "Kendaraan";
            this.Load += new System.EventHandler(this.MasterKendaraan_Load);
            this.panelKendaraan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showKendaraanGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKendaraan;
        private System.Windows.Forms.DataGridView showKendaraanGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox platNomorText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveKendaraan;
        private System.Windows.Forms.TextBox tahunText;
        private System.Windows.Forms.TextBox merkText;
        private System.Windows.Forms.TextBox namaKendaraanText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label id_kendaraan;

    }
}