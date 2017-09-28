using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public ClienteIndividuo(string pNombre, string pApellido, string pCUIT, 
            //string pEmail, 
            //string pTelefono, 
            //string pDireccion
            DatosContacto datosContacto
            )
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.CUIT = pCUIT;
              this.DatosContacto = datosContacto;
            //this.Email = pEmail;
            //this.Telefono = pTelefono;
            //this.Direccion = pDireccion;
        }

        public string CUIT { get; set; }
    }
}
