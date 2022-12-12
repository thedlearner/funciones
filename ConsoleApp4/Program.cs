using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        // este algoritmo utiliza una funcion para ingresar un numero de numeros a sumar, luego los suma y retorna el resultado de la suma
        static int sumatoria (int num, int nums, int suma)
        {
            for (int i=0;i<nums;i++)
            {
                Console.WriteLine("ingrese los numeros");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
            }

            return suma;

        }


        static void Main(string[] args)
        {
            int num = 0, nums = 0, suma = 0;

            Console.WriteLine("ingrese el numero de numeros a sumar");
            nums = int.Parse(Console.ReadLine());

            Console.WriteLine(sumatoria(num, nums, suma));
            
            Console.ReadKey();



        }
    }
}
