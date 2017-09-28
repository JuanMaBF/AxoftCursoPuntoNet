using System;

namespace Entidades.Base
{
    public abstract class Persona
    {
        public int ID { get; internal set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(int id, string nombre, string apellido, string email, DateTime fechaNacimiento)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
        }

    }
}
