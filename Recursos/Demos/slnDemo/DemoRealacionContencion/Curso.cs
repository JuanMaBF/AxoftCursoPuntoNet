using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoRealacionContencion
{
    public class Curso
    {
        private List<Alumno> alumnos;
        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }

            set
            {
                alumnos = value;
            }
        }

        public List<Clase> Clases
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Instructor Instructor
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Materia Materia
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}