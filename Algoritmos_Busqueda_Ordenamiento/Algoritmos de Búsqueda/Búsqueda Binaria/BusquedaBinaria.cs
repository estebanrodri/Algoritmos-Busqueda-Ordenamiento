using Algoritmos_Busqueda_Ordenamiento.Modelos;
using System;

namespace Algoritmos_Busqueda_Ordenamiento.Búsqueda_Binaria
{
    internal class BusquedaBinaria
    {

        public int BusquedaBinariaIterativa(int[] arreglo, int indice_Izquierda, int indice_Derecha, int ObjetivoBuscado)
        {
            Console.WriteLine("\nInicia Búsqueda Binaria\n");
            int CantidadComparacion = 0;
            while (indice_Izquierda <= indice_Derecha)
            {
                CantidadComparacion++;
                int PuntoMedio = indice_Izquierda + (indice_Derecha - indice_Izquierda) / 2;
                EscribirNumeroDeComparacion(CantidadComparacion, PuntoMedio, ObjetivoBuscado, indice_Izquierda, indice_Derecha);
                if (arreglo[PuntoMedio] == ObjetivoBuscado) return PuntoMedio;
                if (arreglo[PuntoMedio] < ObjetivoBuscado) indice_Izquierda = PuntoMedio + 1;
                else indice_Derecha = PuntoMedio - 1;
            }
            return -1;
        }

        private void EscribirNumeroDeComparacion(int CantidadComparacion, int PuntoMedio, int ObjetivoBuscado, int indice_Izquierda, int indice_Derecha)
        {
            Console.WriteLine("Comparación #" + CantidadComparacion + " - Punto Medio: " + PuntoMedio + " Buscando: "+ ObjetivoBuscado
                                +" en Arreglo [ "+ indice_Izquierda  +" - "+ indice_Derecha +" ]"+ " \n");
        }
        
        public int BusquedaBinariaRecursiva(int[] arreglo, int indice_Izquierda, int indice_Derecha, int ObjetivoBuscado)
        {
            if (indice_Derecha >= indice_Izquierda)
            {
                int PuntoMedio = indice_Izquierda + (indice_Derecha - indice_Izquierda) / 2;
                if (arreglo[PuntoMedio] == ObjetivoBuscado)
                {
                    return PuntoMedio;
                }
                if (arreglo[PuntoMedio] > ObjetivoBuscado)
                {
                    return BusquedaBinariaRecursiva(arreglo, indice_Izquierda, PuntoMedio - 1, ObjetivoBuscado);
                }
                return BusquedaBinariaRecursiva(arreglo, PuntoMedio + 1, indice_Derecha, ObjetivoBuscado);
            }
            return -1;
        }


        public string BusquedaBinariaSobreElPadron(Persona[] Personas, int indice_Izquierda, int indice_Derecha, int ObjetivoBuscado)
        {
            Console.WriteLine("\nInicia Búsqueda Binaria\n");
            int CantidadComparacion = 0;
            while (indice_Izquierda <= indice_Derecha)
            {
                CantidadComparacion++;
                int PuntoMedio = indice_Izquierda + (indice_Derecha - indice_Izquierda) / 2;
                EscribirNumeroDeComparacion(CantidadComparacion, PuntoMedio, ObjetivoBuscado, indice_Izquierda, indice_Derecha);
                if (Convert.ToInt64(Personas[PuntoMedio].Identificacion) == ObjetivoBuscado) return Personas[PuntoMedio].ToString();
                if (Convert.ToInt64(Personas[PuntoMedio].Identificacion) < ObjetivoBuscado) indice_Izquierda = PuntoMedio + 1;
                else indice_Derecha = PuntoMedio - 1;
            }
            return "No encontrado";
        }

    }
}
