using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnAnother
{
    class CuartaParte : TerceraParte
    {
        public static string pregunta5, archivo5, resp5;
        public static void Respuesta4()
        {
            if (clave3 == "648")
            {
               string  respuesta4 = @"C:\Users\miria\Desktop\LA CASA DE PAPEL\4.txt";
                string archivo4 = File.ReadAllText(respuesta4);
                Console.WriteLine(archivo4);
                Console.WriteLine();
                Pregunta5();

            }

            else if (clave3 != "648")
            {

                Console.WriteLine("¿No estás anotando lo que descubres?");
                Console.WriteLine("Recuerda que aquí sí son números.");
                Console.WriteLine();

            }

        }
        public static void Pregunta5()                           
        {
            Console.WriteLine("ESTA ES LA ULTIMA");
            respuesta = @"C:\Users\miria\Desktop\LA CASA DE PAPEL\4.txt";
            archivo3 = File.ReadAllText(respuesta);
            Console.WriteLine("RESPUESTA");
            resp5 = Console.ReadLine();
            Console.WriteLine("");
            QuintaParte.Respuesta5();
        }
    }
}
