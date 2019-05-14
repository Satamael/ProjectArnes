using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectArnes
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLClass.OpenConnection();
            Application.Run(new MainForm());
            SQLClass.CloseConnection();
        }
    }
}
