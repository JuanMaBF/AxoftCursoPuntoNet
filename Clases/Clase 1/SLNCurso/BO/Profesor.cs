using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Profesor : Persona
    {
        public string Especialidad { get; set; }

        public Profesor(string nombre, string apellido, int dni, string email, string ciudad, string especialidad)
            :base(nombre, apellido, dni, email, ciudad)
        {
            Especialidad = especialidad;
        }

        public override string ToString()
        {
            return base.ToString() + ". Especialidad: " + Especialidad;
        }

    }
}
