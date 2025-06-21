using EGO.Dialog;
using EGO.form;

namespace EGO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool isNotRunning;
            Mutex instance = new Mutex(true, "EGO", out isNotRunning);
            if (!isNotRunning)
            {
                Environment.Exit(1);
            }//·À¶à¿ª
            ApplicationConfiguration.Initialize();
            var Config = Configuration.Instance;
            if (!Config.ReadUser())
                Application.Run(new InUserName());
            Application.Run(new LOGO_EGO(2500));
            Application.Run(new MainForm());
        }
    }
}