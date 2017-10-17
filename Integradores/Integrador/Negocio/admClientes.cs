using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public static class admClientes
    {
        public static event EventHandler ImpresionOK;
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            ImpresionOK?.Invoke("EVENTO", null);
            return dbClientes.ListarClientesIndividuo();
        }

        public static ClienteIndividuo ListarClienteIndividuo(int pId)
        {
            return dbClientes.ListarClientesIndividuo(pId); 
        }

        public static List<Empresa> ListarClienteEmpresa()
        {
            return dbClientes.ListarClientesEmpresa();
        }

        public static Empresa ListarClienteEmpresa(int pId)
        {
            return dbClientes.ListarClientesEmpresa(pId);
        }
        public static void Agregar(ClienteIndividuo pCliente)
        {
            dbClientes.Agregar(pCliente);
        }
        public static void Modificar(ClienteIndividuo pCliente)
        {
            ImpresionOK?.Invoke("EVENTO", null);
            dbClientes.Modificar(pCliente);
        }
        public static void Eliminar(ClienteIndividuo pCliente)
        {
            ImpresionOK?.Invoke("EVENTO", null);
            dbClientes.Eliminar(pCliente);
        }
        public static void Agregar(Empresa pCliente)
        {
           dbClientes.Agregar(pCliente);
        }
        public static void Modificar(Empresa pCliente)
        {
            dbClientes.Modificar(pCliente);
        }
        public static void Eliminar(Empresa pCliente)
        {
            dbClientes.Eliminar(pCliente);
        }
    }
}
