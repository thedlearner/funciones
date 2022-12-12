using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        //este programa permite determinar si el valor de un numero es negativo

        static int negativo (int num1)
        {
            if (num1 < 0)
            {
               Console.WriteLine($"{num1} es negativo");
            }

            else
            {
                Console.WriteLine($"{num1} es positivo");
            }

            return num1;
        }

        static void Main(string[] args)
        {
            int num1 = 0;

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine(negativo(num1));

            Console.ReadKey();












        }
    }
}
