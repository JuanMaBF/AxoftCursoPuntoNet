using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DatosContacto
    {
        public DatosContacto(string email, String direccion, String telefono)
        {
            this.Email = email;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
