using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSeguridad
{
    public class AdminMedico
    {
        /// <summary>
        /// genera una lista de medicos
        /// por ejemplo select id, nombre, especilidad from dbo.medico
        /// </summary>
        public void listar()
        {
            //TODO FALTA IMPLEMENTAR LISTAR()

        }

        /// <summary>
        /// genera una lista de medicos filtrando por especilidad
        /// por ejemplo select id, nombre, especialidad from dbo.medico
        /// where especialidad=@especialidad
        /// </summary>
        /// <param name="especilidad">por ejemplo pediatra</param>
        public void listar(string especialidad)
        {
            //TODO FALTA IMPLEMENTAR LISTAR(ESPECIALIDAD)

        }
        /// <summary>
        /// genera una lista de medicos filtrando por especilidad
        /// por ejemplo select id, nombre, especialidad from dbo.medico
        /// where especialidad=@especialidad and ciudad= @ciudad
        /// </summary>
        /// <param name="especialidad">pediatra</param>
        /// <param name="ciudad"> palermo</param>
        public void listar(string especialidad, string ciudad)
        {
            //TODO FALTA IMPLEMENTAR LISTAR(ESPECIALIDAD, CIUDAD)

        }


    }
}
