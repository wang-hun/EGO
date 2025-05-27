namespace EGO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        const int WM_SYSCOMMAND = 0x112;
        const int SC_CLOSE = 0xF060;
        const int SC_MINIMIZE = 0xF020;
        const int SC_MAXIMIZE = 0xF030;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam.ToInt32() == SC_MINIMIZE)
                {
                    this.Hide(); // 隐藏窗体
                    this.ShowInTaskbar = false; // 不在任务栏显示
                    return;
                }
            }
            base.WndProc(ref m);
        }
   

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // 取消关闭操作
                this.Hide(); // 隐藏窗体
                this.ShowInTaskbar = false;
            }
        }
        public void ShowForm(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true; //任务栏显示
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowForm(sender, e);

        }
    }
}
