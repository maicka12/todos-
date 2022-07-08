using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciocio4._0
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("dame el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dame el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("El primer numero es igual o superior al segundo" );
            } else 
            { Console.WriteLine("El segundon numero es igual o superior al primero"); }

            Console.ReadLine();
        }
    }
}
