namespace EGO.Dialog
{
    partial class InUserName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InUserName));
            label1 = new Label();
            textBox1 = new TextBox();
            roundedButton1 = new control.RoundedButton();
            circularButton1 = new control.CircularButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 48);
            label1.Name = "label1";
            label1.Size = new Size(497, 39);
            label1.TabIndex = 0;
            label1.Text = "输入我对您的称呼，开启使用之旅吧";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.Location = new Point(52, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 39);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Transparent;
            roundedButton1.BackgroundImage = Resource1.button;
            roundedButton1.BackgroundImageLayout = ImageLayout.Stretch;
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderWidth = 0;
            roundedButton1.CornerRadius = 200;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            roundedButton1.ForeColor = Color.DimGray;
            roundedButton1.Location = new Point(166, 177);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(195, 74);
            roundedButton1.TabIndex = 2;
            roundedButton1.Text = "决定了";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            roundedButton1.MouseLeave += roundedButton1_MouseLeave;
            roundedButton1.MouseHover += roundedButton1_MouseHover;
            // 
            // circularButton1
            // 
            circularButton1.BackColor = Color.Transparent;
            circularButton1.BackgroundImage = Resource1.close;
            circularButton1.BackgroundImageLayout = ImageLayout.Zoom;
            circularButton1.Location = new Point(510, 1);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(44, 44);
            circularButton1.TabIndex = 4;
            circularButton1.UseVisualStyleBackColor = false;
            circularButton1.Click += circularButton1_Click;
            // 
            // InUserName
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 263);
            ControlBox = false;
            Controls.Add(circularButton1);
            Controls.Add(roundedButton1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InUserName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InUserName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private control.RoundedButton roundedButton1;
        private control.CircularButton circularButton1;
    }
}