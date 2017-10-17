using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Servidor;
using Entidades;
using Datos.DataSetIntegradorTableAdapters;

namespace Datos
{
    public static class dbProductos
    { 
        private static SqlConnection objConexion = null;
        private static SqlCommand objCommand = null;
        private static SqlDataReader objReader = null;
        private static string SQL = string.Empty;

        static dbProductos()
        {
            try
            {
                objConexion = new SqlConnection(BaseDatos.StringConexion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public static List<Producto> Listar()
        {
            List<Producto> Lista = new List<Producto>();
            SQL = "SELECT Productos.Id, Productos.Nombre, Productos.Descripcion, Productos.PrecioCosto, Productos.Margen, Productos.Id_Proveedor, Productos.Id_Categoria, Productos.Id_Subcategoria, Categorias.Nombre AS Categoria, Subcategorias.Nombre AS Subcategoria, Proveedores.Id_Empresa, Empresas.Nombre AS Empresa";
            SQL = SQL + " "  + "FROM Productos";
            SQL = SQL + " " + "INNER JOIN Categorias ON Productos.Id_Categoria = Categorias.Id";
            SQL = SQL + " " + "INNER JOIN Subcategorias ON Productos.Id_Subcategoria = Subcategorias.Id AND Categorias.Id = Subcategorias.Id_Categoria"; 
            SQL = SQL + " " + "INNER JOIN Proveedores ON Productos.Id_Proveedor = Proveedores.Id";
            SQL = SQL + " " + "INNER JOIN Empresas ON Proveedores.Id_Empresa = Empresas.Id";
            SQL = SQL + " " + "ORDER BY Categoria, Subcategoria, Productos.Nombre";
            objCommand = new SqlCommand(SQL, objConexion);
            try
            {
                objConexion.Open();
                objReader = objCommand.ExecuteReader();
                while(objReader.Read())
                {
                    Empresa objProveedor = new Empresa(Convert.ToInt32(objReader["Id_Empresa"]), objReader["Empresa"].ToString());
                    Categoria objCategoria = new Categoria(Convert.ToInt32(objReader["Id_Categoria"]), objReader["Categoria"].ToString());
                    Categoria objSubcategoria = new Categoria(Convert.ToInt32(objReader["Id_Subcategoria"]), objReader["SubCategoria"].ToString());
                    Producto Item = new Producto(Convert.ToInt32(objReader["Id"]), objReader["Nombre"].ToString(), objReader["Descripcion"].ToString(), Convert.ToDecimal(objReader["PrecioCosto"]),Convert.ToDouble(objReader["Margen"]), objProveedor, objCategoria, objSubcategoria);
                    Lista.Add(Item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }   
            return Lista;
        }

        public static Producto Listar(int pId)
        {
            Producto objProducto = null;
            SQL = "SELECT Productos.Id, Productos.Nombre, Productos.Descripcion, Productos.PrecioCosto, Productos.Margen, Productos.Id_Proveedor, Productos.Id_Categoria, Productos.Id_Subcategoria, Categorias.Nombre AS Categoria, Subcategorias.Nombre AS Subcategoria, Proveedores.Id_Empresa, Empresas.Nombre AS Empresa";
            SQL = SQL + " " + "FROM Productos";
            SQL = SQL + " " + "INNER JOIN Categorias ON Productos.Id_Categoria = Categorias.Id";
            SQL = SQL + " " + "INNER JOIN Subcategorias ON Productos.Id_Subcategoria = Subcategorias.Id AND Categorias.Id = Subcategorias.Id_Categoria";
            SQL = SQL + " " + "INNER JOIN Proveedores ON Productos.Id_Proveedor = Proveedores.Id";
            SQL = SQL + " " + "INNER JOIN Empresas ON Proveedores.Id_Empresa = Empresas.Id";
            SQL = SQL + " " + "WHERE Productos.Id=@pId";
            objCommand = new SqlCommand(SQL, objConexion);
            SqlParameter Id_Categoria = new SqlParameter("@pId", pId);
            objCommand.Parameters.Add(Id_Categoria);
            try
            {
                objConexion.Open();
                objReader = objCommand.ExecuteReader();
                if (objReader.Read())
                {
                    Empresa objProveedor = new Empresa(Convert.ToInt32(objReader["Id_Empresa"]), objReader["Empresa"].ToString());
                    Categoria objCategoria = new Categoria(Convert.ToInt32(objReader["Id_Categoria"]), objReader["Categoria"].ToString());
                    Categoria objSubcategoria = new Categoria(Convert.ToInt32(objReader["Id_Subcategoria"]), objReader["SubCategoria"].ToString());
                    objProducto = new Producto(Convert.ToInt32(objReader["Id"]), objReader["Nombre"].ToString(), objReader["Descripcion"].ToString(), Convert.ToDecimal(objReader["PrecioCosto"]), Convert.ToDouble(objReader["Margen"]), objProveedor, objCategoria, objSubcategoria);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
            return objProducto;
        }

        public static List<Producto> Listar(int pId_Categoria, int pId_Subcategoria)
        {
            List<Producto> Lista = new List<Producto>();
            SQL = "SELECT Productos.Id, Productos.Nombre";
            SQL = SQL + " " + "FROM Productos";
            SQL = SQL + " " + "WHERE Id_Categoria = @pId_Categoria AND ID_Subcategoria = @pId_Subcategoria";
            SQL = SQL + " " + "ORDER BY Nombre";
            objCommand = new SqlCommand(SQL, objConexion);
            SqlParameter Id_Categoria = new SqlParameter("@pId_Categoria", pId_Categoria);
            SqlParameter Id_Subcategoria = new SqlParameter("@pId_Subcategoria", pId_Subcategoria);
            objCommand.Parameters.Add(Id_Categoria);
            objCommand.Parameters.Add(Id_Subcategoria);
            try
            {
                objConexion.Open();
                objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {
                    Producto Item = new Producto(Convert.ToInt32(objReader["Id"]), objReader["Nombre"].ToString());
                    Lista.Add(Item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
            return Lista;
        }

        public static void Agregar(Producto pProducto)
        {
            ProductosTableAdapter objTA = new ProductosTableAdapter();
            try
            {
                objTA.Connection.ConnectionString = BaseDatos.StringConexion;
                objTA.Insert(pProducto.Nombre, pProducto.Descripcion, pProducto.PrecioCosto, Convert.ToDecimal(pProducto.Margen), pProducto.Proveedor.Id, pProducto.Categoria.Id, pProducto.SubCategoria.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public static void Modificar(Producto pProducto)
        {
            ProductosTableAdapter objTA = new ProductosTableAdapter();
            try
            {
                objTA.Connection.ConnectionString = BaseDatos.StringConexion; ;
                objTA.Update(pProducto.Nombre, pProducto.Descripcion, pProducto.PrecioCosto, Convert.ToDecimal(pProducto.Margen), pProducto.Proveedor.Id, pProducto.Categoria.Id, pProducto.SubCategoria.Id,pProducto.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Eliminar(int pId)
        {
            ProductosTableAdapter objTA = new ProductosTableAdapter();
            try
            {
                objTA.Connection.ConnectionString = BaseDatos.StringConexion; ;
                objTA.Delete(pId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
