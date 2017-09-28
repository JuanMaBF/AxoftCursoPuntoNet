using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAgencia.Entidades;

namespace WindowsAgencia.ADMAgencia
{
    public class AdmModelo
    {
        List<Modelo> lista;

        public AdmModelo()
        {
            lista = new List<Modelo>();
            lista.Add(new Modelo(1, "Fiat"));
            lista.Add(new Modelo(2, "Ford"));
        }

      
        public List<Modelo> listar()
        {
            return lista;
        }

        public void agregar(Modelo modelo)
        {
            lista.Add(modelo);
        }
    }
}
