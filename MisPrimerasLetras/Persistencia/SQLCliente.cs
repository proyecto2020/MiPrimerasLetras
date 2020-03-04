using Dapper;
using Entidades;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace Persistencia
{
   
    public class SQLCliente
    {
        SqlCommand cmdRegistrar;
        SqlDataAdapter adaptador;
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
            string queryString = $"EXEC"+ "PR_consultar_usuario_login" +" "+
                usuario + " " + contrasena +" ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);                
                connection.Open();
                parameter.Add("@usuario",usuario);
                parameter.Add("@contrasena", contrasena);
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
       
 
        public int mtdRegistrarUsario(Usuario obUser)
        {
            //URG! ADD PASSWORD AL OBJETO USER, VERFICAR LAS COMILLAS
            string consulta = "insert into Usuario(Nombre,PrimerApellido,SegundoApellido,Correo,IdPerfil)"+
                 "values(" + obUser.Nombre + ",'" + obUser.PirmerApellido + "','" + obUser.SegundoApellido +
                 "','" + obUser.Correo + "'," +obUser.IdPerfil +")";


            int registros = this.mtdIDU(consulta);
         
            return registros;

        }

        //LISTAR PERFILES
        List<Perfiles> Perfiles = new List<Perfiles>();
        public List<Perfiles> mtdListarPerfiles()
        {
            string consulta = "select * from Perfil";
            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);

            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Perfiles objPerfil = new Perfiles();
                objPerfil.IdPerfil = int.Parse(tblRol.Rows[i][0].ToString());
                objPerfil.Perfil = tblRol.Rows[i][1].ToString();
                Perfiles.Add(objPerfil);
            }
            return Perfiles;
        }

        /// <summary>
        /// Este metodo hace la administracion de datos(incert-delete-up)
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public int mtdIDU(string consulta)
        {
            //conexion.Open();
            cmdRegistrar = new SqlCommand();
            cmdRegistrar.Connection = conexion;
            cmdRegistrar.CommandText = consulta;
            int cantidad = cmdRegistrar.ExecuteNonQuery();
            conexion.Close();
            return cantidad;
        }

        public DataTable mtdSelect(string consulta)
        {
            //conexion.Open();
            adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;
        }
    }
}
