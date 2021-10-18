using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инд.задание_1__10_вариант_
{
    class Program
    {
       
        static void Main(string[] args)
        {
         
            string str1, str2, str3;
            string tip1, tip2, tip3;
            double cena1, cena2, cena3;
            int sht1, sht2, sht3;


            Console.WriteLine("Введите наименование первого товара, его тип, цену за 1 шт в гривнах и количество");
            str1 = Console.ReadLine();
            tip1 = Console.ReadLine();
            cena1 = double.Parse(Console.ReadLine());
            sht1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите наименование второго товара, его тип, цену за 1 шт в гривнах и количество");
            str2 = Console.ReadLine();
            tip2 = Console.ReadLine();
            cena2 = double.Parse(Console.ReadLine());
            sht2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите наименование третьего товара, его тип, цену за 1 шт в гривнах и количество");
            str3 = Console.ReadLine();
            tip3 = Console.ReadLine();
            cena3 = double.Parse(Console.ReadLine());
            sht3 = int.Parse(Console.ReadLine());

           
            Console.WriteLine(new string('-', 76));
            Console.WriteLine($"{"| Прайс - лист",-75}|");
            Console.WriteLine(new string('-', 76));
            Console.WriteLine($"{"|Наименование товара",-25}|{"Тип товара",-12}|{"Цена за 1 шт (грн)",-20}|{"Количество",-15}|");
            Console.WriteLine(new string('-', 76));
            Console.WriteLine($"{str1,-25}|{tip1,-12}|{cena1,-20}|{sht1,-15}|");
            Console.WriteLine(new string('-', 76));
            Console.WriteLine($"{str2,-25}|{tip2,-12}|{cena2,-20}|{sht2,-15}|");
            Console.WriteLine(new string('-', 76));
            Console.WriteLine($"{str3,-25}|{tip3,-12}|{cena3,-20}|{sht3,-15}|");
            Console.WriteLine(new string('-', 76));

        }
    }
}
