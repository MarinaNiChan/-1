using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int chas, min, cek;

            Console.WriteLine("Введите числовое значение положения часовой стрелки");
            chas = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числовое значение положения минутной стрелки");
            min = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числовое значение положения секундной стрелки");
            cek = int.Parse(Console.ReadLine());

            /* 1 час = 360/12=30
             * 1 минута = 30/60=0,5
             * 1 секунда = 0,5/60= ~ 0,0083*/

            int h = chas * 30;
            double m = min * (30/60);
            double s = cek * ((30 / 60) / 60);
            double ugol = h + m + s;
            Console.WriteLine("Угол равен "+ugol);


        }
    }
}
