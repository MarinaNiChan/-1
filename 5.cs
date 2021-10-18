using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s, p;
            Console.WriteLine("Ведите первый катет");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй катет");
            b = double.Parse(Console.ReadLine());

            s = (a * b) / 2;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            p = a + b + c;
            Console.WriteLine("Площадь = "+s+", периметр = "+p+".");


        }
    }
}
