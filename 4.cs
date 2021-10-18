using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите значение первой переменной");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение второй переменной");
            y = int.Parse(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Первая переменная равна "+x+", вторая переменная равна "+y+".");

        }
    }
}
