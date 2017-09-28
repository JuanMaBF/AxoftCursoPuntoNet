using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Alumno:Persona
    {
        #region Propiedades

   
        public int NroLegajo { get; set; }

        #endregion

        #region Constructores

        public Alumno() { }

              public Alumno( int NroLegajo, string nombre, string Apellido, string ciudad, string email, string dni): base(nombre,Apellido,ciudad,email,dni)
        {
            this.NroLegajo = NroLegajo;
        }


        #endregion

        #region metodos
        public override string ToString()
        {
            return base.ToString() + " Nro Legajo: " + NroLegajo;
        }

        #endregion

    }
}
