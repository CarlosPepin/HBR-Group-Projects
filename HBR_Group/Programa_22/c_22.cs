using System;
using System.Collections.Generic;

namespace Programa_22
{
    public class c_22
    {
        public string[] nombres = new string[3];
        public int[][] dias = new int[3][];

        public void Cargar(){

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese nombre del empleado: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Cuantos dias falto?: ");
                int numDias = int.Parse(Console.ReadLine());

                dias[i] = new int[numDias];
                for (int j = 0; j < numDias; j++)
                {
                    Console.Write("Indique dia: ");
                    dias[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine();
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("El empleado de nombre {0} ha inasistido {1} veces", nombres[i], dias[i].Length);
            }
        }

        public void MenosInasistencias()
        {
            Console.WriteLine();
            int menos = dias[0].Length;
            string _nombre = nombres[0];
            for (int i = 0; i < 3; i++)
            {
                if (dias[i].Length < menos)
                {
                    menos = dias[i].Length;
                    _nombre = nombres[i];
                }
            }

            Console.WriteLine("{0} es el empleado que menos ha inasistido con {1} inasistencias.", _nombre, menos);
        }

    }
}