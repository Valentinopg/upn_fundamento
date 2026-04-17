using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de operaciones");
            Console.WriteLine("1. Calcular el area de un circulo");
            Console.WriteLine("2. Calcular el area de un cuadrado");
            Console.WriteLine("3. Calcular el area de un triangulo");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opcion (1-4)");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Area de un circulo = p*r2");
                    break;

                case 2:
                    Console.WriteLine("Area de un cuadrado = lado2");
                    break;

                case 3:
                    Console.WriteLine("Area de un triangulo = base*altura/2");
                    break;

                case 4:
                    Console.WriteLine("Saliendo del menu");
                    break;
                default:
                    Console.WriteLine("Opcion invalida. Intente del 1 al 4");
                    break;


            }
        }
    }
}
