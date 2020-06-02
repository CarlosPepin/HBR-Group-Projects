using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13) Crear un programa que muestre los primeros ocho números pares (pista: en cada pasada habrá que
            // aumentar de 2 en 2, o bien mostrar el doble del valor que hace de contador).

            int contador = 0;
            while (contador < 8)
            {
                contador++;
                Console.WriteLine(contador * 2);
            }
        }
    }
}
