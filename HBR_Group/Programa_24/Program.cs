using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // 24) Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los cuatro valores que se
            // encuentran en los vértices de la misma (mat[0][0] etc.)


            cMatriz_24 matriz = new cMatriz_24();
            matriz.Cargar();
            matriz.Imprimir();
            matriz.ImprimirVértices();

            Console.Read();

        }
    }
}
