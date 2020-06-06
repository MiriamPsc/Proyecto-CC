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
        public static string clave3;

        public static void Respuesta3()
        {
            if (clave2 == "LA RESISTENCIA")
            {
                Console.WriteLine(archivo3);
                Console.WriteLine();
                Pregunta4();

            }

            else if (clave1 != "LA RESISTENCIA")
            {

                Console.WriteLine("Empieza por lo que tienes claro. Una de las opciones dice: Nada es correcto, por lo que ninguno de esos números está en la clave.");
                Console.WriteLine("O tal vez no estas escribiendo en mayusculas");
                Console.WriteLine("¿QUIENES SOMOS?:");
                clave2 = (Console.ReadLine());
                Respuesta3();

                if (clave1 != "LA RESISTENCIA")
                {

                    Console.WriteLine("¿Ya la tienes?");
                    Console.WriteLine("¿QUIENES SOMOS?:");
                    clave2 = (Console.ReadLine());
                    Respuesta3();

                    if (clave1 != "LA RESISTENCIA")
                    {

                        Console.WriteLine("Creo que te pudiste dar cuenta de que la clave no va en el recuadro de abajo.");
                        Console.WriteLine("¿Leíste bien los textos anteriores?");
                        Console.WriteLine("¿QUIENES SOMOS?:");
                        clave2 = (Console.ReadLine());
                        Respuesta3();

                    }

                }


            }
        }

        public static void Pregunta4()
        {
            Console.WriteLine("Ahora, para continuar con la siguiente pregunta necesitas tener a la mano la clave que te servirá para llegar a la siguiente prueba.");
            Console.WriteLine();
            clave3 = (Console.ReadLine());
            CuartaParte.Respuesta4();
        }



    }
}
