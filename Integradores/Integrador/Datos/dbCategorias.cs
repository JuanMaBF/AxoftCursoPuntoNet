using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Servidor;
using Entidades;

namespace Datos
{
    public static class dbCategorias
    {
        private static SqlConnection objConexion = null;
        private static SqlCommand objCommand = null;
        private static SqlDataReader objReader = null;
        private static string SQL = string.Empty;

        static dbCategorias()
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

        public static List<Categoria> Listar()
        {
            List<Categoria> Lista = new List<Categoria>();
            SQL = "SELECT Id, Nombre FROM Categorias ORDER BY Nombre";
            objCommand = new SqlCommand(SQL, objConexion);
            try
            {
                objConexion.Open();
                objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {
                    Categoria Item = new Categoria(Convert.ToInt32(objReader["Id"]), objReader["Nombre"].ToString());
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

        public static Categoria Listar(int pId)
        {
            Categoria objCategoria = null;
            SQL = "SELECT Id, Nombre FROM Categorias";
            SQL = SQL + " " + "WHERE Id = @pId";
            objCommand = new SqlCommand(SQL, objConexion);
            SqlParameter Id = new SqlParameter("@pId", pId);
            objCommand.Parameters.Add(Id);
            try
            {
                objConexion.Open();

                objReader = objCommand.ExecuteReader();
                if (objReader.Read())
                {
                    objCategoria = new Categoria(Convert.ToInt32(objReader["Id"]), objReader["Nombre"].ToString());
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
            return objCategoria;
        }

        public static List<Categoria> ListarSubcategorias(int pId_Categoria)
        {
            List<Categoria> Lista = new List<Categoria>();
            SQL = "SELECT Id, Nombre";
            SQL = SQL + " " + "FROM Subcategorias";
            SQL = SQL + " " + "WHERE Id_Categoria = @pId_Categoria";
            SQL = SQL + " " + "ORDER BY Nombre";
            objCommand = new SqlCommand(SQL, objConexion);
            SqlParameter Id_Categoria = new SqlParameter("@pId_Categoria", pId_Categoria);
            objCommand.Parameters.Add(Id_Categoria);
            try
            {
                objConexion.Open();
                objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {
                    Categoria Item = new Categoria(Convert.ToInt32(objReader["Id"]), objReader["Nombre"].ToString());
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

        public static Categoria ListarSubcategoria (int pId)
        {
            Categoria objSubcategoria = null;
            SQL = "SELECT Id, Nombre";
            SQL = SQL + " " + "FROM Subcategorias";
            SQL = SQL + " " + "WHERE Id = @pId";
            objCommand = new SqlCommand(SQL, objConexion);
            SqlParameter Id = new SqlParameter("@pId", pId);
            objCommand.Parameters.Add(Id);
            try
            {
                objConexion.Open();
                objReader = objCommand.ExecuteReader();
                if (objReader.Read())
                {
                    objSubcategoria = new Categoria(Convert.ToInt32(objReader["Id"]), objReader["Nombre"].ToString());
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
            return objSubcategoria;
        }
    }
}
