using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosContacto DatosContacto { get; set; }

        public int ID { get; set; }

        public Persona(string nombre, string apellido, DatosContacto datosContacto)
        {
            Nombre = nombre;
            Apellido = apellido;
            DatosContacto = datosContacto;
            ID = 1;
        }
    }
}
