using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // 21) Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila, 2
            // columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila (crearla sin la intervención
            // del operador)
            // Realizar la carga por teclado e imprimir posteriormente.

            cMatriz_21 matriz = new cMatriz_21();
            matriz.Cargar();
            matriz.Imprimir();
        }
    }
}
