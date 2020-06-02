using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //23) Crear una matriz de n* m filas(cargar n y m por teclado) Intercambiar la primer fila con la segundo.
            // Imprimir luego la matriz.

            cMatriz_23 matriz = new cMatriz_23();
            matriz.Cargar();

            Console.WriteLine("Matriz Original:");
            matriz.Imprimir();

            matriz.Intercambio();

            Console.WriteLine("Matriz Modificada:");
            matriz.Imprimir();

            Console.ReadKey();
        }
    }
}
