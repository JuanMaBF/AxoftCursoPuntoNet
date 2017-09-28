using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        public Persona() { ;}
        public Persona(string pNombre, string pApellido, DatosContacto datosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DatosContacto = datosContacto;

        }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //public string Email { get; set; }
        //public string Telefono { get; set; }
        //public string Direccion { get; set; }
        public DatosContacto DatosContacto { get; set; }
    }
}
