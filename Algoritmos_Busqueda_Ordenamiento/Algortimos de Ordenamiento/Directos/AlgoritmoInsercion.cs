using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Busqueda_Ordenamiento.OrdenamientoDirecto
{
    internal class AlgoritmoInsercion
    {
        public int[] OrdenamientoPorInsercion(int[] Arreglo)
        {
            int auxiliar;

            for (int i = 1; i < Arreglo.Length; i++)
            {
                auxiliar = Arreglo[i];

                for (int j = i - 1; j >= 0 && Arreglo[j] > auxiliar; j--)
                {
                    Arreglo[j + 1] = Arreglo[j];
                    Arreglo[j] = auxiliar;
                }
            }

            return Arreglo;
        }
    }
}
