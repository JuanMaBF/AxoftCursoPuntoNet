using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Vendedor : Persona
    {
        public Vendedor(string pNombre, string pApellido, string pDNI,DatosContacto datosContacto):base(pNombre, pApellido, datosContacto)
        {
           this.DNI = pDNI;
        }
        
        public string DNI { get; set; }
    }
}
