using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace OnAnother
{
    class Juego
    {
        static void Main(string[] args)
        {
            ACII.Imagen();
            ACII.Title();
            Console.ForegroundColor = ConsoleColor.White;
            PrimeraParte.MensajeInicial();
            Console.ReadKey();
        }

    }
}
