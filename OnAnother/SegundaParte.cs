using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OnAnother
{
    class SegundaParte  : PrimeraParte
    {
        public static void Respuesta1()
        {
            if (clave1 == "DALI")
            {
                respuesta = @"C:\Users\miria\Desktop\LA CASA DE PAPEL\2.txt";
                archivo3 = File.ReadAllText(respuesta);
                Console.WriteLine(archivo3);
                Console.WriteLine();
                Pregunta2();

            }

            else if (clave1 != "DALI")
            {

                Console.WriteLine("¿No te has percatado que algunas palabras están mal escritas? Quizá uniendo esas letras que faltan conseguimos algo...");
                Console.WriteLine("O tal vez no estas escribiendo en mayusculas");
                Resp1();
            }
        }

        public static void Pregunta2()
        {
            pregunta_2 = @"C:\Users\miria\Desktop\LA CASA DE PAPEL\3.txt";
            archivo4 = File.ReadAllText(pregunta_2);
            Console.WriteLine(archivo4);
            Console.WriteLine();
            Console.WriteLine("¿QUIENES SOMOS?:");
            clave2 = (Console.ReadLine());
            TerceraParte.Respuesta3();
        }


    }
}
