using Algoritmos_Busqueda_Ordenamiento.Búsqueda_Binaria;
using Algoritmos_Busqueda_Ordenamiento.Búsqueda_Secuencial;
using Algoritmos_Busqueda_Ordenamiento.LecturaDeArchivo;
using Algoritmos_Busqueda_Ordenamiento.Modelos;
using Algoritmos_Busqueda_Ordenamiento.OrdenamientoDirecto;
using Algoritmos_Busqueda_Ordenamiento.OrdenamientoIndirecto;
using System;

namespace Algoritmos_Busqueda_Ordenamiento
{
    internal class Consola
    {
        static void Main(string[] args)
        {
            Consola consola = new Consola();
            /* Algoritmos de Búsqueda*/
           // consola.BusquedaSecuencial(); // Lineal O(n)
            //consola.BusquedaBinaria();    // Logarítmitca log2(n)
            consola.BuscarDatosEnElPadron();
            /* Algoritmos de Ordenamiento Directo*/
            //consola.OrdenamientoBurbuja();  // Cuadrática O(n2)
            //consola.OrdenamientoPorSeleccion();
            //consola.OrdenamientoPorInsercion();
            
            
            
            
            
            /* Algoritmos de Ordenamiento Indirecto (Avanzados)*/
            //consola.OrdenamientoShell(); // Logarítmitca log2(n)
            //consola.OrdenamientoQuickSort(); // Logarítmitca log2(n)
            //consola.OrdenamientoMezcla();  // Logarítmitca log2(n)
            //consola.OrdenamientoRadixSort();  // Logarítmitca log2(n)




            Console.ReadLine();
        }

        /* Algoritmos de Búsqueda*/
        private void BusquedaSecuencial() // Lineal O(n)
        {
            BusquedaSecuencial busquedaSecuencial = new BusquedaSecuencial();
            int[] ElementosNumericos = {3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Búsqueda Secuencial sobre un Arreglo Numérico " );
            Console.WriteLine("Arreglo Numérico\n"+ ArregloNumericoTexto);

            Console.WriteLine("El Elemento Mayor en la secuencia númerica es: "+ busquedaSecuencial.BuscarElementoMayor(ElementosNumericos));
            Console.WriteLine("El Elemento Mayor se encuentra en el índice: " + busquedaSecuencial.BuscarPosicionElementoMayor(ElementosNumericos));
            Console.WriteLine("El Elemento Menor en la secuencia númerica es: " + busquedaSecuencial.BuscarElementoMenor(ElementosNumericos));
            Console.WriteLine("El Elemento Menor se encuentra en el índice: " + busquedaSecuencial.BuscarPosicionElementoMenor(ElementosNumericos));

            int elementoEspecifico = 25;
            int indice = busquedaSecuencial.BuscarElementoEspecifico(ElementosNumericos, elementoEspecifico);
            string resultadoBusqueda = indice == -1 ? "No encontrado": indice.ToString();
            string resultadoDeBusquedaEspecifica = 
                string.Format("El Elemento {0} se encuentra en el índice: {1}", elementoEspecifico, resultadoBusqueda);
            Console.WriteLine(resultadoDeBusquedaEspecifica);

        }

        private void BusquedaBinaria() // Logarítmitca log2(n)
        {
            BusquedaBinaria busquedaBinaria = new BusquedaBinaria();
            int[] ElementosNumericos = { 2, 3, 4, 5, 8, 10, 25, 67, 89, 90, 120 };
            string ArregloNumericoTexto = "Valores: { 2  3  4   5   8  10  25  67  89  90  120 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8   9    10 ]\n";
            Console.WriteLine("Búsqueda Logarítmitca sobre un Arreglo Numérico ");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto);

            int elementoEspecifico = 89;
            Console.WriteLine("Elemento a Buscar: " + elementoEspecifico+ " \n");
            int indice = busquedaBinaria.BusquedaBinariaIterativa(ElementosNumericos, 0, ElementosNumericos.Length -1 ,elementoEspecifico);
            string resultadoBusqueda = indice == -1 ? "No encontrado" : indice.ToString();
            string resultadoDeBusquedaEspecifica =
                string.Format("El Elemento {0} se encuentra en el índice: {1}", elementoEspecifico, resultadoBusqueda);
            Console.WriteLine(resultadoDeBusquedaEspecifica);
        }

        private void BuscarDatosEnElPadron()
        {
            LectorDeArchivo lectorDeArchivo = new LectorDeArchivo();
            Persona[] Personas = lectorDeArchivo.LeerDatosDelPadron();
            BusquedaBinaria busquedaBinaria = new BusquedaBinaria();

            int elementoEspecifico = 207560596; // 101075138
            Console.WriteLine("\nElemento a Buscar: " + elementoEspecifico + " \n");
            string resultadoBusqueda = busquedaBinaria.BusquedaBinariaSobreElPadron(Personas, 0, Personas.Length - 1, elementoEspecifico);
            string resultadoDeBusquedaEspecifica =
                string.Format("Persona buscada con la identificación {0} Resultado: {1}", elementoEspecifico, resultadoBusqueda);
            Console.WriteLine(resultadoDeBusquedaEspecifica);
        }

        /* Algoritmos de Ordenamiento Directo*/
        private void OrdenamientoBurbuja() // Cuadrática O(n2)
        {
            AlgoritmoBurbuja algoritmoBurbuja = new AlgoritmoBurbuja();
            int[] ElementosNumericos = { 3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Ordenamiento Mediante el Algoritmo de Burbuja ");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto + "\n");

            Console.WriteLine("Arreglo Ordenado: ");
            int[] ElementosNumericosOrdenados = algoritmoBurbuja.OrdenamientoBurbuja(ElementosNumericos);
            Console.WriteLine(ObtenerResultado(ElementosNumericosOrdenados));
        }

        private void OrdenamientoBurbujaMejorado() // Cuadrática O(n2)
        {
            AlgoritmoBurbuja algoritmoBurbuja = new AlgoritmoBurbuja();
            int[] ElementosNumericos = { 3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Ordenamiento Mediante el Algoritmo de Burbuja Mejorado");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto + "\n");

            Console.WriteLine("Arreglo Ordenado: ");
            int[] ElementosNumericosOrdenados = algoritmoBurbuja.OrdenamientoBurbujaMejorado(ElementosNumericos);
            Console.WriteLine(ObtenerResultado(ElementosNumericosOrdenados));
        }

        private void OrdenamientoPorSeleccion() // Cuadrática O(n2)
        {
            AlgoritmoSeleccion algoritmoBurbuja = new AlgoritmoSeleccion();
            int[] ElementosNumericos = { 3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Ordenamiento Mediante el Algoritmo de Burbuja ");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto + "\n");

            Console.WriteLine("Arreglo Ordenado: ");
            int[] ElementosNumericosOrdenados = algoritmoBurbuja.OrdenamientoPorSeleccion(ElementosNumericos);
            Console.WriteLine(ObtenerResultado(ElementosNumericosOrdenados));
        }

        private void OrdenamientoPorInsercion() // Cuadrática O(n2)
        {
            AlgoritmoInsercion algoritmoBurbuja = new AlgoritmoInsercion();
            int[] ElementosNumericos = { 3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Ordenamiento Mediante el Algoritmo de Burbuja ");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto + "\n");

            Console.WriteLine("Arreglo Ordenado: ");
            int[] ElementosNumericosOrdenados = algoritmoBurbuja.OrdenamientoPorInsercion(ElementosNumericos);
            Console.WriteLine(ObtenerResultado(ElementosNumericosOrdenados));
        }

        /* Algoritmos de Ordenamiento Indirecto (Avanzados)*/
        private void OrdenamientoShell() //  // Logarítmitca log2(n)
        {
            AlgoritmoShell algoritmoBurbuja = new AlgoritmoShell();
            int[] ElementosNumericos = { 3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Ordenamiento Mediante el Algoritmo Shell ");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto + "\n");

            Console.WriteLine("Arreglo Ordenado: ");
            int[] ElementosNumericosOrdenados = algoritmoBurbuja.OrdenamientoShell(ElementosNumericos);
            Console.WriteLine(ObtenerResultado(ElementosNumericosOrdenados));
        }

        private void OrdenamientoQuickSort() //  // Logarítmitca log2(n)
        {
            AlgoritmoQuickSort algoritmoBurbuja = new AlgoritmoQuickSort();
            int[] ElementosNumericos = { 3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Ordenamiento Mediante el Algoritmo QuickSort ");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto + "\n");

            Console.WriteLine("Arreglo Ordenado: ");
            int[] ElementosNumericosOrdenados = algoritmoBurbuja.OrdenamientoQuickSort(ElementosNumericos);
            Console.WriteLine(ObtenerResultado(ElementosNumericosOrdenados));
        }

        private void OrdenamientoMezcla() //  // Logarítmitca log2(n)
        {
            AlgoritmoMezcla algoritmoBurbuja = new AlgoritmoMezcla();
            int[] ElementosNumericos = { 3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Ordenamiento Mediante el Algoritmo MergeSort ");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto + "\n");

            Console.WriteLine("Arreglo Ordenado: ");
            int[] ElementosNumericosOrdenados = algoritmoBurbuja.OrdenamientoPorMezcla(ElementosNumericos);
            Console.WriteLine(ObtenerResultado(ElementosNumericosOrdenados));
        }

        private void OrdenamientoRadixSort() // // Logarítmitca log2(n)
        {
            AlgoritmoRadixSort algoritmoBurbuja = new AlgoritmoRadixSort();
            int[] ElementosNumericos = { 3, 5, 8, 10, 25, 90, 120, 2, 4, 67, 89 };
            string ArregloNumericoTexto = "Valores: { 3  5  8  10  25  90  120  2  4  67  89 }\n" +
                                          "Índices: [ 0  1  2   3   4   5   6   7  8  9   10 ]\n";
            Console.WriteLine("Ordenamiento Mediante el Algoritmo RadixSort ");
            Console.WriteLine("Arreglo Numérico\n" + ArregloNumericoTexto + "\n");

            Console.WriteLine("Arreglo Ordenado: ");
            int[] ElementosNumericosOrdenados = algoritmoBurbuja.OrdenamientoRadixSort(ElementosNumericos);
            Console.WriteLine(ObtenerResultado(ElementosNumericosOrdenados));
        }

        private string ObtenerResultado(int[] ElementosNumericosOrdenados)
        {
            string Resultado = "Valores: { " + ElementosNumericosOrdenados[0];
            for (int i = 1; i < ElementosNumericosOrdenados.Length; i++)
            {
                Resultado += string.Format(", {0}", ElementosNumericosOrdenados[i]);
            }
            Resultado += " }\n" +
                "Índices: [ 0  1  2  3  4  5   6   7   8   9    10 ]";

            return Resultado;
        }


    }
}
