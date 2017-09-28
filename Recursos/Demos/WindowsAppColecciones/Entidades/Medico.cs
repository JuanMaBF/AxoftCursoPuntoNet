 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppColecciones.Entidades.Base;

namespace WindowsAppColecciones.Entidades
{
    public class Medico:Persona
    {
        public Medico(string pNombre, string pApelllido, string pEmail, DateTime pFecha, string especialidad):base(pNombre,pApelllido,pEmail,pFecha)
        {
            this.Especilidad = especialidad;
        }

        public string Especilidad { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Especilidad " + Especilidad;
        }

    }
}
