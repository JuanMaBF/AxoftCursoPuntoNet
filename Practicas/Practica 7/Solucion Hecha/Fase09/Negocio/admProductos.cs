using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class admProductos 
    {
        public static List<Producto> Listar()
        {
            return dbProductos.Listar();
        }
        public static List<Producto> Listar(int pCategoria, int pSubcategoria)
        {
            return dbProductos.Listar(pCategoria, pSubcategoria);
        }
        public static Producto Listar(int pId)
        {
            return dbProductos.Listar(pId);
        }
        public static void Agregar(Producto pProducto)
        {
            dbProductos.Agregar(pProducto);
        }
        public static void Modificar(Producto pProducto)
        {
            dbProductos.Modificar(pProducto);
        }
        public static void Eliminar(int pId)
        {
           dbProductos.Eliminar(pId);
        }
    }
}
