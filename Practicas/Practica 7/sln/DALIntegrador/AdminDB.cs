using System.Data.SqlClient;

namespace DALIntegrador
{
    internal class AdminDB
    {

        private static SqlConnection conn;

        private static AdminDB instance;

        private AdminDB()
        {

        }

        public static AdminDB Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new AdminDB();
                    conn = new SqlConnection(Properties.Settings.Default.dbCurso);
                }
                return instance;
            }
        }

        public SqlConnection ConectarDB()
        {
            conn.Open();
            return conn;
        }

        public void CerrarConexion()
        {
            conn.Close();
        }
    }
}