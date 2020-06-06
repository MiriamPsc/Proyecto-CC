using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnAnother
{
    class PrimeraParte
    {
        public static string dibujo, archivo, titulo, archivo2, clave1, respuesta, archivo3, pregunta_2, archivo4, clave2;

        public static void MensajeInicial()
        {

            dibujo = @"C:\Users\miria\source\repos\OnAnother\LA CASA DE PAPEL\NOTAS.txt";
            archivo = File.ReadAllText(dibujo);
            Console.WriteLine(archivo);

            titulo = @"C:\Users\miria\source\repos\OnAnother\LA CASA DE PAPEL\INICIO.txt";
            archivo2 = File.ReadAllText(titulo);
            Console.WriteLine(archivo2);
            Resp1();
        }
        
        public static void Resp1()
        {
            Console.WriteLine("CLAVE:");
            clave1 = (Console.ReadLine());
            Console.WriteLine();
            SegundaParte.Respuesta1();

        }
    }
}
