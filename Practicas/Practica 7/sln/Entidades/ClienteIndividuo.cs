using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo: Persona
    {
        public string Cuit { get; set; }

        public ClienteIndividuo(
            string nombre,
            string apellido,
            string cuit,
            DatosContacto datosContacto)
            : base(nombre, apellido, datosContacto)
        {
            Cuit = cuit;
        }

        public override string ToString()
        {
            return
                "Nombre=" + Nombre +
                "Apellido=" + Apellido +
                "Cuit=" + Cuit +
                DatosContacto.ToString();
        }

    }
}
