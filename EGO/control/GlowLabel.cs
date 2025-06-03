namespace EGO.control
{
    public class GlowLabel : Label
    {
        // 发光属性
        private Color _glowColor = Color.Black;
        private int _glowWidth = 6;
        private Color _textColor = Color.Yellow;

        // 发光颜色属性
        public Color GlowColor
        {
            get => _glowColor;
            set { _glowColor = value; Invalidate(); }
        }

        // 发光宽度属性
        public int GlowWidth
        {
            get => _glowWidth;
            set { _glowWidth = value > 0 ? value : 1; Invalidate(); }
        }

        // 文字颜色属性
        public Color TextColor
        {
            get => _textColor;
            set { _textColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                // 测量文字尺寸GlowLabel
                SizeF size = e.Graphics.MeasureString(Text, Font);

                // 计算居中位置
                PointF point = new PointF(
                    ClientSize.Width / 2 - size.Width / 2,
                    ClientSize.Height / 2 - size.Height / 2
                );

                // 绘制四个方向的发光效果
                for (int i = 0; i < GlowWidth; i++)
                {
                    for (int j = 0; j < GlowWidth; j++)
                    {
                        DrawGlowText(e.Graphics, Text, point.X + i, point.Y + j, i);
                    }
                    for (int j = 0; j < GlowWidth; j++)
                    {
                        DrawGlowText(e.Graphics, Text, point.X - i, point.Y - j, i);
                    }
                }

                // 绘制对角线方向的发光效果
                for (int i = 0; i < GlowWidth; i++)
                {
                    DrawGlowText(e.Graphics, Text, point.X - i, point.Y + i, i, 3);
                    DrawGlowText(e.Graphics, Text, point.X + i, point.Y - i, i, 3);
                }

                // 绘制主体文字
                using (var brush = new SolidBrush(TextColor))
                {
                    e.Graphics.DrawString(Text, Font, brush, point);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
            base.OnPaint(e);
        }

        // 绘制发光文字（带透明度衰减）
        private void DrawGlowText(Graphics g, string text, float x, float y, int distance, int divisor = 5)
        {
            int alpha = 255 / divisor / (distance + 1);
            if (alpha > 0)
            {
                using (var brush = new SolidBrush(Color.FromArgb(alpha, GlowColor)))
                {
                    g.DrawString(text, Font, brush, x, y);
                }
            }
        }
    }
}
