using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // 15) Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector.

            int[] vector = { 12, 1651, -95, -8, 207, 1205, -95 };
            int vMin = vector.Min();
            Console.WriteLine("{0} es el numero menor del vector.", vMin);
            int contador = 0;
            foreach (var item in vector)
            {
                if (item == vMin)
                {
                    contador++;
                }
            }
            if (contador > 1)
            {
                Console.WriteLine("Dicho numero se repite dentro del vector.");
            }
        }
    }
}
