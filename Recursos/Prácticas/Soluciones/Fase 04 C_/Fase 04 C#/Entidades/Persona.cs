using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public Persona() { ;}
        public Persona(string pNombre, string pApellido, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DatosContacto = pDatosContacto;
        }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosContacto DatosContacto { get; set; }
    }
}
