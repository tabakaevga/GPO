using System;
using System.Windows.Forms;

namespace ModelView
{
    internal static class Program
    {
        /// <summary>
        ///     Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main(string[] arguments)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(arguments.Length == 1 ? new MainForm(arguments[0]) : new MainForm());
        }
    }
}