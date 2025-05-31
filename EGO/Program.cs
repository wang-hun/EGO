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
            
            bool isNotRunning;  //互斥体判断
            Mutex instance = new Mutex(true, "MutexName", out isNotRunning);   //同步基元变量
            if (!isNotRunning)  // 如果不是未运行状态
            {
                Environment.Exit(1);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}