using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintOdev
{
    class Altıgen:Sekil
    {

        public int w, h;
        SolidBrush brs;
        public Color colors;
        public Altıgen(Color rnk)
            
        {
            w = 0;
            h =0;
            brs = new SolidBrush(rnk);
            ColorDialog s = new ColorDialog();
            colors = Color.DarkBlue;
         }

        public override bool Secme(int kx, int ky)
        {
            return base.Secme(kx, ky);
        }


        public override void BitisAta(int bax, int bay)
        {
            w = bax - X;
            h = bay - Y;
        }

        public override void Ciz(Graphics altıgen)
        {
            // Point[] p1 = { new Point(X, Y), new Point(X + w, Y), new Point(X + (3 * w / 2), Y + h), new Point(X + w, Y+ (2 * h)), new Point(X, Y + (2 * h)), new Point(X - (w / 2), Y + h) };
            Point[] p1 = { new Point(X - w, Y), new Point(X - (w / 2), Y - h), new Point(X + (w / 2), Y - h), new Point(X + w, Y), new Point(X + (w / 2), Y + h), new Point(X - (w / 2), Y + h) };
            altıgen.DrawPolygon(new Pen(colors), p1);
            altıgen.FillPolygon(brs, p1);
            
              
        }
    }
}
