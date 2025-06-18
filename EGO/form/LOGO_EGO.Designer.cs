namespace EGO.form
{
    partial class LOGO_EGO
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            glowLabel1 = new control.GlowLabel();
            glowLabel2 = new control.GlowLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Resource1.本我1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(57, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 301);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // glowLabel1
            // 
            glowLabel1.AutoSize = true;
            glowLabel1.Font = new Font("Microsoft YaHei UI", 42F);
            glowLabel1.ForeColor = Color.Gold;
            glowLabel1.GlowColor = SystemColors.InfoText;
            glowLabel1.GlowWidth = 6;
            glowLabel1.Location = new Point(12, 260);
            glowLabel1.Name = "glowLabel1";
            glowLabel1.Size = new Size(108, 90);
            glowLabel1.TabIndex = 1;
            glowLabel1.Text = "本";
            glowLabel1.TextColor = Color.Yellow;
            // 
            // glowLabel2
            // 
            glowLabel2.AutoSize = true;
            glowLabel2.Font = new Font("Microsoft YaHei UI", 42F);
            glowLabel2.ForeColor = Color.Gold;
            glowLabel2.GlowColor = SystemColors.InfoText;
            glowLabel2.GlowWidth = 6;
            glowLabel2.Location = new Point(316, 260);
            glowLabel2.Name = "glowLabel2";
            glowLabel2.Size = new Size(108, 90);
            glowLabel2.TabIndex = 2;
            glowLabel2.Text = "我";
            glowLabel2.TextColor = Color.Yellow;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LOGO_EGO
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(436, 359);
            Controls.Add(glowLabel2);
            Controls.Add(glowLabel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LOGO_EGO";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGO_EGO";
            TopMost = true;
            TransparencyKey = Color.GreenYellow;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private control.GlowLabel glowLabel1;
        private control.GlowLabel glowLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}