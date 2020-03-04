using Dapper;
using Entidades;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Persistencia
{

    public class SQLCliente
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MisPirmerasLetras.Properties.Settings.conexion"].ToString();
        private SqlConnection conexion = new SqlConnection(connectionString);

        private Respuesta<object> respuesta;
       
        public SQLCliente()
        {
            respuesta = new Respuesta<object>();
        }

        public string ObtenerLista(string usuario, int contrasena)
        {
            DynamicParameters parameter = new DynamicParameters();
            string resultados = null;
            string queryString = $"EXEC"+ "PR_consultar_usuario_login"+" "+
                usuario + " " + contrasena+" ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);                
                connection.Open();
                parameter.Add("@usuario",  "@contrasena");
                using (var multipleResponse = connection.QueryMultiple(queryString, parameter))
                {
                    if (resultados == null)
                    {
                        Console.WriteLine("se murio");
                    }
                }       
            }
            return resultados;
        }

    }
}
