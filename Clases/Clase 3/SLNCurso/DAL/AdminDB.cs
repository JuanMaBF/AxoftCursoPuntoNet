using System.Data.SqlClient;

namespace DAL
{
    internal static class AdminDB
    {

        private static SqlConnection conn;

        internal static SqlConnection ConectarDB()
        {
            conn = new SqlConnection(Properties.Settings.Default.dbCurso);
            conn.Open();
            return conn;
        }

        internal static void CerrarConexion()
        {
            conn.Close();
        }

    }
}
