using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // 17) Definir un vector donde almacenar los nombres de 5 países. Confeccionar el algoritmo de
            // ordenamiento alfabético.

            string[] paises = { "Republica Dominicana", "Cuba", "Puerto Rico", "Jamaica", "Haiti" };
            Comparison<string> comparador = new Comparison<string>((x, y) => x.CompareTo(y));
            Array.Sort<string>(paises, comparador);

            for (int k = 0; k < paises.Length; k++)
            {
                Console.WriteLine(paises[k]);
            }
        }
    }
}
