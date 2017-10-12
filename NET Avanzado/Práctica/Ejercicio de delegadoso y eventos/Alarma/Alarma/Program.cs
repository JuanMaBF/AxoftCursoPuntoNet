using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarma
{
    class Program
    {
        public static PermitirAcceso validator;
        public static PermitirAcceso validator1;
        public static PermitirAcceso validator2;
        public static PermitirAcceso validator3;

        static void Main(string[] args)
        {
            string nombre = "";
            validator = ChequearNombre;
            while (validator(nombre))
            {
                Console.WriteLine("Escriba su nombre:");
                nombre = Console.ReadLine();
                if (!validator(nombre))
                {
                    Console.WriteLine("Tomate el palo...👊");
                    Console.ReadLine();
                }
            }

        }

        public delegate bool PermitirAcceso(string nombre);

        public static bool ChequearNombre(string nombre)
        {
            return (nombre != "Jack" && nombre != "Steven" && nombre != "Mathew");
        }

    }
}
