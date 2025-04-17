using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Human:ITalk,IReflection
    {
        public void Thinks() { Console.WriteLine("Думает - Пора вставать"); }
        public void Talk() { Console.WriteLine("Говорит - Хочу спать"); }
        public void Screams() { Console.WriteLine("Говорит громко - Подъём!!!"); }
    }
}
