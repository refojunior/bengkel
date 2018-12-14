namespace SistemBengkel
{
    partial class ListKendaraan
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
            this.lsvKendaraan = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvKendaraan
            // 
            this.lsvKendaraan.Location = new System.Drawing.Point(13, 44);
            this.lsvKendaraan.Name = "lsvKendaraan";
            this.lsvKendaraan.Size = new System.Drawing.Size(611, 273);
            this.lsvKendaraan.TabIndex = 0;
            this.lsvKendaraan.UseCompatibleStateImageBehavior = false;
            this.lsvKendaraan.DoubleClick += new System.EventHandler(this.lsvKendaraan_DoubleClick);
            // 
            // ListKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 341);
            this.Controls.Add(this.lsvKendaraan);
            this.Name = "ListKendaraan";
            this.Text = "ListKendaraan";
            this.Load += new System.EventHandler(this.ListKendaraan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvKendaraan;
    }
}