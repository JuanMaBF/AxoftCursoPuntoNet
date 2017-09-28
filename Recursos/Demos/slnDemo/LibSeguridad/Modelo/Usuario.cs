using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSeguridad.Modelo
{

    public class Usuario
    {

        #region constructores
        public Usuario()//constructor por defecto
        {
           
        }

        public Usuario(string nombre, string password)//constructor con parametros
        {
            Nombre = nombre;
            this.password = password;
     
        }


        #endregion
        #region propiedadesCompletas

        private string nombre;

        public string Nombre
        {
            get { return nombre;
              
            }
            set { nombre = value; }
        }

        public string password { get; set; }

        #endregion



    }
}
