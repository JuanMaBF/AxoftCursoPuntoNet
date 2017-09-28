using Entidades.Reales;
using System;

namespace Negocio
{
    public class AdmPaciente : AdmBase<Paciente>
    {
        public void CrearPacientes()
        {
            lista.Add(new Paciente(1, "hola", "hola", "hola",
                DateTime.Now, 1));
            lista.Add(new Paciente(2, "hola", "hola", "hola",
                DateTime.Now, 1));
            lista.Add(new Paciente(3, "hola", "hola", "hola",
                DateTime.Now, 1));
            lista.Add(new Paciente(4, "hola", "hola", "hola",
                DateTime.Now, 1));
            lista.Add(new Paciente(5, "hola", "hola", "hola",
                DateTime.Now, 1));
            lista.Add(new Paciente(6, "hola", "hola", "hola",
                DateTime.Now, 1));
        }
    }
}
