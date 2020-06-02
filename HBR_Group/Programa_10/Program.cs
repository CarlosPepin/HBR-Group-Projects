using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".

            int contador = 0;
            do
            {
                contador++;
                Console.WriteLine(contador);
            } while (contador < 10);
        }
    }
}
