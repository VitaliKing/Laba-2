using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите свой возраст:");
            a = int.Parse(Console.ReadLine());

            if (a >= 18 && a <= 27)
            {
                Console.WriteLine("Вы подлежите призыву на срочную службу или можете служить по контракту");
            }
            if (a >= 28 && a <= 59)
            {
                Console.WriteLine("Вы можете служить по контракту");
            }
            if (a < 18 || a > 59 && a < 100) 
            {
                Console.WriteLine("Вы в непризывном возрасте");
            }
            if (a < 0 || a > 100) 
            {
                Console.WriteLine("Ошибка!!!");
            }

            Console.ReadKey();
        }
    }
}
