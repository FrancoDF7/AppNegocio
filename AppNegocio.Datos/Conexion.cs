using Microsoft.Data.SqlClient;
using System.Data;

namespace AppNegocio.Datos
{
    public class Conexion
    {
        public SqlConnection Conector;

        public Conexion()
        {
            //Variable de entorno con el string de conexión
            string strConexion = System.Environment.GetEnvironmentVariable("CONEXION_DB_STRING");

            if (string.IsNullOrWhiteSpace(strConexion))
            {
                throw new System.InvalidOperationException("No se pudo establecer la conexión. Defina la variable de entorno 'CONEXION_DB_STRING'");
            }

            this.Conector = new SqlConnection(strConexion); 
        }



    }
}
