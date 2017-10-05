using Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DALIntegrador
{
    public static class dacEmpresa
    {

        public static int Agergar(Empresa empresa)
        {
            string query = "INSERT INTO Alumno(Nombre, CUIT, Id_PersonaContacto, Id_DatosContacto)VALUES(@Nombre, @Cuit, @Id_PersonaContacto, @Id_DatosContacto)";
            SqlCommand dmlQuery = new SqlCommand(query, AdminDB.Instance.ConectarDB());
            dmlQuery.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = empresa.Nombre;
            dmlQuery.Parameters.Add("@Cuit", SqlDbType.VarChar, 50).Value = empresa.Cuit;
            dmlQuery.Parameters.Add("@Id_PersonaContacto", SqlDbType.Int).Value = empresa.Id_PersonaContacto;
            dmlQuery.Parameters.Add("@Id_DatosContacto", SqlDbType.Int).Value = empresa.Id_DatosContacto;
            return dmlQuery.ExecuteNonQuery();
        }

        public static int Modificar(Empresa empresa)
        {
            string query = "UPDATE Alumno SET Nombre = @Nombre, CUIT = @Cuit, Id_PersonaContacto = @Id_PersonaContacto, Id_DatosContacto = @Id_DatosContacto WHERE ID = @Id";
            SqlCommand dmlQuery = new SqlCommand(query, AdminDB.Instance.ConectarDB());
            dmlQuery.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = empresa.Nombre;
            dmlQuery.Parameters.Add("@Cuit", SqlDbType.VarChar, 50).Value = empresa.Cuit;
            dmlQuery.Parameters.Add("@Id_PersonaContacto", SqlDbType.Int).Value = empresa.Id_PersonaContacto;
            dmlQuery.Parameters.Add("@Id_DatosContacto", SqlDbType.Int).Value = empresa.Id_DatosContacto;
            dmlQuery.Parameters.Add("@Id", SqlDbType.Int).Value = 1;
            return dmlQuery.ExecuteNonQuery();
        }

        public static int Eliminar(int idEmpresa)
        {
            string query = "DeleteAlumnoPorId";
            SqlCommand dmlQuery = new SqlCommand(query, AdminDB.Instance.ConectarDB());
            dmlQuery.CommandType = CommandType.StoredProcedure;
            dmlQuery.Parameters.Add("@Id", SqlDbType.Int).Value = idEmpresa;
            return dmlQuery.ExecuteNonQuery();
        }

        public static List<Empresa> TraerTodos()
        {
            string query = "SELECT [Id],[Nombre],[Cuit],[Id_PersonaContacto],[Id_DatosContacto]FROM[dbo].[Empresa]";
            SqlCommand command = new SqlCommand(query, AdminDB.Instance.ConectarDB());
            SqlDataReader reader = command.ExecuteReader();
            List<Empresa> lista = new List<Empresa>();
            while (reader.Read())
            {
                lista.Add(new Empresa(
                        reader["Nombre"].ToString(),
                        reader["Cuit"].ToString()
                    ));
            }
            AdminDB.Instance.CerrarConexion();
            return lista;
        }

        public static List<Empresa> TraerTodos(string cuit)
        {
            string procedure = "TraerTodosPorCiudad";
            SqlCommand command = new SqlCommand(procedure, AdminDB.Instance.ConectarDB());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Cuit", SqlDbType.VarChar, 50).Value = cuit;
            SqlDataReader reader = command.ExecuteReader();
            List<Empresa> lista = new List<Empresa>();
            while (reader.Read())
            {
                lista.Add(new Empresa(
                        reader["Nombre"].ToString(),
                        reader["Cuit"].ToString()
                    ));
            }
            AdminDB.Instance.CerrarConexion();
            return lista;
        }

    }
}
