using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6
{
    internal class Aa:A
    {
       new public double Add(double a, double b)
        {
            Console.WriteLine("Вызван переопределённый метод Add в Aa");
            return base.Add(a, b) + 1;
        }

        new public double Divide(double a, double b)
        {
            Console.WriteLine("Вызван переопределённый метод Divide в Aa");
            return base.Divide(a, b);
        }
    }
}
