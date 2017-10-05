using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Categoria
    {
        private string _Nombre = string.Empty;

        public Categoria(string pNombre)
        {
            this.Nombre = pNombre;
        }
        public Categoria(int pId, string pNombre)
        {
            this.Id = pId;
            this.Nombre = pNombre;
        }

        public int Id { get; set; }
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if(value.Trim().Length == 0 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre debe tener una longitud comprendida entre 1 y 50 caracteres.");
                }
                _Nombre = value.Trim();
            }
        }
    }
}
