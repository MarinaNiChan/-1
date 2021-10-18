using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите x=");
            x = double.Parse(Console.ReadLine());

            y = x * (x * (x * (3 * x - 5) + 2) - 1) + 7;
            Console.WriteLine("Ответ: "+y+".");

        }
    }
}
