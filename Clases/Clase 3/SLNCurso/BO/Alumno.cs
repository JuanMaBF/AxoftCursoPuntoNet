using BO.EntidadesBase;

namespace BO.Entidades
{
    public class Alumno : Persona
    {
        public int NroLegajo { get; set; }

        public Alumno(string nombre, string apellido, int dni, string email, string ciudad, int nroLegajo)
            :base(nombre, apellido, dni, email, ciudad)
        {
            NroLegajo = nroLegajo;
        }

        public override string ToString()
        {
            return base.ToString() + ". Legajo: " + NroLegajo.ToString();
        }

    }
}
