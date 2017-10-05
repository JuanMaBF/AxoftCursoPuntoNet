using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string _Nombre = string.Empty;
        private string _Apellido = string.Empty;

        public Persona() { ;}
        public Persona(string pNombre, string pApellido, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DatosContacto = pDatosContacto;
        }
        public Persona(int pId, string pNombre, string pApellido, DatosContacto pDatosContacto)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DatosContacto = pDatosContacto;
        }

        public int Id { get; set; }
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
        public string Apellido
        {
            get { return _Apellido; }
            set
            {
                if (value.Trim().Length == 0 || value.Trim().Length > 50)
                {
                    throw new Exception("El apellido debe tener una longitud comprendida entre 1 y 50 caracteres.");
                }
                _Apellido = value.Trim();
            }
        }
        public DatosContacto DatosContacto { get; set; }

        public string NombreCompleto
        {
            get { return this.Apellido + ", " + this.Nombre; }
        }
    }
}
