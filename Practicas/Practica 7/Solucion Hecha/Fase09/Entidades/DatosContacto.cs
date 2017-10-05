using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DatosContacto
    {
        private string _Email = string.Empty;
        private string _Telefono = string.Empty;
        private string _Direccion = string.Empty;

        public DatosContacto() { }
        public DatosContacto(string pEmail, string pTelefono, string pDireccion)
        {
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
        }
        public DatosContacto(int pId, string pEmail, string pTelefono, string pDireccion)
        {
            this.Id = pId;
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
        }

        public int Id { get; set; }
        public string Email
        {
            get { return _Email; }
            set
            {
                if (value.Trim().Length < 6 || value.Trim().Length > 50)
                {
                    throw new Exception("El email debe tener una longitud comprendida entre 6 y 50 caracteres.");
                }
                _Email = value.Trim();
            }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set
            {
                if (value.Trim().Length != 0)
                {
                    if (value.Trim().Length != 15)
                    {
                        throw new Exception("El teléfono (opcional) debe tener una longitud de 15 caracteres.");
                    } 
                }
                _Telefono = value.Trim();
            }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set
            {
                if (value.Trim().Length < 15 || value.Trim().Length > 100)
                {
                    throw new Exception("La dirección debe tener una longitud comprendida entre 15 y 100 caracteres.");
                }
                _Direccion = value.Trim();
            }
        }
    }
}
