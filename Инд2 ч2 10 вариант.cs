using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инд2_ч2_10_вариант
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, a, b, x;
            Console.WriteLine("D(y): a^2+b^2>0;");
            Console.WriteLine("Введите значения переменных a, b, x");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());

          
            if (Math.Pow(a,2)+Math.Pow(b, 2) > 0)
            {
                y = (Math.Pow(Math.Cos(Math.Pow(x, 3)), 2)) - (x / (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))));
                Console.WriteLine("y=" + y);

            }
            else
            {
                Console.WriteLine("Заданные значения не входят в область определения");
            }

        }
    }
}
