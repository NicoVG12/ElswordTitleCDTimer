using HoraryClock;
using Language;
using System.Globalization;

namespace TitleTimerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo culture = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Config.Instance().Load();
            LanguageManager.Instance().LoadLanguages();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}