using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wrappers
{
    public class CirclePanel : Panel
    {
        private Pen Pen;
        private Brush Brush;
        private string CoinAnnonation;
        public CirclePanel(Color circleColor, string coinAnnonation)
        {
            this.Pen = new Pen(circleColor);
            this.Brush = new SolidBrush(circleColor);
            this.CoinAnnonation = coinAnnonation;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicWrapper.DrawCircle(g, Pen, this.Width / 2, this.Height / 2, this.Width / 2 - 1);
            GraphicWrapper.FillCircle(g, Brush, this.Width / 2, this.Height / 2, this.Width / 2 - 1);
            GraphicWrapper.DrawString(g, this.CoinAnnonation, this.Font, this.Width / 2, this.Height / 2);
        }

        protected override void OnResize(EventArgs e)
        {
            this.Width = this.Height;
            base.OnResize(e);
        }
    }
}
