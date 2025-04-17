using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine($"{myClass.MyGetInt()}");//метод, возвращающий число типа int
            Console.WriteLine($"{myClass.MyGetPi()}");//метод, возвращающий число PI
            Console.WriteLine($"{myClass.MySquare(3)}");//метод, возвращающий x в квадрате
            Console.WriteLine($"{myClass.MySqrt(5.25)}");//метод, возвращающий корень квадратный из x
            Console.ReadLine();
        }
    }
}
