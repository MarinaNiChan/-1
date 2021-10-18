using System;


namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дробное число");
            double x = double.Parse(Console.ReadLine());

            int d = (int)((x - (int) x)*10);
            Console.WriteLine("Первая цифра из дробной части положительного вещественного числа равна "+ d);

        }
    }
}
