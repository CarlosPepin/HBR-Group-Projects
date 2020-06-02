using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7) Crear un programa que use el operador condicional para mostrar un el valor absoluto de un número
            // de la siguiente forma: si el número es positivo, se mostrará tal cual; si es negativo, se mostrará
            // cambiado de signo.

            while (true)
            {
                try
                {
                    Console.Write("Ingrese un numero: ");
                    float numero = float.Parse(Console.ReadLine());

                    if (Math.Sign(numero) == -1)
                    {
                        Console.WriteLine("Numero absoluto de {0} es {1}.", numero, Math.Abs(numero));
                    }
                    else if (Math.Sign(numero) == 1)
                    {
                        Console.WriteLine("Numero ingresado es {0}. No procede calculo.", numero);
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
