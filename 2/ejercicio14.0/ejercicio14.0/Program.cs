using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14._0
{
    internal class Class1
    {
        static void Main(string[] args)
        {


            double r, a;
            double PI = 3.1416;

            Console.Write("valor del radio: ");
            r = double.Parse(Console.ReadLine());


            a = PI * Math.Pow(r, 2);


            Console.WriteLine("el area es de: " + a);
            Console.ReadKey();
        }
    }
}
