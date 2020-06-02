using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando
            // "while".

            int contador = 26;
            while (contador != 9)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador--;
            }
        }
    }
}
