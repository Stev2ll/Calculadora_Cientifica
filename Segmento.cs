using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encerder_pixel
{
    public class Segmento : Vector
    {
        public double xf { get; set; }
        public double yf { get; set; }
        public Segmento() { }

        public override void Encender(Bitmap lienzo)
        {

            double t = 0;
            //double dt = 0.0001;
            Vector v = new Vector(0, 0, color0);
            do
            {
                v.x0 = (x0 * (1-t) + xf*t);
                v.y0 = (y0 * (1 - t) + yf * t);
                v.color0 = color0;
                v.Encender(lienzo);
                t += 0.005;

            } while (t <= 1);
        }
    }
}
