using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppColecciones.Entidades;

namespace WindowsAppColecciones.AdmClinica
{
    public  class ADMMedico
    {

        public  List<Medico> listar()
        {

            List<Medico> listaMedicos = new List<Medico>();

            listaMedicos.Add(new Medico("Carolina", "Garcia", "CarolinaG@Clinica.com", new DateTime(1976, 10, 22), "Pediatra"));
            listaMedicos.Add(new Medico("Juan", "Perez", "JuanP@Clinica.com", new DateTime(1999, 02, 22), "Pediatra"));
            listaMedicos.Add(new Medico("Ana", "Pocetti", "AnaP@Clinica.com", new DateTime(1970, 10, 10), "Clinico"));

            return listaMedicos;


        }


    }
}
