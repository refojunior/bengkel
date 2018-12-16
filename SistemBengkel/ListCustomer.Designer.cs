namespace SistemBengkel
{
    partial class ListCustomer
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
            this.lsvCustomer = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvCustomer
            // 
            this.lsvCustomer.Location = new System.Drawing.Point(12, 21);
            this.lsvCustomer.Name = "lsvCustomer";
            this.lsvCustomer.Size = new System.Drawing.Size(568, 273);
            this.lsvCustomer.TabIndex = 1;
            this.lsvCustomer.UseCompatibleStateImageBehavior = false;
            this.lsvCustomer.DoubleClick += new System.EventHandler(this.lsvCustomer_DoubleClick);
            // 
            // ListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 314);
            this.Controls.Add(this.lsvCustomer);
            this.Name = "ListCustomer";
            this.Text = "ListCustomer";
            this.Load += new System.EventHandler(this.ListCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvCustomer;
    }
}