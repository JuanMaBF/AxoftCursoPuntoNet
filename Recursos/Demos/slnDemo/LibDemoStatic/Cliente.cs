using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDemoStatic
{
    public class Cliente
    {

        public Cliente(string nombre)
        {
            Nombre = nombre;
            instancias++;
        }
        public string Nombre { get; set; }

        private static int instancias=0;
        public static  int Instancias
        {
            get { return instancias; }
           
        }

    }
}
