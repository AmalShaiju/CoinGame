using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrappers
{
    public static class GraphicWrapper
    {
        public static void DrawCircle(this Graphics g, Pen pen,
                                      float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        public static void FillCircle(this Graphics g, Brush brush,
                                      float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        public static void DrawString(this Graphics g, string text, Font font, float centerX, float centerY)
        {
            using (StringFormat stringformat = new StringFormat())
            {
                stringformat.Alignment = StringAlignment.Center;
                stringformat.LineAlignment = StringAlignment.Center;
                g.DrawString(text, font, Brushes.Black, centerX, centerY, stringformat);
            }
        }
    }
}
