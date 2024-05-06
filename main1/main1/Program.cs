using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int cantidadNegativos = 0;
            int cantidadPositivos = 0;

            Console.WriteLine("Ingrese los números (ingrese -99 para terminar):");

            while (true)
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == -99)
                {
                    break;
                }

                if (numero < 0)
                {
                    cantidadNegativos++;
                }
                else
                {
                    cantidadPositivos++;
                }

                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }
            }

            Console.WriteLine($"El máximo valor ingresado es: {maximo}");
            Console.WriteLine($"El mínimo valor ingresado es: {minimo}");
            Console.WriteLine($"Cantidad de números negativos: {cantidadNegativos}");
            Console.WriteLine($"Cantidad de números positivos: {cantidadPositivos}");
        }
    }
}

