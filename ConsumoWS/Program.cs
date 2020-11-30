using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoWS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia para consumir los metodos del WS
            Servicios.ServiciosSoapClient wsPropio = new Servicios.ServiciosSoapClient();

            //string cadena = wsPropio.HelloWorld();

            //String cadena = wsPropio.Saludar("Emmanuel");

            //string cadena = wsPropio.GuardarLog("Log desde la consola");

            //string cadena ="El resultado es: "+wsPropio.Multiplicacion(2, 3);

            /* string[] vDeportes = wsPropio.ObtenerDeportes().ToArray();
             foreach(string d in vDeportes)
             {
                 Console.WriteLine("El deporte es: "+d);
             }*/

            /* Servicios.ArrayOfString vDeportes = new Servicios.ArrayOfString()
             {
                 "Box","FutAmericano","Atletismo","Natacion","Maraton"
             };

             string cadena = wsPropio.GuardarVector(vDeportes);*/
            Servicios.Equipos[] vEquipos = wsPropio.ObptenrEquipos();
            foreach(Servicios.Equipos e in vEquipos)
            {
                Console.WriteLine(e.nombreEquipo+" -> "+e.pais);
            }
            //Mostran reultado por consola
           // Console.WriteLine(cadena);
            Console.WriteLine("\n\n-------------------------------------");
            Console.WriteLine("Persione una tecla para finalizar.");
            Console.ReadKey();

        }
    }
}
