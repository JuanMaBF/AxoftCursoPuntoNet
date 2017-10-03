using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor: Persona
    {
        public string Dni { get; set; }

        public Vendedor(
            string nombre,
            string apellido,
            string dni,
            DatosContacto datosContacto)
            :base(nombre, apellido, datosContacto)
        {
            Dni = dni;
        }

        public override string ToString()
        {
            return
                "Nombre=" + Nombre +
                "Apellido=" + Apellido +
                "Dni=" + Dni +
                DatosContacto.ToString();
        }

    }
}
