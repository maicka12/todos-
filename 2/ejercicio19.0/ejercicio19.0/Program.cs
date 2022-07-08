using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19._0
{
    internal class Class1
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            
            Console.ReadLine();
        }
    }
}
