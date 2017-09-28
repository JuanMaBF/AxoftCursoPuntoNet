using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAgencia.Entidades;

namespace WindowsAgencia.ADMAgencia
{
    public class AdmAuto
    {
        List<Auto> lista;

        public AdmAuto()
        {
            lista = new List<Auto>();
            lista.Add(new Auto(1, 1,"azul"));
            lista.Add(new Auto(2, 2, "azul"));
            lista.Add(new Auto(3, 1, "Rojo"));


        }

        public List<Auto> listar()
        {
            return lista;
        }

        public List<Auto> listar(int idModelo)
        {
            List<Auto> nuevaLista = new List<Auto>();

            foreach (Auto item in lista)
            {
                if (item.IdModelo == idModelo)
                {
                    nuevaLista.Add(item);
                }
            }


            return nuevaLista;
        }

        public void agregar(Auto auto)
        {

            lista.Add(auto);
        }


    }
}
