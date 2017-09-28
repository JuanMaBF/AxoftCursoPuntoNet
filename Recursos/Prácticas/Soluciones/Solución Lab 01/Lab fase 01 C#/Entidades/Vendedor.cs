using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Vendedor
    {
         public Vendedor(string pNombre, string pApellido, string pDNI,  string pEmail, string pTelefono, string pDireccion)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = pDNI;
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
        }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
