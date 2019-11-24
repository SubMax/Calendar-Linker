using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalendarLinker
{
    public static class Program
    {
        internal static string URL;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string URL = " ";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
