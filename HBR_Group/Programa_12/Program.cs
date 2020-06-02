using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12) Crear un programa que muestre los números del 15 al 5, descendiendo (pista: en cada pasada habrá
            // que descontar 1, por ejemplo haciendo i=i-1, que se puede abreviar i--).

            for (int i = 15; i > 4; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
