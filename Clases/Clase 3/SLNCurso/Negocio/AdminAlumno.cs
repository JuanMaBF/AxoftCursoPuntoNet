using BO.Entidades;
using System.Collections.Generic;
using DAL.dac;

namespace Negocio
{
    public class AdminAlumno
    {

        public int Agregar(Alumno alumno)
        {
            return dbAlumno.Agregar(alumno);
        }

        public int Modificar(Alumno alumno)
        {
            return dbAlumno.Modificar(alumno);
        }

        public int Eliminar(int idAlumno)
        {
            return dbAlumno.Eliminar(idAlumno);
        }

        /// <summary>
        /// Retornar todos los alumnos
        /// </summary>
        /// <returns>Lista genérica de Alumnos</returns>
        public List<Alumno> TraerTodos()
        {
            return dbAlumno.TraerTodos();
        }

        /// <summary>
        /// Retorna todos los alumnos de la ciudad que recibe
        /// </summary>
        /// <param name="ciudad">Ciudad. Ej: "Quilmes"</param>
        /// <returns>Lista genérica de Alumnos</returns>
        public List<Alumno> TraerTodos(string ciudad)
        {
            return dbAlumno.TraerTodos(ciudad);
        }

    }
}
