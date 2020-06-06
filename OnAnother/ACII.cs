using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnAnother
{
    class ACII 
    {
        public static void Imagen()
        {
            string dibujo;
            dibujo = @"C:\Users\miria\Desktop\LA CASA DE PAPEL\mask.txt";
            string archivo = File.ReadAllText(dibujo);
            Console.WriteLine(archivo);            
        }

        public static void Title()
        {
            string titulo;
            titulo = @"C:\Users\miria\Desktop\LA CASA DE PAPEL\tit.txt";
            string archivo2 = File.ReadAllText(titulo);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(archivo2);
        }

    }
}
