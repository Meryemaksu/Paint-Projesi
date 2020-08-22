using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintOdev
{
    class Kare:Sekil
    {
        
        public int w;
        public SolidBrush brs;
        public Color colors;
       
    public Kare(Color rnk)
        {
            w = 0;
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
            w = Math.Abs(bax - X);
        }

        public override void Ciz(Graphics cizimAraci)
        {
            //Point ile karenin ortasından büyütme yapar.
            Point[] p3 = { new Point(X - (w / 2), Y - (w / 2)), new Point(X + (w / 2), Y - (w / 2)),new Point(X+(w/2),Y+(w/2)),new Point(X-(w/2),Y+(w/2)) };
            cizimAraci.FillPolygon(brs, p3);
            /*sol köşeden başlar sag kösede kareyi büyütür.
            // cizimAraci.DrawRectangle(new Pen(colors), X, Y, w, w);
            //cizimAraci.FillRectangle(brs, X, Y, w, w);*/
            
        }
    }
}
