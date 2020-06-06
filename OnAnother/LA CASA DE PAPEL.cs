using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnAnother
{
    class Juego
    {
        static void Main(string[] args)
        {

            IColores M = new QuintaParte();
            IMensajes N = new QuintaParte();

            ACII.Imagen();
            ACII.Title();
            M.Color();
            PrimeraParte.MensajeInicial();
            Console.WriteLine(N.Mensaje());
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
