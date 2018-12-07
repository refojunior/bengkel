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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.namaCustText = new System.Windows.Forms.TextBox();
            this.alamatText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.telpText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.showCustomersGrid = new System.Windows.Forms.DataGridView();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showCustomersGrid)).BeginInit();
            this.panelCustomer.SuspendLayout();
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
            // namaCustText
            // 
            this.namaCustText.Location = new System.Drawing.Point(151, 63);
            this.namaCustText.Name = "namaCustText";
            this.namaCustText.Size = new System.Drawing.Size(275, 21);
            this.namaCustText.TabIndex = 6;
            // 
            // alamatText
            // 
            this.alamatText.Location = new System.Drawing.Point(151, 89);
            this.alamatText.Name = "alamatText";
            this.alamatText.Size = new System.Drawing.Size(275, 21);
            this.alamatText.TabIndex = 7;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(151, 115);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(275, 21);
            this.emailText.TabIndex = 8;
            // 
            // telpText
            // 
            this.telpText.Location = new System.Drawing.Point(151, 141);
            this.telpText.Name = "telpText";
            this.telpText.Size = new System.Drawing.Size(275, 21);
            this.telpText.TabIndex = 9;
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
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.showCustomersGrid);
            this.panelCustomer.Controls.Add(this.groupBox1);
            this.panelCustomer.Location = new System.Drawing.Point(12, 27);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(624, 380);
            this.panelCustomer.TabIndex = 3;
            // 
            // MasterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(649, 420);
            this.Controls.Add(this.panelCustomer);
            this.Name = "MasterCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showCustomersGrid)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.TextBox telpText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox alamatText;
        private System.Windows.Forms.TextBox namaCustText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView showCustomersGrid;
        private System.Windows.Forms.Panel panelCustomer;
    }
}

