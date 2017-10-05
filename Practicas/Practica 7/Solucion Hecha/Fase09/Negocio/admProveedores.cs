using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public static class admProveedores
    {
        public static List<Empresa> Listar()
        {
            return dbProveedores.Listar();
        }
        public static Empresa Listar(int pId)
        {
            return dbProveedores.Listar(pId);
        }
        public static void Agregar(Empresa pProveedor)
        {
            dbProveedores.Agregar(pProveedor);
        }
        public static void Modificar(Empresa pProveedor)
        {
            dbProveedores.Modificar(pProveedor);
        }
        public static void Eliminar(Empresa pProveedor)
        {
            dbProveedores.Eliminar(pProveedor);
        }
    }
}
