using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public ClienteIndividuo() { ;}
        public ClienteIndividuo(string pNombre, string pApellido, string pCUIT, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.CUIT = pCUIT;
            this.DatosContacto = pDatosContacto;
        }

        public string CUIT { get; set; }
    }
}
