using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOdev
{
    class Sekil
    {

        public int X { get; set; }
        public int Y { get; set; }

        public virtual bool Secme(int kx,int ky)
        {

            return false;
        }

        public virtual void  BitisAta(int bax,int bay)
        {
            
        }

        public virtual void Ciz(Graphics cizimAraci)
        {
            
        }
    }
}
