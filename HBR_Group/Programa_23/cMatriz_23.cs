using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_23
{
    public class cMatriz_23
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
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Intercambio()
        {
            for (int i = 0; i < columna; i++)
            {
                string value = matriz[0, i];
                matriz[0, i] = matriz[1, i];
                matriz[1, i] = value;
            }
        }
    }
}
