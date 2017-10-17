using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Vendedor : Persona
    {
        
        private string _DNI = string.Empty;

        public Vendedor(string pNombre, string pApellido, string pDNI, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = pDNI;
            this.DatosContacto = pDatosContacto;
        }

        public string DNI
        {
            get { return _DNI; }
            set
            {
                if (value.Trim().Length != 0)
                {
                    if (value.Trim().Length != 8)
                    {
                        throw new Exception("El D.N.I. (opcional) debe tener una longitud de 8 caracteres.");
                    }
                }
                _DNI = value.Trim();
            }
        }
    }
}
