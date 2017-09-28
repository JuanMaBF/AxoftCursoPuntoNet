using Entidades.Base;
using System;

namespace Entidades.Reales
{
    public class Paciente : Persona
    {
        public int NroHistoriaClinica { get; set; }

        public Paciente(int id, string nombre, string apellido, string email, DateTime fechaNacimiento, int nroHistoriaClinica)
            :base(id, nombre, apellido, email, fechaNacimiento)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }
    }
}
