using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemBengkel
{
  

    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Menu());
        }


        public static string idKendaraan { get; set; }

        public static string nmKendaraan { get; set; }

        public static string nmCustomer { get; set; }

        public static string merk { get; set; }

        public static string tahun { get; set; }

        public static string plat_nomor { get; set; }

        public static string idCust { get; set; }

        public static string namaCustomer { get; set; }

        public static string alamat { get; set; }

        public static string email { get; set; }

        public static string telp { get; set; }

        public static string idBarang { get; set; }

        public static string namaBarang { get; set; }

        public static string typeBarang { get; set; }

        public static string merkBarang { get; set; }

        public static string hargaBarang { get; set; }
    }


}
