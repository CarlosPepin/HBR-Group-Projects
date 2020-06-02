using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2) Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del
            // segundo (pista: igual que antes, habrá que ver si el resto de la división es cero: a % b == 0).

            while (true)
            {
                try
                {
                    int num1, num2;
                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());

                    if (num1 % num2 == 0)
                    {
                        Console.WriteLine("{0} es multiplo de {1}", num1, num2);
                    }
                    else if (num1 % num2 != 0)
                    {
                        Console.WriteLine("{0} NO es multiplo de {1}", num1, num2);
                    }
                    Console.Write("Pulse una tecla para finalizar..."); Console.ReadLine();
                    break;
                }
                catch
                {
                    Console.WriteLine("El dato ingresado no es un numero valido\n");
                }
            }
        }
    }
}
