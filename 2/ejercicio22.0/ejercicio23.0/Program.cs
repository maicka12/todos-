using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio23._0
{
    internal class program
    {
        static void Main(string[] args)
        {
            string Contraseña;
            int i = 0, J = 0;



            

            do
            {
                Console.WriteLine("ingresa la contraseña ");
                Contraseña = Console.ReadLine();
               
                if (Contraseña == "1234ABCD")
                {
                    J = 1;
                }
                else
                {

                    i++;
                }


            } while (i < 3 && J == 0);
            
            if (J == 1)
            {
                Console.WriteLine("ENHORABUENA");
            }
            else
            {
                Console.WriteLine("has acabado tus 3 intentos");
            }

            Console.ReadKey();

        }
    }
}
