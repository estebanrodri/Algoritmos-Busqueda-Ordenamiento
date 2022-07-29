using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Busqueda_Ordenamiento.OrdenamientoIndirecto
{
    internal class AlgoritmoQuickSort
    {
        public int[] OrdenamientoQuickSort(int[] Arreglo)
        {
            Arreglo = QuickSort(Arreglo, 0, Arreglo.Length -1);
            return Arreglo;
        }

        private int[] QuickSort(int[] Arreglo, int PrimerElemento, int UltimoElemento)
        {
            int Indice_i, Indice_j, PuntoMedio;
            double ElementoPivote;
            PuntoMedio = (PrimerElemento + UltimoElemento) / 2;
            ElementoPivote = Arreglo[PuntoMedio];
            Indice_i = PrimerElemento;
            Indice_j = UltimoElemento;
            do
            {
                while (Arreglo[Indice_i] < ElementoPivote) Indice_i++;
                while (Arreglo[Indice_j] > ElementoPivote) Indice_j--;

                if (Indice_i <= Indice_j)
                {
                    int temp;
                    temp = Arreglo[Indice_i];
                    Arreglo[Indice_i] = Arreglo[Indice_j];
                    Arreglo[Indice_j] = temp;
                    Indice_i++;
                    Indice_j--;
                }
            } while (Indice_i <= Indice_j);

            if (PrimerElemento < Indice_j)
            {
                QuickSort(Arreglo, PrimerElemento, Indice_j);
            }
            if (Indice_i < UltimoElemento)
            {
                QuickSort(Arreglo, Indice_i, UltimoElemento);
            }

            return Arreglo;
        }
    }
}
