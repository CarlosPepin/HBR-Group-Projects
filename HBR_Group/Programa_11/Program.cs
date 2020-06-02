using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo),
            // usando "do..while".

            int contador = 26;
            do
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador--;
            } while (contador > 9);
        }
    }
}
