using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;

            Console.WriteLine("Введите значение a1 = ");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение a2 = ");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение a3 = ");
            a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b1 = ");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b2 = ");
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b3 = ");
            b3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение c1 = ");
            c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c2 = ");
            c2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c3 = ");
            c3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение d1 = ");
            d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение d2 = ");
            d2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение d3 = ");
            d3 = double.Parse(Console.ReadLine());

            double x, y, z, ax, ay, az, ad;

            ax = a1 * b1 / c1;
            ay = a2 * a1 / a1;
            az = c1 * a2 / a1;
            ad = d1 * a2 / a1;
            a2 = a2 - ax;
            b2 = b2 - ay;
            c2 = c2 - az;
            d2 = d2 - ad;
            ax = a1 * a3 / a1;
            ay = b1 * a3 / a1;
            az = c1 * a3 / a1;
            ad = d1 * a3 / a1;
            a3 = a1 - ax;
            b3 = b3 - ay;
            c3 = c3 - az;
            d3 = d3 - ad;
            ay = b2 * b3 / b3;
            az = c2 * b3 / b2;
            ad = c2 * b3 / b2;
            b2 = b2 - ay;
            c3 = c3 - az;
            d3 = d3 - ad;
            z = d3 / c3;
            y = (c2 - b2 * z) / b2;
            x = (d1 - c1 * z - b1 * y) / a1;

            Console.WriteLine("Ответ: x="+x+", y="+y+", z="+z+".");


        }
    }
}
