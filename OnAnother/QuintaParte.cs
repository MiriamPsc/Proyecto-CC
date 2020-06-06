using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnAnother    
{
    class QuintaParte : CuartaParte
    {
        public static void Respuesta5()
        {
            if (resp5 == "34655854")
            {
                Final();
            }

            else if (resp5 != "34655854")
            {
                Console.WriteLine("Comienzo a creer que no te mereces el premio.");
                Console.WriteLine("RESPUESTA:");
                resp5 = Console.ReadLine();
                Respuesta5();
            }

        }

        public static void Final()
        {
            Console.WriteLine("Separa la respuesta en 4 numeros.");
            Console.WriteLine("Parecen coordenadas, no?");
            Console.WriteLine("Se notificará a mi contacto que has completado el reto,");
            Console.WriteLine("Se pondrá en contacto contigo cuando sea seguro. EXITO, Y FELICIDADES.");
            Console.WriteLine("");
            Console.WriteLine("El profesor.");
            
        }
    }
}
