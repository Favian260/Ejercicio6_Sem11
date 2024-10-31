//N00458733
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int relleno;
            char switcher;
            int numeroDeElementos;
            Console.Write("Ingrese el número de elementos del arreglo de números enteros: ");
            numeroDeElementos=int.Parse(Console.ReadLine());

            int[] numeros = new int[numeroDeElementos];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el numero entero de orden {i + 1} en el arreglo: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Recuerda que el número debe ser entero.");
                    Console.Write($"Ingrese el número entero de orden {i + 1} en el arreglo: ");
                }
                Console.WriteLine();
                Console.WriteLine("¿Desea seguir ingresando?");
                Console.WriteLine("[S] para seguir ingresando, [N] para cancelar y motrar numeros o [Otra tecla] para cancelar sin mostrar números.");
                Console.WriteLine();
                switcher = char.ToUpper(Console.ReadKey(true).KeyChar);
                if (switcher == 'S')
                {
                    relleno = 0;
                }
                else if (switcher == 'N')
                {
                    Array.Resize(ref numeros, i+1);
                    imprimir(numeros);
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        static void imprimir(int [] numeros)
        {
            Console.Write("Los numeros ingresados son: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");
            }
            Console.ReadKey();
        }
    }
}
