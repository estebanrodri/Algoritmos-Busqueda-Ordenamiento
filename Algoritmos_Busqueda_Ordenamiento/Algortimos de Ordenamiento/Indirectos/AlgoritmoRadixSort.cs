using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Busqueda_Ordenamiento.OrdenamientoIndirecto
{
    internal class AlgoritmoRadixSort
    {
        public int[] OrdenamientoRadixSort(int[] Arreglo)
        {
            int n = Arreglo.Length;
            int max = Arreglo[0];

            //find largest element in the Array
            for (int i = 1; i < n; i++)
            {
                if (max < Arreglo[i])
                    max = Arreglo[i];
            }

            //Counting sort is performed based on place. 
            //like ones place, tens place and so on.
            for (int place = 1; max / place > 0; place *= 10)
                countingsort(Arreglo, place);

            return Arreglo;
        }


        static void countingsort(int[] Array, int place)
        {
            int n = Array.Length;
            int[] output = new int[n];

            //range of the number is 0-9 for each place considered.
            int[] freq = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //count number of occurrences in freq array
            for (int i = 0; i < n; i++)
                freq[(Array[i] / place) % 10]++;

            //Change count[i] so that count[i] now contains actual 
            //position of this digit in output[] 
            for (int i = 1; i < 10; i++)
                freq[i] += freq[i - 1];

            //Build the output array 
            for (int i = n - 1; i >= 0; i--)
            {
                output[freq[(Array[i] / place) % 10] - 1] = Array[i];
                freq[(Array[i] / place) % 10]--;
            }

            //Copy the output array to the input Array, Now the Array will 
            //contain sorted array based on digit at specified place
            for (int i = 0; i < n; i++)
                Array[i] = output[i];
        }


    }
}
