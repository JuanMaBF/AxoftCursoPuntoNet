using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class admProveedores : IAdminProveedores
    {
        public List<Empresa> Listar()
        {
            return dbProveedores.Listar();
        }

        public Empresa Listar(int pId)
        {
            return dbProveedores.Listar(pId);
        }

        public void Agregar(Empresa pProveedor)
        {
            dbProveedores.Agregar(pProveedor);
        }

        public void Modificar(Empresa pProveedor)
        {
            dbProveedores.Modificar(pProveedor);
        }

        public void Eliminar(Empresa pProveedor)
        {
            dbProveedores.Eliminar(pProveedor);
        }

        public virtual void Eliminar(int id)
        {
            throw new Exception("Elimina por empresa :D");
        }
    }
}
