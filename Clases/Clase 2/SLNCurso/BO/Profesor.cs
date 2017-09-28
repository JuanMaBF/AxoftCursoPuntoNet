using BO.EntidadesBase;

namespace BO.Entidades
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
