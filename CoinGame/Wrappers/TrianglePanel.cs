using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinGame.Wrappers
{
    public class TrianglePanel : Panel
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define polygon.
            PointF point1 = new PointF(0, 0);
            PointF point2 = new PointF(10, 0);
            PointF point3 = new PointF(5, 5);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
             };

            // Draw polygon curve to screen.
            e.Graphics.DrawPolygon(blackPen, curvePoints);
            e.Graphics.FillPolygon(Brushes.Black, curvePoints);
            PointF[] s =
                {
               new PointF(0,0),
               new PointF(5, 0),
               new PointF(5, 5)
               };

            e.Graphics.FillPolygon(Brushes.Red, s);

        }


    }
}
