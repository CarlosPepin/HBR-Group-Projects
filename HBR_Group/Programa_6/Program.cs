using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6) Crear un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo",
            // "Los dos números son positivos" o bien "Ninguno de los números es positivo", según corresponda.

            while (true)
            {
                try
                {
                    int num1, num2;
                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());

                    if (num1 > 0 && num2 > 0)
                    {
                        Console.WriteLine("Los dos números son positivos");
                    }
                    else if (num1 > 0 || num2 > 0)
                    {
                        Console.WriteLine("Uno de los números es positivo");
                    }
                    else
                    {
                        Console.WriteLine("Ninguno de los números es positivo");
                    }
                    Console.Write("Pulse una tecla para finalizar..."); Console.ReadLine();
                    break;
                }
                catch
                {
                    Console.WriteLine("El dato ingresado no es valido\n");
                }
            }
        }
    }
}
