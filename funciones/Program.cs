using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones
{
    internal class Program
    {
        // este programa permite calcular operaciones basicas mediante funciones


        /* static void saludar ()
        {
            Console.WriteLine("Hola Mundo!");
        }

        static void despedir (string nombre)
        { 
            Console.WriteLine($"Nos vemos mas tarde, {nombre}");
        }
        */

        static int multiplicar(int num1, int num2)
        {
            return num1 * num2;            

        }

        static int sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        static int dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            // saludar();
            // despedir("carlos");

            /* FUNCION MULTIPLICAR
            int num1, num2;

            num1 = int.Parse(Console.ReadLine());

            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(multiplicar(num1, num2));
            Console.ReadKey();
            */

            /* FUNCIONA SUMAR
            int num1, num2;

            num1 = int.Parse(Console.ReadLine());
            
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(sumar(num1, num2));
            Console.ReadKey();
            */

            /* FUNCION DIVIDIR
            int num1, num2;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(dividir(num1, num2));
            Console.ReadKey();
            */










        }
    }
}
