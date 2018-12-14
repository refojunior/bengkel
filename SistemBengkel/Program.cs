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
            //Application.Run(new Login());
            Application.Run(new TransaksiService());
        }


        public static string idKendaraan { get; set; }

        public static string nmKendaraan { get; set; }

        public static string nmCustomer { get; set; }

        public static string merk { get; set; }

        public static string tahun { get; set; }

        public static string plat_nomor { get; set; }
    }


}
