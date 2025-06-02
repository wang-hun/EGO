using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EGO.control
{
    public class CircularButton : Button
    {
        // 构造函数设置默认属性
        public CircularButton()
        {
            // 启用双缓冲减少闪烁
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer,
                     true);

            // 确保按钮是正方形（圆形需要等宽高）
            Size = new Size(80, 80);
        }

        // 重写绘制方法
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  // 抗锯齿

            // 创建圆形路径
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(ClientRectangle);

                // 设置按钮区域（使只有圆形区域可点击）
                Region = new Region(path);

                // 填充圆形背景
                using (Brush brush = new SolidBrush(BackColor))
                {
                    g.FillPath(brush, path);
                }

                // 绘制圆形边框
                using (Pen pen = new Pen(ForeColor, 2))
                {
                    g.DrawPath(pen, path);
                }
            }

            // 绘制按钮文字（居中）
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter |
                                   TextFormatFlags.VerticalCenter |
                                   TextFormatFlags.WordBreak;
            TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor, flags);
        }

        // 保持宽高相等（确保始终是圆形）
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int size = Math.Min(Width, Height);
            Size = new Size(size, size);
        }
    }
}