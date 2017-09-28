using Entidades.Base;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class AdmBase<T> where T : Persona
    {
        protected List<T> lista;

        public List<T> Listar()
        {
            return lista;
        }

        public List<T> Listar(int id)
        {
            return lista.Where(p => p.ID == id).ToList();
        }

        public void Agregar(T persona)
        {
            lista.Add(persona);
        }
    }
}
