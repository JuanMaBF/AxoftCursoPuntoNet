using BO.EntidadesBase;

namespace BO.Entidades
{
    public class Alumno : Persona
    {
        public int Legajo { get; set; }

        public Alumno(string nombre, string apellido, int dni, string email, string ciudad, int legajo)
            :base(nombre, apellido, dni, email, ciudad)
        {
            Legajo = legajo;
        }

        public override string ToString()
        {
            return base.ToString() + ". Legajo: " + Legajo.ToString();
        }

    }
}
