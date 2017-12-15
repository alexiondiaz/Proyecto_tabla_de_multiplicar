using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        //Alexis De Jesus Encarnacion Diaz - Matricula : 11-SISN-1-049
        //Wileidy Yaser Morden Andujar - Matricula : 12-EISN-1-095
        // 

        {
            var nombre = "";
            int numero = 0;

            Console.WriteLine("Hola estimado, cual es su nombre?");

                     nombre = Console.ReadLine();

            Console.WriteLine("Hola "+nombre+", gusto en conocerte");

            Console.WriteLine("Que tabla te gustaria multiplicar?");

            numero = Int32.Parse(Console.ReadLine());

            Program.tablaMultiplicar(numero);

            Console.WriteLine("No olvides reforzar la tabla del 72:");

            Program.tablaMultiplicar(72);

            Console.ReadKey();
        }


        public static void tablaMultiplicar(int b)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(b+" x " + a + " = " + (b * a));
            }
        }
    }
}
