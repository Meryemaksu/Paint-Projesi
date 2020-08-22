using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintOdev
{
    class Ucgen:Sekil
    {
        
        public int w, h;
        SolidBrush brs;
        public Color colors;

        public Ucgen(Color rnk)
        {
            w = h = 0;
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
        public override void Ciz(Graphics UcgenCiz)
        {

            Point[] p2 = { new Point(X, Y), new Point(X - (w / 2), Y + h), new Point(X + (w / 2), Y + h) };
            UcgenCiz.DrawPolygon(new Pen(colors), p2);
            UcgenCiz.FillPolygon(brs, p2);
        }
    }
}
