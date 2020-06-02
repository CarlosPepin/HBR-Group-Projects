using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4) Crear un programa que pida al usuario dos números reales. Si el segundo no es cero, mostrará el
            // resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero,
            // escribirá “Error: No se puede dividir entre cero”.

            while (true)
            {
                try
                {
                    float num1, num2;
                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    num2 = float.Parse(Console.ReadLine());

                    if (num2 != 0)
                    {
                        Console.WriteLine("{0} dividido entre {1} es igual a {2}", num1, num2, num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
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
