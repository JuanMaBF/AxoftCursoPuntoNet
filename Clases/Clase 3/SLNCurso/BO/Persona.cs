using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.EntidadesBase
{
    public class Persona
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public int Id { get; set; }
        #endregion

        public Persona(string nombre, string apellido, int dni, string email, string ciudad)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Email = email;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + ". Apellido: " + Apellido;
        }

    }
}
