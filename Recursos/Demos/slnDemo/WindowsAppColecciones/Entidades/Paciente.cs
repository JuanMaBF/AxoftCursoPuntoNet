
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppColecciones.Entidades.Base;

namespace WindowsAppColecciones.Entidades
{
    public class Paciente:Persona
    {
        public int NroHistoriaClinica { get; set; }

        public Paciente(string pNombre, string pApelllido, string pEmail, DateTime pFecha, int NroHistoriaClinica) :base(pNombre,pApelllido,pEmail,pFecha)
        {
            this.NroHistoriaClinica = NroHistoriaClinica;
        }
    }
}
