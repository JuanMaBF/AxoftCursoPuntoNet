using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servidor
{
    public static class BaseDatos
    {
        public static string StringConexion
        {
            get 
            {
                return Properties.Settings.Default.StringConexion;
            }
        }
    }
}
