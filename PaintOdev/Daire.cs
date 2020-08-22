

using System.Drawing;
using System.Windows.Forms;

namespace PaintOdev
{
    class Daire:Sekil
    {
      
        private int cap;
        SolidBrush brs;
        public Color colors;

        public Daire(Color rnk)
        { 
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
            cap = bax - X;
        }

        public override void Ciz(Graphics daireciz)
        {
            daireciz.DrawEllipse(new Pen(colors), X, Y, cap, cap);
            daireciz.FillEllipse(brs, X, Y, cap, cap);
        }
    }
}
