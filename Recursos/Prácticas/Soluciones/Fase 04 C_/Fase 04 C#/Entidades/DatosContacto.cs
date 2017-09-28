using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DatosContacto
    {
        public DatosContacto(string pEmail, string pTelefono, string pDireccion)
        {
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
        }
        
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
