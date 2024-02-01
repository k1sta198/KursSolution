using System;
using System.Windows.Forms;

namespace Sort
{
    internal static class Program
    {
        /// <summary> Главная точка входа для приложения. </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // авторизация
            Application.Run(new Main());
        }
    }
}