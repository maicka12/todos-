using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicio1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int NumV;
            int NumP;
            int resultado;

            Console.WriteLine("introduce el número de ventas");
            NumV = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < NumV; i++)
            {
                Console.WriteLine("introduce el precio de venta"+ (i+1);
                NumP = int.Parse(Console.ReadLine());
                
                Console.WriteLine(resultado = NumV + NumP);
            }
            

        }
    }
}