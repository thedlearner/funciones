using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        // este algoritmo permite ingresar 3 valores x, y, z y luego calcular el valor de las ecuaciones llamandolas a traves de las funciones ecuacion1 y ecuacion2

        static int ecuacion1 (int x, int y, int z)
        {
            return x + y + z;
        }

        static int ecuacion2 (int x, int y, int z)
        {
            return 3*x + 5*y + z * z;

        }

        static void Main(string[] args)
        {
            int x, y, z, NumEcuacion;

            Console.WriteLine("ingrese los valores de x, y, z");

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de operacion");

            NumEcuacion = int.Parse(Console.ReadLine());

            if (NumEcuacion == 1)
            {
            Console.WriteLine(ecuacion1(x, y, z));

            }

            else
            {
            Console.WriteLine(ecuacion2(x, y, z));

            }

            Console.ReadKey();



        }
    }
}
