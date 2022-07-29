using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Busqueda_Ordenamiento.OrdenamientoDirecto
{
    internal class AlgoritmoBurbuja
    {

        public int[] OrdenamientoBurbuja(int[] Arreglo)
        {
            int UltimoIndice = Arreglo.Length -1;
            for(int i = UltimoIndice; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Arreglo[j] > Arreglo[j+1])
                    {
                        IntercambiarPosicion(Arreglo, j, j+1);
                    }
                }
            }

            return Arreglo;
        }

        private void IntercambiarPosicion(int[] Arreglo, int Posicion1, int Posicion2)
        {
            int Auxiliar = Arreglo[Posicion1];
            Arreglo[Posicion1] = Arreglo[Posicion2];
            Arreglo[Posicion2] = Auxiliar;
            // (Arreglo[Posicion2], Arreglo[Posicion1]) = (Arreglo[Posicion1], Arreglo[Posicion2]);
        }

        public int[] OrdenamientoBurbujaMejorado(int[] Arreglo)
        {
            int UltimoIndice = Arreglo.Length - 1;
            bool hayIntercambios = true;
            for (int i = UltimoIndice; i > 0 && hayIntercambios; i--)
            {
                hayIntercambios = false;
                for (int j = 0; j < i; j++)
                {
                    if (Arreglo[j] > Arreglo[j + 1])
                    {
                        hayIntercambios = true;
                        IntercambiarPosicion(Arreglo, j, j + 1);
                    }
                }
            }

            return Arreglo;
        }
           

    }
}
