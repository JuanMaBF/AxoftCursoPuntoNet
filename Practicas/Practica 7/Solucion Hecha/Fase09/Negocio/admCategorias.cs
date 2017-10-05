using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public static class admCategorias
    {
        public static List<Categoria> Listar()
        {
            return dbCategorias.Listar();
        }
        
        public static Categoria Listar(int pId)
        {
            return dbCategorias.Listar(pId);
        }

        public static List<Categoria> ListarSubCategorias(int pCategoria)
        {
            return dbCategorias.ListarSubcategorias(pCategoria);
        }

        public static Categoria ListarSubcategoria(int pId)
        {
            return dbCategorias.ListarSubcategoria(pId);
        }
    }
}
