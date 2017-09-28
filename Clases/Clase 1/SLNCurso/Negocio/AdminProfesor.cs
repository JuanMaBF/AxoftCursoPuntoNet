using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdminProfesor
    {

        public void Agregar(Profesor profesor)
        { }

        public void Modificar(Profesor profesor)
        { }

        public void Eliminar(Profesor profesor)
        { }

        /// <summary>
        /// Trae todos los profesores
        /// </summary>
        /// <returns>Lista generica de Profesor</returns>
        public List<Profesor> TraerTodos(){
            return null;
        }

        /// <summary>
        /// Trae todos los profesores con esa especialidad
        /// </summary>
        /// <param name="especialidad">Especialidad. Ej: "Matemáticas"</param>
        /// <returns>Lista genérica de Profesor</returns>
        public List<Profesor> TraerTodos(string especialidad)
        {
            return null;
        }

    }
}
