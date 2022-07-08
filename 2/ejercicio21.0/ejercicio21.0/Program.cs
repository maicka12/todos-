using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21._0
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("elige un dia a la semana");
            string dia = Console.ReadLine();


            switch (dia.ToLower())
            {

                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":

                    Console.WriteLine("es un dia laboral");
                    break;

                case "sabado":
                case "domingo":
                    Console.WriteLine("no es un dia laboral");
                    break;

                default:
                    Console.WriteLine("este dia no es correcto");
                    break;







            }
            Console.ReadLine();

        }
    }
}
