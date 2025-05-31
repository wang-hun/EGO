using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGO.control
{

    [DefaultEvent("Click")]
    public class RoundedButton : Button
    {
        private int _cornerRadius = 10;

        // 圆角半径属性（可在属性窗口中设置）
        [Category("Appearance")]
        [Description("按钮圆角半径")]
        [DefaultValue(10)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = value;
                Invalidate(); // 触发重绘
            }
        }

        // 可选：添加边框颜色属性
        [Category("Appearance")]
        [Description("按钮边框颜色")]
        public Color BorderColor { get; set; } = Color.Black;

        // 可选：添加边框宽度属性
        [Category("Appearance")]
        [Description("按钮边框宽度")]
        [DefaultValue(1)]
        public int BorderWidth { get; set; } = 1;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.SteelBlue;
            ForeColor = Color.White;
            Size = new Size(100, 40);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 创建圆角路径
            var rect = new Rectangle(0, 0, Width, Height);
            var path = GetRoundedRectPath(rect, CornerRadius);

            // 设置区域（使按钮点击区域也是圆角）
            Region = new Region(path);

            // 绘制背景
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // 绘制边框
            using (var pen = new Pen(BorderColor, BorderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // 绘制文字（居中）
            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                rect,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        // 创建圆角矩形路径
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();

            // 调整半径确保不超过矩形尺寸
            radius = radius * 2 > rect.Width ? rect.Width / 2 : radius;
            radius = radius * 2 > rect.Height ? rect.Height / 2 : radius;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
