using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6._0
{
    internal class Class1
    {
        static void Main(string[]args)
        {
            Console.WriteLine("pon el precio");
            double precio = Console.ReadLine();

            Console.WriteLine("escribe la forma de pago: tarjeta o efectivo");
            string forma = (Console.ReadLine()).ToLower();

            if (forma.Equals("tarjeta"))
            {
                Console.WriteLine("Introduce el numero de tarjeta");
                int numero_cuenta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("el producto con precio" + precio + " se ha pagado " + " con el numero de cuenta " + numero_cuenta);
            }
            else if(forma.Equals ("efectivo")) {

                Console.WriteLine("el producto con precio " + precio + " se ha pagado");
            }
            else
            {
                Console.WriteLine("la forma de pago no es correcta");
            }

            Console.ReadLine();
        }



    }
}
