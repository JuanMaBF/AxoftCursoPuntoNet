using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Categoria
    {

        public Categoria(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get; set; }
    }
}
