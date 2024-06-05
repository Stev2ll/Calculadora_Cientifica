using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encerder_pixel
{
    public class Lazo: Circunferencia
    {
        public double t = 0;
        //public double x0 = 0;
        //public double y0 = 0;
        public double Rd = 1;

        public override void Encender(Bitmap pixelVextor)
        {
            Vector v = new Vector(0,0,color0);

            do
            {
                v.x0 = x0 + Rd * Math.Sin(2*t);
                v.y0 = y0 + Rd * Math.Cos(3*t);
                v.Encender(pixelVextor);
                t += 0.001;
            }while (t<=2 * Math.PI);
        }
    }
}
