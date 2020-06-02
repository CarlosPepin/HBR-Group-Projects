using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_21
{
    public class cMatriz_21
    {

        private string[][] mat;

        public void Cargar()
        {
            mat = new string[5][];
            int counter = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                mat[i] = new string[i + 1];
                for (int j = 0; j < mat[i].Length; j++)
                {
                    counter = 1 + counter;
                    Console.Write("Ingrese elemento #{0}: ", counter);
                    mat[i][j] = Console.ReadLine();
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine();
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    Console.Write(mat[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
