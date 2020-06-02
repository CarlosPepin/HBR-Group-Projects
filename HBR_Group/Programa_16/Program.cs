using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // 16) Se debe crear un vector donde almacenar 5 sueldos. Ordenar el vector sueldos de menor a mayor.

            float[] vector = { 60000, 70000, 45000, 25000, 75000, 30000, 55000 };
            float numx;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        numx = vector[j];
                        vector[j] = vector[i];
                        vector[i] = numx;
                    }
                }
            }

            for (int k = 0; k < vector.Length; k++)
            {
                Console.WriteLine(vector[k]);
            }
        }
    }
}
