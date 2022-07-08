using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios16._0
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            double precio;


            Console.WriteLine("pon el precio");
            precio = double.Parse(Console.ReadLine());
            double IVA = (precio * 0.21);

            Console.WriteLine("el precio final: " + (precio + IVA));
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
