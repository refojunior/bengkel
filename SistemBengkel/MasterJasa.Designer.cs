namespace SistemBengkel
{
    partial class MasterJasa
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
            this.panelJasa = new System.Windows.Forms.Panel();
            this.showJasaGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.idJasaText = new System.Windows.Forms.Label();
            this.hargaJasaText = new System.Windows.Forms.TextBox();
            this.namaJasaText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelJasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showJasaGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelJasa
            // 
            this.panelJasa.Controls.Add(this.showJasaGrid);
            this.panelJasa.Controls.Add(this.groupBox1);
            this.panelJasa.Location = new System.Drawing.Point(12, 12);
            this.panelJasa.Name = "panelJasa";
            this.panelJasa.Size = new System.Drawing.Size(624, 380);
            this.panelJasa.TabIndex = 5;
            // 
            // showJasaGrid
            // 
            this.showJasaGrid.AllowUserToAddRows = false;
            this.showJasaGrid.AllowUserToDeleteRows = false;
            this.showJasaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showJasaGrid.Location = new System.Drawing.Point(10, 212);
            this.showJasaGrid.MultiSelect = false;
            this.showJasaGrid.Name = "showJasaGrid";
            this.showJasaGrid.ReadOnly = true;
            this.showJasaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showJasaGrid.Size = new System.Drawing.Size(579, 150);
            this.showJasaGrid.TabIndex = 1;
            this.showJasaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showJasaGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.idJasaText);
            this.groupBox1.Controls.Add(this.hargaJasaText);
            this.groupBox1.Controls.Add(this.namaJasaText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
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
            // idJasaText
            // 
            this.idJasaText.AutoSize = true;
            this.idJasaText.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idJasaText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idJasaText.Location = new System.Drawing.Point(147, 37);
            this.idJasaText.Name = "idJasaText";
            this.idJasaText.Size = new System.Drawing.Size(16, 23);
            this.idJasaText.TabIndex = 10;
            this.idJasaText.Text = "?";
            // 
            // hargaJasaText
            // 
            this.hargaJasaText.Location = new System.Drawing.Point(151, 97);
            this.hargaJasaText.Name = "hargaJasaText";
            this.hargaJasaText.Size = new System.Drawing.Size(275, 21);
            this.hargaJasaText.TabIndex = 9;
            // 
            // namaJasaText
            // 
            this.namaJasaText.Location = new System.Drawing.Point(151, 66);
            this.namaJasaText.Name = "namaJasaText";
            this.namaJasaText.Size = new System.Drawing.Size(275, 21);
            this.namaJasaText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Jasa";
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
            // MasterJasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(652, 398);
            this.Controls.Add(this.panelJasa);
            this.Name = "MasterJasa";
            this.Text = "MasterJasa";
            this.Load += new System.EventHandler(this.MasterJasa_Load);
            this.panelJasa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showJasaGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelJasa;
        private System.Windows.Forms.DataGridView showJasaGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label idJasaText;
        private System.Windows.Forms.TextBox hargaJasaText;
        private System.Windows.Forms.TextBox namaJasaText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}