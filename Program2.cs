using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 14: Console.WriteLine("Туз"); break;
                case 13: Console.WriteLine("Король"); break;
                case 12: Console.WriteLine("Дама"); break;
                case 11: Console.WriteLine("Валет"); break;
                case 10: Console.WriteLine("Десятка"); break;
                case 9: Console.WriteLine("Девятка"); break;
                case 8: Console.WriteLine("Восьмерка"); break;
                case 7: Console.WriteLine("Семерка"); break;
                case 6: Console.WriteLine("Шестерка"); break;
                default: Console.WriteLine("Вы ошыблись!!!"); break;
            }
            Console.ReadKey();
        }
    }
}
