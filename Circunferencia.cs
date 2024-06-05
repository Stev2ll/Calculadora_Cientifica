using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encerder_pixel
{
    public class Circunferencia : Vector
    {
        public double rd;


        public override void Encender(Bitmap pixelVextor)
        {
            double t = 0;
            Vector v = new Vector(0,0,color0);

            do
            {
                v.x0 = x0 + rd * Math.Sin(t);
                v.y0 = y0 + rd * Math.Cos(t);
                v.Encender(pixelVextor);
                t += 0.001;
            }
            while (t <= (2*Math.PI));
        }
    }
}
