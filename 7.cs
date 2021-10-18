using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Введите трёхзначное число");
            str1 = Console.ReadLine();

            char[] inputarray = str1.ToCharArray();
            Array.Reverse(inputarray);
            string str2 = new string(inputarray);
            Console.WriteLine("Ваше число "+str2+".");

        }
    }
}
