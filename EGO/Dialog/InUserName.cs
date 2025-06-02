using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (text == "清河白莲")
            {

            }
            else if (text == "沁人龙涎香")
            {


            }
            else
            {


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
