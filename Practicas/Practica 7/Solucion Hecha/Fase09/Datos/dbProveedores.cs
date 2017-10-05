using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Servidor;
using Entidades;

namespace Datos
{
    public class dbProveedores
    {
        private static SqlConnection objConexion = null;
        private static SqlCommand objCommand = null;
        private static SqlCommand objCommandEmpresa = null;
        private static SqlCommand objCommandDatosContacto = null;
        private static SqlCommand objCommandPersonaContacto = null;
        private static SqlCommand objCommandContactoDatosContacto = null;
        private static SqlDataReader objReader = null;
        private static SqlTransaction objTransaction = null;

        private static string SQL = string.Empty;

        static dbProveedores()
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

        public static List<Empresa> Listar()
        {
            List<Empresa> Lista = new List<Empresa>();
            SQL = "SELECT Proveedores.Id, Empresas.Nombre, Empresas.CUIT";
            SQL = SQL + " " + "FROM Proveedores";
            SQL = SQL + " " + "INNER JOIN Empresas ON Proveedores.Id_Empresa = Empresas.Id";
            SQL = SQL + " " + "ORDER BY Empresas.Nombre";
            objCommand = new SqlCommand(SQL, objConexion);
            try
            {
                objConexion.Open();
               
                objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {
                    Empresa Item = new Empresa(Convert.ToInt32(objReader["Id"]), objReader["Nombre"].ToString(), objReader["CUIT"].ToString());
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

        public static Empresa Listar(int pId)
        {
            Empresa objProveedor = null;
            SQL = "SELECT Proveedores.Id, Empresas.Id AS Id_Empresa, Empresas.Nombre, Empresas.CUIT, Empresas.Id_PersonaContacto, Personas.Id_DatosContacto AS ID_DatosContacto, Personas.Id AS Id_Persona, Personas.Nombre AS NombreContacto, Personas.Apellido AS ApellidoContacto, DatosContacto.Id AS Id_ContactoDatosContacto, DatosContacto.Email AS EmailContacto, DatosContacto.Telefono AS TelefonoContacto, DatosContacto.Direccion AS DireccionContacto, DatosContacto_1.Email AS EmailEmpresa, DatosContacto_1.Telefono AS TelefonoEmpresa, DatosContacto_1.Direccion AS DireccionEmpresa";
            SQL = SQL + " " + "FROM Proveedores";
            SQL = SQL + " " + "INNER JOIN Empresas ON Proveedores.Id_Empresa = Empresas.Id";
            SQL = SQL + " " + "LEFT OUTER JOIN DatosContacto AS DatosContacto_1 ON Empresas.Id_DatosContacto = DatosContacto_1.Id";
            SQL = SQL + " " + "LEFT OUTER JOIN DatosContacto";
            SQL = SQL + " " + "INNER JOIN Personas ON DatosContacto.Id = Personas.Id_DatosContacto ON Empresas.Id_PersonaContacto = Personas.Id";
            SQL = SQL + " " + "WHERE Proveedores.Id = @pId";
            objCommand = new SqlCommand(SQL, objConexion);
            SqlParameter Id = new SqlParameter("@pId", pId);
            objCommand.Parameters.Add(Id);
            try
            {
                objConexion.Open();

                objReader = objCommand.ExecuteReader();
                if (objReader.Read())
                {
                    DatosContacto objDatosContactoPersonaContacto = new DatosContacto(Convert.ToInt32(objReader["Id_ContactoDatosContacto"]), objReader["EmailContacto"].ToString(), objReader["TelefonoContacto"].ToString(), objReader["DireccionContacto"].ToString());
                    Persona objPersonaContacto = new Persona(Convert.ToInt32(objReader["Id_PersonaContacto"]), objReader["NombreContacto"].ToString(), objReader["ApellidoContacto"].ToString(), objDatosContactoPersonaContacto);
                    DatosContacto objDatosContactoEmpresa = new DatosContacto(Convert.ToInt32(objReader["Id_DatosContacto"]), objReader["EmailEmpresa"].ToString(), objReader["TelefonoEmpresa"].ToString(), objReader["DireccionEmpresa"].ToString());
                    objProveedor = new Empresa(Convert.ToInt32(objReader["Id"]), Convert.ToInt32(objReader["Id_Empresa"]), objReader["Nombre"].ToString(), objReader["CUIT"].ToString(), objPersonaContacto, objDatosContactoEmpresa); 
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
            return objProveedor;
        }

        public static void Agregar(Empresa pProveedor)
        {
            SQL = "INSERT INTO DatosContacto (Email, Telefono, Direccion)";
            SQL = SQL + " " + "VALUES(@Email, @Telefono, @Direccion)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandContactoDatosContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objEmailContacto = new SqlParameter("@Email", pProveedor.Contacto.DatosContacto.Email);
            SqlParameter objTelefonoContacto = new SqlParameter("@Telefono", pProveedor.Contacto.DatosContacto.Telefono);
            SqlParameter objDireccionContacto = new SqlParameter("@Direccion", pProveedor.Contacto.DatosContacto.Direccion);
            objCommandContactoDatosContacto.Parameters.Add(objEmailContacto);
            objCommandContactoDatosContacto.Parameters.Add(objTelefonoContacto);
            objCommandContactoDatosContacto.Parameters.Add(objDireccionContacto);

            SQL = "INSERT INTO Personas (Nombre, Apellido, Id_DatosContacto)";
            SQL = SQL + " " + "VALUES(@Nombre, @Apellido, @Id_DatosContacto)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandPersonaContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objPersonaContactoNombre = new SqlParameter("@Nombre", pProveedor.Contacto.Nombre);
            SqlParameter objPersonaContactoApellido = new SqlParameter("@Apellido", pProveedor.Contacto.Apellido);
            SqlParameter objPersonaContactoId_DatosContacto = new SqlParameter("@Id_DatosContacto", null);
            objCommandPersonaContacto.Parameters.Add(objPersonaContactoNombre);
            objCommandPersonaContacto.Parameters.Add(objPersonaContactoApellido);
            objCommandPersonaContacto.Parameters.Add(objPersonaContactoId_DatosContacto);

            SQL = "INSERT INTO DatosContacto (Email, Telefono, Direccion)";
            SQL = SQL + " " + "VALUES(@Email, @Telefono, @Direccion)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandDatosContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objEmail = new SqlParameter("@Email", pProveedor.DatosContacto.Email);
            SqlParameter objTelefono = new SqlParameter("@Telefono", pProveedor.DatosContacto.Telefono);
            SqlParameter objDireccion = new SqlParameter("@Direccion", pProveedor.DatosContacto.Direccion);
            objCommandDatosContacto.Parameters.Add(objEmail);
            objCommandDatosContacto.Parameters.Add(objTelefono);
            objCommandDatosContacto.Parameters.Add(objDireccion);

            SQL = "INSERT INTO Empresas (Nombre, CUIT, Id_PersonaContacto, Id_DatosContacto)";
            SQL = SQL + " " + "VALUES(@Nombre, @CUIT, @Id_PersonaContacto, @Id_DatosContacto)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandEmpresa = new SqlCommand(SQL, objConexion);
            SqlParameter objNombre = new SqlParameter("@Nombre", pProveedor.Nombre);
            SqlParameter objCUIT = new SqlParameter("@CUIT", pProveedor.CUIT);
            SqlParameter objId_PersonaContacto = new SqlParameter("@Id_PersonaContacto", null);
            SqlParameter objId_DatosContacto = new SqlParameter("@Id_DatosContacto", null);
            objCommandEmpresa.Parameters.Add(objNombre);
            objCommandEmpresa.Parameters.Add(objCUIT);
            objCommandEmpresa.Parameters.Add(objId_PersonaContacto);
            objCommandEmpresa.Parameters.Add(objId_DatosContacto);

            SQL = "INSERT INTO Proveedores (Id_Empresa)";
            SQL = SQL + " " + "VALUES(@Id_Empresa)";
            objCommand = new SqlCommand(SQL, objConexion);
            SqlParameter objId_Empresa = new SqlParameter("@Id_Empresa", null);
            objCommand.Parameters.Add(objId_Empresa);

            try
            {
                objConexion.Open();
                objTransaction = objConexion.BeginTransaction();

                objCommandContactoDatosContacto.Transaction = objTransaction;
                objCommandPersonaContacto.Transaction = objTransaction;
                objCommandDatosContacto.Transaction = objTransaction;
                objCommandEmpresa.Transaction = objTransaction;
                objCommand.Transaction = objTransaction;

                objPersonaContactoId_DatosContacto.Value = objCommandContactoDatosContacto.ExecuteScalar();
                objId_PersonaContacto.Value = objCommandPersonaContacto.ExecuteScalar();
                objId_DatosContacto.Value = objCommandDatosContacto.ExecuteScalar();
                objId_Empresa.Value = objCommandEmpresa.ExecuteScalar();
                objCommand.ExecuteNonQuery();

                objTransaction.Commit();
            }
            catch (Exception ex)
            {
                objTransaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }

        public static void Modificar(Empresa pProveedor)
        {
            SQL = "UPDATE DatosContacto SET Email=@Email, Telefono=@Telefono, Direccion=@Direccion";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommandContactoDatosContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objIdContacto = new SqlParameter("@Id", pProveedor.Contacto.DatosContacto.Id);
            SqlParameter objEmailContacto = new SqlParameter("@Email", pProveedor.Contacto.DatosContacto.Email);
            SqlParameter objTelefonoContacto = new SqlParameter("@Telefono", pProveedor.Contacto.DatosContacto.Telefono);
            SqlParameter objDireccionContacto = new SqlParameter("@Direccion", pProveedor.Contacto.DatosContacto.Direccion);
            objCommandContactoDatosContacto.Parameters.Add(objIdContacto);
            objCommandContactoDatosContacto.Parameters.Add(objEmailContacto);
            objCommandContactoDatosContacto.Parameters.Add(objTelefonoContacto);
            objCommandContactoDatosContacto.Parameters.Add(objDireccionContacto);

            SQL = "UPDATE Personas SET Nombre=@Nombre, Apellido=@Apellido";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommandPersonaContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objPersonaContactoId = new SqlParameter("@Id", pProveedor.Contacto.Id);
            SqlParameter objPersonaContactoNombre = new SqlParameter("@Nombre", pProveedor.Contacto.Nombre);
            SqlParameter objPersonaContactoApellido = new SqlParameter("@Apellido", pProveedor.Contacto.Apellido);
            objCommandPersonaContacto.Parameters.Add(objPersonaContactoId);
            objCommandPersonaContacto.Parameters.Add(objPersonaContactoNombre);
            objCommandPersonaContacto.Parameters.Add(objPersonaContactoApellido);

            SQL = "UPDATE DatosContacto SET Email=@Email, Telefono=@Telefono, Direccion=@Direccion";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommandDatosContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objId_DatosContacto = new SqlParameter("@Id", pProveedor.DatosContacto.Id);
            SqlParameter objEmail = new SqlParameter("@Email", pProveedor.DatosContacto.Email);
            SqlParameter objTelefono = new SqlParameter("@Telefono", pProveedor.DatosContacto.Telefono);
            SqlParameter objDireccion = new SqlParameter("@Direccion", pProveedor.DatosContacto.Direccion);
            objCommandDatosContacto.Parameters.Add(objId_DatosContacto);
            objCommandDatosContacto.Parameters.Add(objEmail);
            objCommandDatosContacto.Parameters.Add(objTelefono);
            objCommandDatosContacto.Parameters.Add(objDireccion);

            SQL = "UPDATE Empresas SET Nombre=@Nombre, CUIT=@CUIT";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommandEmpresa = new SqlCommand(SQL, objConexion);
            SqlParameter objId = new SqlParameter("@Id", pProveedor.Id);
            SqlParameter objNombre = new SqlParameter("@Nombre", pProveedor.Nombre);
            SqlParameter objCUIT = new SqlParameter("@CUIT", pProveedor.CUIT);
            objCommandEmpresa.Parameters.Add(objId);
            objCommandEmpresa.Parameters.Add(objNombre);
            objCommandEmpresa.Parameters.Add(objCUIT);

            try
            {
                objConexion.Open();
                objTransaction = objConexion.BeginTransaction();

                objCommandContactoDatosContacto.Transaction = objTransaction;
                objCommandPersonaContacto.Transaction = objTransaction;
                objCommandDatosContacto.Transaction = objTransaction;
                objCommandEmpresa.Transaction = objTransaction;

                objCommandEmpresa.ExecuteNonQuery();
                objCommandDatosContacto.ExecuteNonQuery();
                objCommandPersonaContacto.ExecuteNonQuery();
                objCommandContactoDatosContacto.ExecuteNonQuery();

                objTransaction.Commit();
            }
            catch (Exception ex)
            {
                objTransaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }

        public static void Eliminar(Empresa pProveedor)
        {

            SQL = "DELETE FROM Proveedores";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommand = new SqlCommand(SQL, objConexion);
            SqlParameter objId = new SqlParameter("@Id", pProveedor.Id);
            objCommand.Parameters.Add(objId);

            SQL = "DELETE FROM Empresas";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommandEmpresa = new SqlCommand(SQL, objConexion);
            SqlParameter objId_Empresa = new SqlParameter("@Id", pProveedor.Id_Empresa);
            objCommandEmpresa.Parameters.Add(objId_Empresa);

            SQL = "DELETE FROM DatosContacto";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommandDatosContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objDatosContactoId = new SqlParameter("@Id", pProveedor.DatosContacto.Id);
            objCommandDatosContacto.Parameters.Add(objDatosContactoId);

            SQL = "DELETE FROM Personas";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommandPersonaContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objId_PersonaContacto = new SqlParameter("@Id", pProveedor.Contacto.Id);
            objCommandPersonaContacto.Parameters.Add(objId_PersonaContacto);

            SQL = "DELETE FROM DatosContacto";
            SQL = SQL + " " + "WHERE Id = @Id";
            objCommandContactoDatosContacto = new SqlCommand(SQL, objConexion);
            SqlParameter objContactoDatosContactoId = new SqlParameter("@Id", pProveedor.Contacto.DatosContacto.Id);
            objCommandContactoDatosContacto.Parameters.Add(objContactoDatosContactoId);

            try
            {
                objConexion.Open();
                objTransaction = objConexion.BeginTransaction();

                objCommand.Transaction = objTransaction;
                objCommandEmpresa.Transaction = objTransaction;
                objCommandPersonaContacto.Transaction = objTransaction;
                objCommandDatosContacto.Transaction = objTransaction;
                objCommandContactoDatosContacto.Transaction = objTransaction;

                objCommand.ExecuteNonQuery();
                objCommandEmpresa.ExecuteNonQuery();
                objCommandPersonaContacto.ExecuteNonQuery();
                objCommandDatosContacto.ExecuteNonQuery();
                objCommandContactoDatosContacto.ExecuteNonQuery(); ;

                objTransaction.Commit();
            }
            catch (Exception ex)
            {
                objTransaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }
    }
}
