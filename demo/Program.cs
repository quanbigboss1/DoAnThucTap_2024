using demo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.View;

namespace demo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.serverName = "LAPTOP-85H6VGJP\\XIAOSHIYI";
            DatabaseHelper.dbName = "UngDungXinViec";
            DatabaseHelper.userDb = "Lê Đình Quân";
            DatabaseHelper.password = "3132002";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}
