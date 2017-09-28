using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Negocio
{
    public class admProductos 
    {
        public List<Producto> Listar()
        {
            List<Producto> Lista = new List<Producto>();
            //...
            return Lista;
        }
        public List<Producto> Listar(Categoria pCategoria)
        {
            List<Producto> Lista = new List<Producto>();
            //...
            return Lista;
        }
        public List<Producto> Listar(Categoria pCategoria, Categoria pSubcategoria)
        {
            List<Producto> Lista = new List<Producto>();
            //...
            return Lista;
        }
        public Producto Listar(string pNombre)
        {
            Producto Item = new Producto();
            //...
            return Item;
        }
    }
}
