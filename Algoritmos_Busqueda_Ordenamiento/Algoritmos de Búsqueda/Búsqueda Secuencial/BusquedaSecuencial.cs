using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Busqueda_Ordenamiento.Búsqueda_Secuencial
{
    internal class BusquedaSecuencial
    {

        public int BuscarElementoMenor(int[] arreglo)
        {
            int elementoMenor = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] < elementoMenor)
                {
                    elementoMenor = arreglo[i];
                }
            }
            return elementoMenor;
        }

        public int BuscarElementoMayor(int[] arreglo)
        {
            int elementoMayor = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] > elementoMayor)
                {
                    elementoMayor = arreglo[i];
                }
            }
            return elementoMayor;
        }

        public int BuscarPosicionElementoMenor(int[] arreglo)
        {
            int elementoMenor = arreglo[0];
            int posicion = 0;
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] < elementoMenor)
                {
                    elementoMenor = arreglo[i];
                    posicion = i;
                }
            }
            return posicion;
        }

        public int BuscarPosicionElementoMayor(int[] arreglo)
        {
            int elementoMayor = arreglo[0];
            int posicion = 0;
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] > elementoMayor)
                {
                    elementoMayor = arreglo[i];
                    posicion = i;
                }
            }
            return posicion;
        }

        public int BuscarElementoEspecifico(int[] arreglo, int elementoBuscado)
        {
            int indice = -1;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == elementoBuscado)
                {
                    return i;
                }
            }
            return indice;
        }

    }
}
