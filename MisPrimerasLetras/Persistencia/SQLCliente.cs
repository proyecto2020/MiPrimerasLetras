using Dapper;
using Entidades;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

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

        public Respuesta<object> ObtenerLista(string usuario, string contrasena)
        {

            DynamicParameters parameter = new DynamicParameters();
            Collection<object> objectoR = null;
            string queryString = $"EXEC " + "PR_consultar_usuario_login " +
                usuario + "," + contrasena + " ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                parameter.Add("@usuario", usuario);
                parameter.Add("@contrasena", contrasena);
                using (var multipleResponse = connection.QueryMultiple(queryString, parameter))
                {
                    objectoR = new ObservableCollection<object>(multipleResponse.Read<object>().ToList());
                    respuesta.ResultData = objectoR;
                }
            }
            return respuesta;
        }


        public Respuesta<object> mtdRegistrarUsario(Usuario usuario)
        {
            DynamicParameters parameter = new DynamicParameters();
            string storedProcedure = RecursosSQL.InsertaUsuarios;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                parameter.Add("@fk_perfiles", usuario.IdPerfil);
                parameter.Add("@nombre", usuario.Nombre);
                parameter.Add("@primer_apellido", usuario.PirmerApellido);
                parameter.Add("@segundo_apellido", usuario.SegundoApellido);
                parameter.Add("@correo", usuario.Correo, DbType.String);
                parameter.Add("@estado", usuario.Estado);
                parameter.Add("@contrasena", usuario.contrasena);
                int rowAffected = connection.Execute(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
                respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }

            return respuesta;
        }
        List<Perfiles> Perfiles = new List<Perfiles>();
        public List<Perfiles> mtdListarPerfiles()
        {
            string consulta = RecursosSQL.ConsultaPerfiles;
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
        public List<Usuario> ConsultarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string consulta = RecursosSQL.ConsultaUsuarios;
            SqlCommand command = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Perfil = reader["perfil"].ToString();
                    usuario.Nombre = reader["nombre"].ToString();
                    usuario.PirmerApellido = reader["primer_apellido"].ToString();
                    usuario.SegundoApellido = reader["segundo_apellido"].ToString();
                    usuario.Correo = reader["correo"].ToString();

                    lista.Add(usuario);
                }
            }
            finally
            {
                reader.Close();
            }

            return lista;
        }
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
            adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;
        }
    }
}
