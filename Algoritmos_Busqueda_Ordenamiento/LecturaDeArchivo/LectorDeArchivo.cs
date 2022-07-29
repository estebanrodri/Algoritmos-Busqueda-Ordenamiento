using Algoritmos_Busqueda_Ordenamiento.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Busqueda_Ordenamiento.LecturaDeArchivo
{
    internal class LectorDeArchivo
    {


        //        CEDULA     |   9   |  1    9 | # cédula del ciudadano               |
        //| CODELEC    |   6   | 10   15 | Código Electoral donde está inscrito |
        //| RELLENO    |   1   | 16   16 |              
        //| FECHACADUC |   8   | 17   24 | Fecha vencimiento de la cédula       |
        //| JUNTA      |   5   | 25   29 | # Junta Receptora de Votos           |
        //| NOMBRE     |  30   | 30   59 | Nombre completo del ciudadano        |
        //| 1.APELLIDO |  26   | 60   85 | Primer apellido                      |
        //| 2.APELLIDO

        public Persona[] LeerDatosDelPadron()
        {
            string Archivo = @"C:\PADRON_COMPLETO.txt";  
            IEnumerable<string> LineasDelArchivo = File.ReadLines(Archivo);
            Console.WriteLine("Cantidad de Personas en el Padrón : " + LineasDelArchivo.Count());
            Persona[] Personas = new Persona[LineasDelArchivo.Count()];
            int i = 0;

            Console.WriteLine("Cargando Datos del Padrón Nacional TSE ...");
            foreach (string Linea in LineasDelArchivo)
            {
                string [] valores = Linea.Split(',');

                Personas[i] = new Persona()
                {
                    Identificacion = valores[0].Trim(),
                    CodigoElectoral = valores[1].Trim(), // Relleno 2
                    FechaVencimientoCedula = valores[3].Trim(),
                    JuntaReceptoraVotos = valores[4].Trim(),
                    Nombre = valores[5].Trim(),
                    PrimerApellido = valores[6].Trim(),
                    SegundoApellido = valores[7].Trim(),
                };
                i++;
            }
            Console.WriteLine("Archivo PADRON_COMPLETO.txt cargado completamente");
            return Personas;
        }
        
    }
}
