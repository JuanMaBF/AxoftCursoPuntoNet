using Entidades.Base;
using System;

namespace Entidades.Reales
{
    public class Medico : Persona
    {

        public string Especialidad { get; set; }

        public Medico(int id, string nombre, string apellido, string email, DateTime fechaNacimiento, string especialidad)
            :base(id, nombre, apellido, email, fechaNacimiento)
        {
            Especialidad = especialidad;
        }

    }
}
