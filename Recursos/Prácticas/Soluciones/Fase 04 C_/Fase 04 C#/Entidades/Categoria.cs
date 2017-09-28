using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Categoria
    {
        public Categoria(string pNombre)
        {
            this.Nombre = pNombre;
        }
        public string Nombre { get; set; }
    }
}
