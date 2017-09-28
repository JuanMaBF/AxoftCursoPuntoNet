using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Vendedor : Persona
    {
        public Vendedor(string pNombre, string pApellido, string pDNI, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = pDNI;
            this.DatosContacto = pDatosContacto;
        }
        
        public string DNI { get; set; }
    }
}
