using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch, a, b, c, d, p;
            Console.WriteLine("Введите положительное четырёхзначное число");
            ch = int.Parse(Console.ReadLine());

            a = ch / 1000;
            b = (ch - a * 1000) / 100;
            c = (ch - a * 1000 - b * 100) / 10;
            d = (ch - a * 1000 - b * 100 - c * 10);
            p = a * b * c * d;
            Console.WriteLine("Произведение равно "+p+".");

        }
    }
}
