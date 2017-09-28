using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Persona
    {

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string dni;

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public Persona() { }
        public Persona(string nombre, string Apellido, string ciudad, string email, string dni)
        {
            this.nombre = nombre;
            apellido = Apellido;
            this.ciudad = ciudad;
            this.dni = dni;
            this.email = email;



        }

        #region metodos
        public override string ToString()
        {
            return "Nombre: " +  nombre + " Apellido" +  apellido;
        }

        #endregion

    }
}
