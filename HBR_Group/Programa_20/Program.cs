using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_20
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 20) Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como dato las
            // temperaturas medias mensuales de dichos paises.

            // Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.

            // Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.        

            // aDONE - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales. 
            // bDONE - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
            // cDODE - Calcular la temperatura media trimestral de cada país.
            // eDONE - Imprimr los nombres de las provincias y las temperaturas medias trimestrales.
            // f - Imprimir el nombre de la provincia con la temperatura media trimestral mayor.

            
            List<cPais> ListaPaises = new List<cPais>();

            for (int i = 1; i < 5; i++)
            {
                cPais pais = new cPais();
                Console.WriteLine("Pais #{0}", i);
                pais.IngresarDatos();
                ListaPaises.Add(pais);
            }

            foreach (var item in ListaPaises)
            {
                Console.Write("\nNombre: {0}, Temperaturas:", item.Nombre); 
                item.Temperaturas.ToList().ForEach(i => Console.Write(" " + i.ToString() + "°C"));
                Console.Write("\nTemp. Medias: {0}\n", item.Temperaturas.Average());
            }

            foreach (var item in ListaPaises)
            {
                var maxValue = item.Temperaturas.Average();
                if (maxValue < item.Temperaturas.Average())
                {
                    maxValue = item.Temperaturas.Average();

                }
            }

            //Console.WriteLine("{0} es el pais con la mayor temperatura media trimestral" +
            //    "\n con un valor de {1}°C", maxPais);

            


            Console.Write("\nPulse una tecla para finalizar..."); Console.ReadLine();
        }
    }
}
