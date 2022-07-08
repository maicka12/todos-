namespace ejercicio_basicos_DDR_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("escribe un dia de la semana");
            string dia = Console.ReadLine();

            switch(dia.ToLower()){

                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                
                Console.WriteLine("no es fin de semana");
                    break;
                
                case "sabado":
                case "domingo":
                Console.WriteLine("es fin de semana");
                    break;

                    default: Console.WriteLine("ese dia es incorrecto");
                    break;

                    
            

            
            }

            Console.ReadLine();

        }
    }
}