using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empresa
    {
        private string _Nombre = string.Empty;
        private string _CUIT = string.Empty;
        
        public Empresa() { ;}
        public Empresa(int pId, string pNombre)
        {
            this.Id = pId;
            this.Nombre = pNombre;
        }
        public Empresa(int pId, string pNombre, string pCUIT)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
        }
        public Empresa(string pNombre, string pCUIT, Persona pContacto, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
            this.DatosContacto = pDatosContacto;
        }
        public Empresa(int pId, int pId_Empresa, string pNombre, string pCUIT, Persona pContacto, DatosContacto pDatosContacto)
        {
            this.Id = pId;
            this.Id_Empresa = pId_Empresa;
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
            this.DatosContacto = pDatosContacto;
        }

        public int Id { get; set; }
        public int Id_Empresa { get; set; }
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (value.Trim().Length == 0 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre debe tener una longitud comprendida entre 1 y 50 caracteres.");
                }
                _Nombre = value.Trim();
            }
        }
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
        public Persona Contacto { get; set; }
        public DatosContacto DatosContacto { get; set; }
    }
}
