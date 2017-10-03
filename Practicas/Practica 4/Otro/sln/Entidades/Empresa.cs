using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public Persona Contacto { get; set; }

        public Empresa(
            string nombre,
            string cuit,
            Persona contacto,
            string telefono,
            string direccion)
        {
            Nombre = nombre;
            Cuit = cuit;
            Contacto = contacto;
        }

        public override string ToString()
        {
            return
                " Nombre=" + Nombre +
                " Cuit=" + Cuit +
                Contacto.ToString();
        }

    }
}
