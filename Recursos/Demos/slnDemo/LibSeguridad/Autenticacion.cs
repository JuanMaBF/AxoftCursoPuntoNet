using LibSeguridad.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSeguridad
{
    public class Autenticacion
    {
        #region metodos
        /// <summary>
        /// autenticacion del usuario contra una base de sql server....
        /// </summary>
        /// <param name="nombre">se espera una cadena </param>
        /// <param name="password">se espera una cadena hasta 4 digitos</param>
        /// <returns>booleano</returns>
        public bool login(Usuario usuario)
        {
            if (usuario.Nombre == "gaby" && usuario.password == "1234")
            {
                 
                return true;
            }
            else
            {
                return false;
            }
       }


        #endregion
    }
}
