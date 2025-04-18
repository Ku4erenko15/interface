using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6
{
    class Ab : A, ISoper
    {
        public double Square(double a)
        {
            return a * a;
        }

        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);

        }
    }
}
