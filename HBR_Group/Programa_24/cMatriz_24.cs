using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_24
{
    public class cMatriz_24
    {
        private int fila { get; set; }
        private int columna { get; set; }
        public string[,] matriz { get; set; }

        public void Cargar()
        {
            Console.Write("Defina numero de filas: ");
            this.fila = int.Parse(Console.ReadLine());
            Console.Write("Defina numero de columnas: ");
            this.columna = int.Parse(Console.ReadLine());

            this.matriz = new string[fila, columna];

            Console.WriteLine("Cargando los {0} valores: ", fila * columna);

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    matriz[i, j] = Console.ReadLine();
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine();
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ImprimirVértices()
        {
            Console.WriteLine("Vértice superior izquierda -> {0}", matriz[0, 0]);
            Console.WriteLine("Vértice superior derecha -> {0}", matriz[0, columna - 1]);
            Console.WriteLine("Vértice inferior izquierda -> {0}", matriz[fila - 1, 0]);
            Console.WriteLine("Vértice inferior derecha -> {0}", matriz[fila - 1, columna - 1]);
        }
    }
}
