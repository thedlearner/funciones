using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        // este algoritmo retornara 1 si el numero ingresado es igual a 0 y 0 si es diferente a 0

        static int funcion1(int num1)
        {

            if (num1 == 0)
            {
                Console.WriteLine($"1, {num1} es igual a cero");
            }

            else
            {
                Console.WriteLine($"0, {num1} es diferente de cero");
            }

            return num1;

        }

        static void Main(string[] args)
        {
            int num1 = 0;

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine(funcion1(num1));

            Console.ReadKey();
        }
    }
}
