using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_118
{
    class Program
    {
        static void Main(string[] args)
        {
            // 18) Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de habitantes del
            // mismo. Ordenar alfabéticamente e imprimir los resultados. Por último ordenar con respecto a la
            // cantidad de habitantes (de mayor a menor) e imprimir nuevamente.

            string [,] _paises = new string[5,2];

            Console.WriteLine("Carga de paises y habitantes");
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingese el nombre del pais: ");
                _paises[f, 0] = Console.ReadLine();
                Console.Write("Ingrese la cantidad de habitantes: ");
                _paises[f, 1] = Console.ReadLine();
            }

            for (int k = 0; k < 5; k++)
            {
                for (int f = 0; f < 5 - 1 - k; f++)
                {
                    if (_paises[f,0].CompareTo(_paises[f + 1,0]) > 0)
                    {
                        string auxpais;
                        auxpais = _paises[f, 0];
                        _paises[f, 0] = _paises[f + 1,0];
                        _paises[f + 1,0] = auxpais;
                        string auxhabitante;
                        auxhabitante = _paises[f, 1];
                        _paises[f, 1] = _paises[f + 1, 1];
                        _paises[f + 1, 1] = auxhabitante;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Ordenado Alfabeticamente: \n");

            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(_paises[f, 0] + " - " + _paises[f, 1]);
            }

            for (int k = 0; k < 5; k++)
            {
                for (int f = 0; f < 5 - 1 - k; f++)
                {
                    int value1 = int.Parse(_paises[f, 1]);
                    int value2 = int.Parse(_paises[f + 1, 1]);
                    if (value1  < value2)
                    {
                        string auxpais;
                        auxpais = _paises[f, 0];
                        _paises[f, 0] = _paises[f + 1, 0];
                        _paises[f + 1, 0] = auxpais;
                        string auxhabitante;
                        auxhabitante = _paises[f, 1];
                        _paises[f, 1] = _paises[f + 1, 1];
                        _paises[f + 1, 1] = auxhabitante;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Ordenado por cantidad de habitantes: \n");

            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(_paises[f, 0] + " - " + _paises[f, 1]);
            }

            

            Console.ReadKey();
        }
    }
}
