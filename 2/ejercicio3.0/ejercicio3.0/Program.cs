using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3._2
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cual es tu nombre?");
            string nombre = Console.ReadLine();
           
            Console.WriteLine("Cual es edad?");
            string  edad = Console.ReadLine();
            
            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad);


        }
    }
}
