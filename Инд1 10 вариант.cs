using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инд.задание_1__10_вариант_
{
    class Program
    {
       // enum tip {Kanctovari, Orgtechnika}
        static void Main(string[] args)
        {
         
            string str1, str2, str3;
            double cena1, cena2, cena3;
            int sht1, sht2, sht3;


            Console.WriteLine("Введите наименование первого товара, его тип, цену за 1 шт в гривнах и количество");
            str1 = Console.ReadLine();
            //enum
            cena1 = double.Parse(Console.ReadLine());
            sht1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите наименование второго товара, его тип, цену за 1 шт в гривнах и количество");
            str2 = Console.ReadLine();
            //enum
            cena2 = double.Parse(Console.ReadLine());
            sht2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите наименование третьего товара, его тип, цену за 1 шт в гривнах и количество");
            str3 = Console.ReadLine();
            //enum
            cena3 = double.Parse(Console.ReadLine());
            sht3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\tПрайс-лист");
            Console.WriteLine("\tНаименование товара\t\tТип товара\t\tЦена за 1 шт (грн)\t\tКоличество");
            Console.WriteLine($"1.\t{str1}\t\t{cena1}\t\t{sht1}");
            Console.WriteLine($"2.\t{str2}\t\t{cena2}\t\t{sht2}");
            Console.WriteLine($"3.\t{str3}\t\t{cena3}\t\t{sht3}");




        }
    }
}
