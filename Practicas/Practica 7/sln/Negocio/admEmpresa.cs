using DALIntegrador;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    class admEmpresa
    {

        public int Agregar(Empresa empresa)
        {
            return dacEmpresa.Agergar(empresa);
        }

        public int Modificar(Empresa empresa)
        {
            return  dacEmpresa.Modificar(empresa);
        }

        public int Eliminar(int idEmpresa)
        {
            return dacEmpresa.Eliminar(idEmpresa);
        }

        public List<Empresa> TraerTodos()
        {
            return dacEmpresa.TraerTodos();
        }

        public List<Empresa> TraerTodos(string cuit)
        {
            return dacEmpresa.TraerTodos(cuit);
        }

    }
}
