using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8) Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("Pulse una tecla para finalizar..."); Console.ReadLine();
        }
    }
}
