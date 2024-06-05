using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encerder_pixel
{
    public class Procesos
    {
        public static int sx1 = 0;
        public static int sx2 = 700;
        public static int sy1 = 0;
        public static int sy2 = 550;
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -8.75;
        public static double y2 = 8.75;

        public Procesos() { }

        public static void pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)((((sx1 - sx2) / (x1 - x2)) * (x - x2)) + sx2);
            sy = (int)((((sy1 - sy2) / (y2 - y1)) * (y - y1)) + sy2);
        }


    }
}
