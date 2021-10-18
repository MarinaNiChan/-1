using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инд2_ч1_10_вариант
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, a, b, x;
            Console.WriteLine("D(w): x!=0; x^2+b>=0;");
            Console.WriteLine("Введите значения переменных a, b, x");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());

            double d;
            d = Math.Pow(x, 2) + b;

            if (x != 0 | d>=0)
            {
                w = Math.Sqrt(Math.Pow(x, 2) + b) - (Math.Pow(b, 2) * Math.Pow(Math.Sin(x + a), 3)) / b;
                Console.WriteLine("w="+w);

            }
            else
            {
                Console.WriteLine("Заданные значения не входят в область определения");
            }

        }

    }
}
