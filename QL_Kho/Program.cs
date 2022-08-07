using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Kho
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static String ten = "";

        public static int mahd = 0;
        public static int mapn = 0;
        public static String TK = "";
        public static String MK = "";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}
