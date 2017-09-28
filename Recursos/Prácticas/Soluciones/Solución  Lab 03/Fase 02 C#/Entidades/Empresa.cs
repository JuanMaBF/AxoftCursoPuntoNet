using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empresa
    {
        public Empresa(string pNombre, string pCUIT, string pContacto,
            DatosContacto datosContacto
            //string pEmail, 
            //string pTelefono, 
            //string pDireccion
            )
        {
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
            //this.Email = pEmail;
            //this.Telefono = pTelefono;
            //this.Direccion = pDireccion;
            this.DatosContacto = datosContacto;
        }
        
        public DatosContacto DatosContacto { get; set; }
        
        public string Nombre {get; set;}
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        //public string Email { get; set; }
        //public string Telefono { get; set; }
        //public string Direccion { get; set; }
    }
}
