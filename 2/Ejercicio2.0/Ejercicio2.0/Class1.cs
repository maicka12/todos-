using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._0
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("escribe tu nombre");
            string Nombre = Console.ReadLine();

            Console.WriteLine("escribe el nombre de tu ciudad");
            string Ciudad = Console.ReadLine();

            Console.WriteLine("Hola "+ Nombre + " bienvenido a " + Ciudad);
            Console.ReadKey(); 
        }
    }
}
