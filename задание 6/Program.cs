using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A baseA = new A();
            Aa derivedAa = new Aa();
            Ab derivedAb = new Ab();

            Console.WriteLine($"A: 3 + 2 = {baseA.Add(3, 2)}");
            Console.WriteLine($"Aa: 3 + 2 = {derivedAa.Add(3, 2)}");
            Console.WriteLine($"Ab: sqrt(16) = {derivedAb.SquareRoot(16)}");
            Console.WriteLine($"Ab: square(5) = {derivedAb.Square(5)}");
            Console.ReadLine();
        }
    }
}
