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
            
            bool isNotRunning;  //�������ж�
            Mutex instance = new Mutex(true, "MutexName", out isNotRunning);   //ͬ����Ԫ����
            if (!isNotRunning)  // �������δ����״̬
            {
                Environment.Exit(1);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}