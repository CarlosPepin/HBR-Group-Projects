using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_01
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1) El usuario tecleará dos números(x e y), y el programa deberá calcular cual es el resultado de su
           // división y el resto de esa división.

             while (true)
            {
                try
                {
                    float num1, num2;
                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("La division entre {0} y {1} es igual a {2} y su resto es igual a {3}", num1, num2, num1 / num2, num1 % num2);
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
