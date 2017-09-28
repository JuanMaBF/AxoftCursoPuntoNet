using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empresa
    {
        public Empresa() { ;}
        public Empresa(string pNombre, string pCUIT, Persona pContacto, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
            this.DatosContacto = pDatosContacto;
        }
        
        public string Nombre {get; set;}
        public string CUIT { get; set; }
        public Persona Contacto { get; set; }
        public DatosContacto DatosContacto { get; set; }
    }
}
