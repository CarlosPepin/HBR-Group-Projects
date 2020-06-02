using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programa_20
{
    public class cPais
    {
        public string Nombre { get; set; }
        public int[] Temperaturas = new int[3];

       

        public void IngresarDatos()
        {
            Console.Write("Ingrese el nombre del pais: ");
            Nombre = Console.ReadLine();
            for (int j = 1; j < 4; j++)
            {
                Console.Write("\nIngrese la temperatura numero {0} de {1}: ", j, Nombre);
                Temperaturas[j - 1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        public void ImprimirTemperaturasMedias()
        {
            Console.WriteLine("Calculo de las temperaturas medias trimestrales\n");
            Console.WriteLine("{0} -> {1}", Nombre, Temperaturas.Average());

        }
    }
}
