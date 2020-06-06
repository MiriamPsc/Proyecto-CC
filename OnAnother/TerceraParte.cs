using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OnAnother
{
    class TerceraParte : SegundaParte 
    {
        public static void Respuesta3()
        {
            if (clave2 == "LA RESISTENCIA")
            {
                respuesta = @"C:\Users\miria\Desktop\LA CASA DE PAPEL\2.txt";
                archivo3 = File.ReadAllText(respuesta);
                Console.WriteLine(archivo3);
                Console.WriteLine();

            }

            else if (clave1 != "LA RESISTENCIA")
            {

                Console.WriteLine("Empieza por lo que tienes claro. Una de las opciones dice: Nada es correcto, por lo que ninguno de esos números está en la clave.");
                Console.WriteLine("O tal vez no estas escribiendo en mayusculas");
                Console.WriteLine("¿QUIENES SOMOS?:");
                clave2 = (Console.ReadLine());

                if (clave1 != "LA RESISTENCIA")
                {

                    Console.WriteLine("¿Ya la tienes?");
                    Console.WriteLine("¿QUIENES SOMOS?:");
                    clave2 = (Console.ReadLine());

                    if (clave1 != "LA RESISTENCIA")
                    {

                        Console.WriteLine("Creo que te pudiste dar cuenta de que la clave no va en el recuadro de abajo.");
                        Console.WriteLine("¿Leíste bien los textos anteriores?.");
                        Console.WriteLine("¿QUIENES SOMOS?:");
                        clave2 = (Console.ReadLine());


                    }

                }


            }
        }
        

    }
}
