using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface 
{
//    Задание 1. Реализовать один интерфейс с одним методом в производном классе.

//1.Создайте интерфейс с именем IInterface.

//2.Создайте в интерфейсе метод Method().

//3.Создайте производный класс DerivedClass, который реализует интерфейс IInterface.

//4.Реализуйте метод Method() в классе DerivedClass, чтобы в консольном окне выводился текст:

//Метод, реализованный в классе DerivedClass


    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass(); 
            derivedClass.Method();
                Console.ReadKey();
        }
    }
}
