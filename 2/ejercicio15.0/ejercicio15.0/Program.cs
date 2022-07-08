using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15._0
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            double a = 0;

            Console.WriteLine("agrega un numero");
            a = double.Parse(Console.ReadLine());


            if (a % 2 == 0)
            {
                Console.WriteLine("si es divisible");
            }

            else
            {
                Console.WriteLine("no lo es");
            }

            Console.ReadKey();
        }
    }
}