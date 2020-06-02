using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // 19) Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna (es decir
            // primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)
            // Imprimir luego la matriz.

            string[,] matriz = new string[2, 5];

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    Console.WriteLine("Ingresando en posicion {0},{1}", j, i);
                    matriz[j - 1, i - 1] = Console.ReadLine();
                }
            }
            Console.WriteLine();

            //Imprimir
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
