using BO.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.dac
{
    public static class dbAlumno
    {

        public static int Agregar(Alumno alumno)
        {
            string query = "INSERT INTO Alumno(Nombre, Apellido, DNI, Email, Ciudad, NroLegajo)VALUES(@Nombre, @Apellido, @DNI, @Email, @Ciudad, @NroLegajo)";
            SqlCommand dmlQuery = new SqlCommand(query, AdminDB.ConectarDB());
            dmlQuery.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = alumno.Nombre;
            dmlQuery.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = alumno.Apellido;
            dmlQuery.Parameters.Add("@DNI", SqlDbType.Char, 11).Value = alumno.DNI;
            dmlQuery.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = alumno.Email;
            dmlQuery.Parameters.Add("@Ciudad", SqlDbType.VarChar, 50).Value = alumno.Ciudad;
            dmlQuery.Parameters.Add("@NroLegajo", SqlDbType.Int).Value = alumno.NroLegajo;
            return dmlQuery.ExecuteNonQuery();
        } 

        public static int Modificar(Alumno alumno)
        {
            string query = "UPDATE Alumno SET Nombre = @Nombre, Apellido = @Apellido, Dni = @Dni, Ciudad = @Ciudad, Email = @Email, NroLegajo = @NroLegajo WHERE ID = @Id";
            SqlCommand dmlQuery = new SqlCommand(query, AdminDB.ConectarDB());
            dmlQuery.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = alumno.Nombre;
            dmlQuery.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = alumno.Apellido;
            dmlQuery.Parameters.Add("@Dni", SqlDbType.Char, 11).Value = alumno.DNI;
            dmlQuery.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = alumno.Email;
            dmlQuery.Parameters.Add("@Ciudad", SqlDbType.VarChar, 50).Value = alumno.Ciudad;
            dmlQuery.Parameters.Add("@NroLegajo", SqlDbType.Int).Value = alumno.NroLegajo;
            dmlQuery.Parameters.Add("@Id", SqlDbType.Int).Value = alumno.Id;
            return dmlQuery.ExecuteNonQuery();
        }

        public static int Eliminar(int idAlumno)
        {
            string query = "DeleteAlumnoPorId";
            SqlCommand dmlQuery = new SqlCommand(query, AdminDB.ConectarDB());
            dmlQuery.CommandType = CommandType.StoredProcedure;
            dmlQuery.Parameters.Add("@Id", SqlDbType.Int).Value = idAlumno;
            return dmlQuery.ExecuteNonQuery();
        }

        public static List<Alumno> TraerTodos()
        {
            //1 connection
            //2 sql o spu
            string query = "SELECT [Id],[Nombre],[Apellido],[DNI],[Email],[Ciudad],[NroLegajo]FROM[dbo].[Alumno]";
            //3 comando SqlCommand
            SqlCommand command = new SqlCommand(query, AdminDB.ConectarDB());
            //4 objeto reader
            //5 invcocar SqlCommand y trabajar con el reader
            SqlDataReader reader = command.ExecuteReader();
            //6 crear la lista
            List<Alumno> lista = new List<Alumno>();
            while (reader.Read())
            {
                lista.Add(new Alumno(
                        reader["Nombre"].ToString(), 
                        reader["Apellido"].ToString(), 
                        int.Parse(reader["DNI"].ToString()), 
                        reader["Email"].ToString(), 
                        reader["Ciudad"].ToString(), 
                        int.Parse(reader["NroLegajo"].ToString())
                    ));
            }
            AdminDB.CerrarConexion();
            return lista;
        }

        public static List<Alumno> TraerTodos(string ciudad)
        {
            string procedure = "TraerTodosPorCiudad";
            SqlCommand command = new SqlCommand(procedure, AdminDB.ConectarDB());
            //definir tipo de comando
            command.CommandType = CommandType.StoredProcedure;
            //definir parametro
            command.Parameters.Add("@ciudad", SqlDbType.VarChar, 50).Value = ciudad;
            SqlDataReader reader = command.ExecuteReader();
            List<Alumno> lista = new List<Alumno>();
            while (reader.Read())
            {
                lista.Add(new Alumno(
                        reader["Nombre"].ToString(),
                        reader["Apellido"].ToString(),
                        int.Parse(reader["DNI"].ToString()),
                        reader["Email"].ToString(),
                        reader["Ciudad"].ToString(),
                        int.Parse(reader["NroLegajo"].ToString())
                    ));
            }
            AdminDB.CerrarConexion();
            return lista;
        }
    }
}
