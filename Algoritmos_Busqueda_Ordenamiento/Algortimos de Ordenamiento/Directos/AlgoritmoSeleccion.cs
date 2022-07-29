using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Busqueda_Ordenamiento.OrdenamientoDirecto
{
    internal class AlgoritmoSeleccion
    {
        public int[] OrdenamientoPorSeleccion(int[] Arreglo)
        {
            int menor, posicion, auxiliar;

            for (int i = 0; i < Arreglo.Length - 1; i++)
            {
                menor = Arreglo[i];
                posicion = i;

                for (int j = i + 1; j < Arreglo.Length; j++)
                {
                    if (Arreglo[j] < menor)
                    {
                        menor = Arreglo[j];
                        posicion = j;
                    }
                }

                if (posicion != i)
                {
                    auxiliar = Arreglo[i];
                    Arreglo[i] = Arreglo[posicion];
                    Arreglo[posicion] = auxiliar;
                }
            }

            return Arreglo;
        }
    }
}
