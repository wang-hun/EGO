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
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}