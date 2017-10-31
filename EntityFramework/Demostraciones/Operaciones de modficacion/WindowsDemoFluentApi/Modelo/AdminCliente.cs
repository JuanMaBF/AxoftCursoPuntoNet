using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoFluentApi.Modelo
{
     public class AdminCliente
    {
        FacturacionDB db;
        public AdminCliente() {
            db = new FacturacionDB();
        }


        public List<Cliente> traerTodos()
        {
            List<Cliente> lista = (from liCli in db.Clientes
                                   select liCli).ToList();
            return lista;

        }

        public Cliente traerCliente(int IdCliente)
        {
            return (from liCli in db.Clientes
                    where liCli.CliId==IdCliente
                    select liCli).SingleOrDefault() ;
        }

        public void agregar(Cliente cliente)
        {
            db.Clientes.Add(cliente);

        }

        public void modificar(Cliente cliente)
        {
          Cliente objModificar = (from cli in db.Clientes
                                   where cli.CliId == cliente.CliId
                                   select cli).SingleOrDefault();
            objModificar.Apellido = cliente.Apellido;
            objModificar.Nombre = cliente.Nombre;
            
        }

        public void eliminar(int IdCliente)
        {
            Cliente objEliminar = (from cli in db.Clientes
                                    where cli.CliId == IdCliente
                                    select cli).SingleOrDefault();
            db.Clientes.Remove(objEliminar);
        }

        public void guardar()
        {
            db.SaveChanges();
        }
    }
}
