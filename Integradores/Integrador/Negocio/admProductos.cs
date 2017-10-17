using System.Collections.Generic;
using Entidades;
using Datos;

namespace Negocio
{
    public class admProductos : IAdminProducto
    {
        public List<Producto> Listar()
        {
            return dbProductos.Listar();
        }

        public List<Producto> Listar(int pCategoria, int pSubcategoria)
        {
            return dbProductos.Listar(pCategoria, pSubcategoria);
        }

        public Producto Listar(int pId)
        {
            return dbProductos.Listar(pId);
        }

        public void Agregar(Producto pProducto)
        {
            dbProductos.Agregar(pProducto);
        }

        public void Modificar(Producto pProducto)
        {
            dbProductos.Modificar(pProducto);
        }

        public void Eliminar(int pId)
        {
           dbProductos.Eliminar(pId);
        }
    }
}
