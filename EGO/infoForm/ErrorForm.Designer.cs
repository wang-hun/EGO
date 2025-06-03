namespace EGO.infoForm
{
    partial class ErrorForm
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
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            glowLabel1 = new control.GlowLabel();
            panel1 = new Panel();
            roundedButton1 = new control.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Resource1.ERROR;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5294113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.47059F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(glowLabel1, 1, 0);
            tableLayoutPanel1.Location = new Point(117, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(384, 75);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // glowLabel1
            // 
            glowLabel1.Anchor = AnchorStyles.Left;
            glowLabel1.AutoSize = true;
            glowLabel1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            glowLabel1.GlowColor = Color.Black;
            glowLabel1.GlowWidth = 3;
            glowLabel1.Location = new Point(93, 22);
            glowLabel1.Name = "glowLabel1";
            glowLabel1.Size = new Size(139, 30);
            glowLabel1.TabIndex = 7;
            glowLabel1.Text = "glowLabel1";
            glowLabel1.TextColor = Color.Yellow;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(1, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 93);
            panel1.TabIndex = 5;
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
            roundedButton1.Location = new Point(195, 158);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(195, 74);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "确定";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += button1_Click;
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(577, 258);
            Controls.Add(roundedButton1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErrorForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private control.RoundedButton roundedButton1;
        private control.GlowLabel highLightLabel1;
        private control.GlowLabel glowLabel1;
    }
}