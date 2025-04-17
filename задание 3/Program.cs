using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.Method1();
            derived.Method2();
            derived.Method3();
            Console.ReadLine();
        }
    }
}
