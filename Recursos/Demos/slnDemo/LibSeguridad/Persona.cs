using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSeguridad
{
    namespace Entidades.Base { 
            public abstract class Persona
            {

            //public Persona() { }

            public Persona(string nombre, string apellido, string email, DateTime fechaNacimiento)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Email = email;
                this.FechaNacimiento = fechaNacimiento;
            }
                    
                public string Nombre { get; set; }
                public string Apellido { get; set; }
                public string Email { get; set; }
                public DateTime FechaNacimiento { get; set; }

            public override string ToString()
            {
                return "Nombre " + Nombre + " Apellido " + Apellido; 
            }

            public virtual string Mensaje()
            {
                return "Nombre " + Nombre + " Apellido " + Apellido;
            }

        }
    }
}
