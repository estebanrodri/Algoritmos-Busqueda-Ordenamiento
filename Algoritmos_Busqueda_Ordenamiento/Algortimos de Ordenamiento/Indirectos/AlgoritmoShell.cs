using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Busqueda_Ordenamiento.OrdenamientoIndirecto
{
    internal class AlgoritmoShell
    {
        public int[] OrdenamientoShell(int[] Arreglo)
        {
            int salto = 0;
            int sw = 0;
            int Auxiliar = 0;
            int Indice_e = 0;
            salto = Arreglo.Length / 2;

            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    Indice_e = 1;
                    while (Indice_e <= (Arreglo.Length - salto))
                    {
                        if (Arreglo[Indice_e - 1] > Arreglo[(Indice_e - 1) + salto])
                        {
                            Auxiliar = Arreglo[(Indice_e - 1) + salto];
                            Arreglo[(Indice_e - 1) + salto] = Arreglo[Indice_e - 1];
                            Arreglo[(Indice_e - 1)] = Auxiliar;
                            sw = 1;
                        }
                        Indice_e++;
                    }
                }
                salto = salto / 2;
            }

            return Arreglo;
        }
    }
}
