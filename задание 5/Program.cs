using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TVSet TV = new TVSet();
            TV.On();
            TV.Off();
            PersonalComputer PC = new PersonalComputer();
            PC.On();
            PC.Off();
            Console.Read();
        }
    }
}
