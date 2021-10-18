using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cek, chas, min;
            Console.WriteLine("Введите количество секунд");
            cek = ulong.Parse(Console.ReadLine());
            chas = cek / 3600;
            min = (cek - (chas * 3600)) / 60;
            Console.WriteLine("За "+cek+" прошло часов - "+chas+", минут - "+min+".");

        }
    }
}
