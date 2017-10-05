using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        private string _CUIT = string.Empty;
        
        public ClienteIndividuo() { ;}
        public ClienteIndividuo(string pNombre, string pApellido, string pCUIT, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.CUIT = pCUIT;
            this.DatosContacto = pDatosContacto;
        }
        public ClienteIndividuo(int pId, string pNombre, string pApellido, string pCUIT)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.CUIT = pCUIT;
        }
        public ClienteIndividuo(int pId, int pId_Persona, string pNombre, string pApellido, string pCUIT, DatosContacto pDatosContacto)
        {
            this.Id = pId;
            this.Id_Persona = pId_Persona;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.CUIT = pCUIT;
            this.DatosContacto = pDatosContacto;
        }

        public int Id_Persona { get; set; }
        public string CUIT
        {
            get { return _CUIT; }
            set
            {
                if (value.Trim().Length != 11)
                {
                    throw new Exception("El CUIT debe tener una longitud de 11 caracteres.");
                }
                _CUIT = value.Trim();
            }
        }
    }
}
