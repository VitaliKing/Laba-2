using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите возраст:");
            a = int.Parse(Console.ReadLine());

            if ( a <= 1) 
            {
                Console.WriteLine("Младенец");
            }
            if (a > 1 && a < 11)
            {
             Console.WriteLine("Ребенок");
            }
            if (a > 12 && a < 15)
            {
                Console.WriteLine("Подросток");
            }
            if (a > 16 && a < 25)
            {
                Console.WriteLine("Юноша");
            }
            if (a > 26 && a < 70)
            {
                Console.WriteLine("Мужчина");
            }
            if (a > 70 )
            {
                Console.WriteLine("Старик");
            }
               

            Console.ReadKey();
        }
    }
}
