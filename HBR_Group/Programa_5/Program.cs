using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            5) Crear un programa que pida una letra al usuario y diga si se trata de una vocal.

             while (true)
            {
                try
                {
                    Console.Write("Digite una letra: ");
                    string vocales = "aeiou";
                    string letra = Console.ReadLine();

                    if (vocales.Contains(letra))
                    {
                        Console.WriteLine("{0} es una vocal.", letra);
                    }
                    else
                    {
                        Console.WriteLine("{0} no es una vocal.", letra);
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
