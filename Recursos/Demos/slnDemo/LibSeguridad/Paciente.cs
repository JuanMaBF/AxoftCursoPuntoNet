using LibSeguridad.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSeguridad
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
