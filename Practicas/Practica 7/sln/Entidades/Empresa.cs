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
        public int Id_PersonaContacto { get { return 1; } }
        public int Id_DatosContacto { get { return 1; } }

        public Empresa(string nombre, string cuit)
        {
            Nombre = nombre;
            Cuit = cuit;
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
