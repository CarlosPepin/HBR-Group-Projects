using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3) Crear un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un
            // primer número entero. Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por
            // cualquier número es 0". Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo
            // número y se mostrará el producto de ambos.

            while (true)
            {
                try
                {
                    int num1, num2;
                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = int.Parse(Console.ReadLine());
                    if (num1 != 0)
                    {
                        Console.WriteLine("Ingrese el segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" El producto de {0} por {1} es igual a: {2}.", num1, num2, num1 * num2);
                    }
                    else
                    {
                        Console.WriteLine("El producto de 0 por cualquier número es 0.");
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
