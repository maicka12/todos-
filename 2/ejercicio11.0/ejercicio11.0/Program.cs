using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11._0
{
    internal class Class1
    {
        static void Main(string[] args)
        {
             
            int  A =  Console.WriteLine("pon el primer numero");
                 A =  Convert.ToInt32(Console.ReadLine());



            int B =  Console.WriteLine("pon el segundo numero");
                B =  Convert.ToInt32(Console.ReadLine());




            if (A >= B)
            {
                Console.WriteLine("el A es igual o mas grande que B");
                
            }
            else { Console.WriteLine("el B es igual o mas grande que A"); }

            Console.ReadLine();

        }
    }
}