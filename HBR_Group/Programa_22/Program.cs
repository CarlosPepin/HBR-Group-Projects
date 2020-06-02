using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // 22) Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
            // Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz irregular para
            // cargar los días que han faltado cada empleado (cargar el número de día que faltó)
            // Cada fila de la matriz representan los días de cada empleado.
            // Mostrar los empleados con la cantidad de inasistencias.
            // Cuál empleado faltó menos días.

            c_22 obj = new c_22();
            obj.Cargar();
            obj.Imprimir();
            obj.MenosInasistencias();

            Console.Write("\nPulse una tecla para finalizar..."); Console.ReadLine();

        }
    }
}
