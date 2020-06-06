using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnAnother
{
    class ACII : Juego
    {
        public static void Imagen()
        {
            string dibujo, titulo;
            dibujo = @"C:\Users\miria\Downloads\mask.txt";
            string archivo = File.ReadAllText(dibujo);
            Console.WriteLine(archivo);
            titulo = @"C:\Users\miria\Downloads\tit.txt";
            string archivo2 = File.ReadAllText(titulo);
            Console.WriteLine(archivo2);
        }

    }
}
