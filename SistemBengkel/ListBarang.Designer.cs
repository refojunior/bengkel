namespace SistemBengkel
{
    partial class ListBarang
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
            this.lsvBarang = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvBarang
            // 
            this.lsvBarang.Location = new System.Drawing.Point(12, 12);
            this.lsvBarang.Name = "lsvBarang";
            this.lsvBarang.Size = new System.Drawing.Size(517, 280);
            this.lsvBarang.TabIndex = 0;
            this.lsvBarang.UseCompatibleStateImageBehavior = false;
            this.lsvBarang.DoubleClick += new System.EventHandler(this.lsvCustomer_DoubleClick);
            // 
            // ListBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 304);
            this.Controls.Add(this.lsvBarang);
            this.Name = "ListBarang";
            this.Text = "ListBarang";
            this.Load += new System.EventHandler(this.ListBarang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvBarang;
    }
}