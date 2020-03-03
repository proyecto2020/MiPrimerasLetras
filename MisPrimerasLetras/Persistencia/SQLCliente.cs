using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{

    public class SQLCliente
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MisPirmerasLetras.Properties.Settings.conexion"].ToString();
        private SqlConnection conexion = new SqlConnection(connectionString);

        //private readonly Respuesta<Object> respuesta;
        //public SQLCliente(IConfiguration config) { 
        //    this._config = config; 
        //    responseMethod = new ResultResponse<object>(); objectList = new ResultResponse<object>(); }

        public List<Object> ObtenerLista(string usuario, string contrasena)
        {
            DynamicParameters parameter = new DynamicParameters();
            List<Object> resultados = null;
            string queryString = $"EXEC"+ "PR_consultar_usuario_login" +" "+
                usuario + " " + contrasena;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);                
                connection.Open();
                parameter.Add(usuario, contrasena);                
                try
                {
                    resultados = new ObservableCollection<Object>(SqlConnection.Read());
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

            return new List<string>();
        }

    }
}
