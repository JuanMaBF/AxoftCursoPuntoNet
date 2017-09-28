using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAgencia.Entidades
{
    public class Modelo
    {
        public int IdModelo { get; set; }
        public string Nombre { get; set; }

        public Modelo(int id, string nombre)
        {
            IdModelo = id;
            Nombre = nombre;

        }
    }
}
