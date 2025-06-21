using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApp.Model;
using WebApp.Static;


namespace EGO.Dialog
{
    public partial class InUserName : Form
    {
        public InUserName()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == ' ')
            {
                e.Handled = true;

            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Execute();
                return true; // 表示已处理按键
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        void Execute()
        {
            var text = textBox1.Text;
            if (text.Trim().IsNullOrEmpty())
            {
                this.ShowError("用\"无名氏\"来称呼您？");
                return;
            }
            if (text == "清河白莲")
            {
                this.ShowError("这不是你的名字。");
            }
            else if (text == "沁人龙涎香")
            {
                this.ShowError("这个名字会带来“灾厄”。");

            }
            else
            {
                Directory.CreateDirectory(Settings.AppSavePath); // 自动创建不存在的目录
                var user = new UserData(text);
                var data = new
                {
                    user

                };

                // 3. 组合文件路径
                string filePath = Path.Combine(Settings.AppSavePath, "Master.data");
                File.WriteAllText(filePath, JsonConvert.SerializeObject(data, Formatting.Indented));

                //todo ： 后续操作
                //code：
                RunTimeData.SetUser(user);
                this.Close();
            }

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void roundedButton1_MouseHover(object sender, EventArgs e)
        {
            roundedButton1.ForeColor = Color.FromArgb(153, 117, 0);
        }

        private void roundedButton1_MouseLeave(object sender, EventArgs e)
        {
            roundedButton1.ForeColor = Color.DimGray;
        }

      

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
