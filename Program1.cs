using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine("Введите чило а :");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b :");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число с :");
            c = int.Parse(Console.ReadLine());

            if (a <= b && b <= c)
            {
                Console.WriteLine("Числа a={0} b={1} c={2} возведены в квадрат.", a * a, b * b, c * b);
            }

            else if (a > b && b > c)
            {
                Console.WriteLine("Числа a={0} b={1} c={2} заменины наибольшим из них.", a, b = a, c = a);
            }

            else
                Console.WriteLine("Числа a={0} b={1} c={2} сменилисвой знак", a * -1, b * -1, c * -1);

            Console.ReadKey();



        }
    }
}
