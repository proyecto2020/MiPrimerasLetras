using Dapper;
using Entidades;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Threading;
using System.Text;

namespace Persistencia
{

    public class SQLCliente
    {
        SqlCommand cmdRegistrar;
        SqlDataAdapter adaptador;
        private static string connectionString = ConfigurationManager.ConnectionStrings["MisPirmerasLetras.Properties.Settings.conexion"].ToString();
        private SqlConnection conexion = new SqlConnection(connectionString);
       
        private Respuesta<object> respuesta;
        private Respuesta<RespuestaLogin> respuestaLogin;

        public SQLCliente()
        {
            respuesta = new Respuesta<object>();
            respuestaLogin = new Respuesta<RespuestaLogin>();
        }

        public Collection<RespuestaLogin> ConsultarLogin(string usuario, string contrasena)
        {

            DynamicParameters parameter = new DynamicParameters();
            Collection<RespuestaLogin> objectoR = new Collection<RespuestaLogin>();
            string queryString = $"EXEC " + "PR_consultar_usuario_login "  +
                usuario + "," + contrasena + " ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                parameter.Add("@usuario", usuario);
                parameter.Add("@contrasena", contrasena);
                using (var multipleResponse = connection.QueryMultiple(queryString, parameter))
                {
                    objectoR = new ObservableCollection<RespuestaLogin>(multipleResponse.Read<RespuestaLogin>().ToList());
                }
            }
            return objectoR;
        }


        public Respuesta<object> ValidacionRegistroUsuario(Usuario usuario)
        {
            string contrasena = CreatePassword(10);
            DynamicParameters parameter = new DynamicParameters();
            string storedProcedure = RecursosSQL.InsertaUsuarios;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                parameter.Add("@fk_perfiles", usuario.IdPerfil);
                parameter.Add("@nombre", usuario.Nombre);
                parameter.Add("@primer_apellido", usuario.PrimerApellido);
                parameter.Add("@segundo_apellido", usuario.SegundoApellido);
                parameter.Add("@correo", usuario.Correo, DbType.String);
                parameter.Add("@estado", usuario.Estado);
                parameter.Add("@contrasena", contrasena);
                EnviarCorreo(usuario.Nombre, usuario.Correo, contrasena);
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
        // REFACTOR
        List<Usuario> Usuario = new List<Usuario>();
        public List<Usuario> mtdListarUsuariosPorPerfil(int perfil)
        {
            string consulta = "select  id_usuario, nombre, primer_apellido FROM usuario u WHERE NOT EXISTS(SELECT NULL FROM grupo g WHERE g.fk_usuario = u.id_usuario ) AND u.fk_perfiles = " + perfil +"";
            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);

            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Usuario objUsuario = new Usuario();
                objUsuario.IdUsuario = int.Parse(tblRol.Rows[i][0].ToString());
                objUsuario.Nombre = tblRol.Rows[i][1].ToString();
                objUsuario.PrimerApellido = tblRol.Rows[i][2].ToString();
                Usuario.Add(objUsuario);
            }
            return Usuario;
        }

        List<Grado> Grado = new List<Grado>();
        public List<Grado> mtdListarGrado()
        {
            string consulta = "select * from Grado";
            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);

            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Grado objGrado = new Grado();
                objGrado.IdGrado = int.Parse(tblRol.Rows[i][0].ToString());
                objGrado.Grados = tblRol.Rows[i][1].ToString();
                Grado.Add(objGrado);
            }
            return Grado;
        }

        public int mtdRegistrarGrado(Grado grado)
        {
            string storedProcedure = "INSERT INTO grado(grado) values ('" + grado.Grados +"')";
           
             int respuesta = this.mtdIDU(storedProcedure);
             return respuesta;
        }
        public int mtdRegistrarGrupo(Grupo grupo)
        {
            string storedProcedure = "INSERT INTO grupo(grupo, fk_grado, fk_usuario) values ('" + grupo.Grupos + "',"+ grupo.Grado+","+grupo.Usuario+")";

            int respuesta = this.mtdIDU(storedProcedure);
            return respuesta;
        }

        public int mtdMateriaArea(Materia materia = null, Area area = null)
        {
            string storedProcedure = "";
            int respuesta = 0;

            if (materia.NombreMateria != "")
            {
                storedProcedure = "INSERT INTO materia(materia, fecha_creacion) values ('" + materia.NombreMateria + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                respuesta = this.mtdIDU(storedProcedure);

            }

            if (area.AreaM!= "")
            {
                storedProcedure = "INSERT INTO area(area, fecha_creacion) values ('" + area.AreaM + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                respuesta = this.mtdIDU(storedProcedure);

            }

           
            return respuesta;
        
        
        }
        public int mtdAsociacionMateriaArea(Materia materia, int idArea)
        {
            string storedProcedure = "UPDATE materia SET fk_area = "+idArea+ " WHERE materia.id_materia = " + materia.IdMateria+"";

            int respuesta = this.mtdIDU(storedProcedure);
            return respuesta;
        }

        List<Area> area = new List<Area>();
        public List<Area> mtdListarArea()
        {
            string consulta = "select  id_area, area  from area";
            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);

            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Area objArea = new Area();
                objArea.IdArea = int.Parse(tblRol.Rows[i][0].ToString());
                objArea.AreaM = tblRol.Rows[i][1].ToString();
               
                area.Add(objArea);
            }
            return area;
        }

        List<Materia> materia = new List<Materia>();
        public List<Materia> mtdListarMateria()
        {
            string consulta = "select id_materia, materia  from materia";
            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);

            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Materia objMateria = new Materia();
                objMateria.IdMateria = int.Parse(tblRol.Rows[i][0].ToString());
                objMateria.NombreMateria = tblRol.Rows[i][1].ToString();

                materia.Add(objMateria);
            }
            return materia;
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
                    usuario.PrimerApellido = reader["primer_apellido"].ToString();
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
        public void EnviarCorreo(string nombre, string correo, string contrasena)
        {

            var mailService = new Persistencia.SoporteDeSistema();

            mailService.EnviarEmail(
                
                subject: "Bienvenido al sistema de  Jardin Infantil Mis Primeras Letras",
                cuerpo: "Hola " +  nombre + "\n te damos la Bienvenida a nuestra plataforma \n"+
                "esta es tu contraseña: " + contrasena + 
                "\n Recuerda que la puedes cambiar una vez ingreses a la plataforma",
                usuarioEmail: correo
                );
        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public int mtdIDU(string consulta)
        {
            conexion.Open(); //open
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
        public Respuesta<object> InsertarAlumnos(Alumnos alumnos)
        {
            DynamicParameters parameter = new DynamicParameters();
            string storedProcedure = RecursosSQL.InsertarAlumnos;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                parameter.Add("@nombres", alumnos.Nombres);
                parameter.Add("@PrimerApellido", alumnos.PrimerApellido);
                parameter.Add("@SegundoApellido", alumnos.SegundoApellido);
                parameter.Add("@FechaNacimiento", alumnos.FechaNacimiento);
                parameter.Add("@Acudiente", alumnos.Acudiente, DbType.String);
                parameter.Add("@Direccion", alumnos.Dirección,DbType.String);
                parameter.Add("@Telefono", alumnos.Telefono);
                parameter.Add("@Correo", alumnos.Correo, DbType.String);
                parameter.Add("@Observaciones", alumnos.Observaciones, DbType.String);
                parameter.Add("@IdGrupo", alumnos.IdGrupo);
                parameter.Add("@ocupacion", alumnos.Ocupacion);

                int rowAffected = connection.Execute(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
                respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }

            return respuesta;
        }

        public List<Grupo> mtdListarGrupo()
        {

            string consulta = "select grupo.grupo FROM grupo inner join grado ON grado.id_grado = grupo.fk_grado order by grupo.fk_grado desc";

            DataTable tblGrupo = new DataTable();
            List<Grupo> listaGrupo = new List<Grupo>();

            tblGrupo = this.mtdSelect(consulta);
           
            for (int i = 0; i < tblGrupo.Rows.Count; i++)
            {
                Grupo objGrupo = new Grupo();
                objGrupo.Grupos = tblGrupo.Rows[i][0].ToString();


                listaGrupo.Add(objGrupo);
            }

            return listaGrupo;


        }

        public string mtdValidacion(Grupo objGrupo = null)
        {
            string grp = "";
            string consulta = "select grupo from Grupo where grupo = @grupo";

            try
            {

                cmdRegistrar = new SqlCommand(consulta, conexion);
                cmdRegistrar.Parameters.AddWithValue("@grupo", objGrupo.Grupos);
                conexion.Open();
             

                 if(cmdRegistrar.ExecuteScalar() != null)
                {
                    return cmdRegistrar.ExecuteScalar().ToString();
                }
                else
                {
                    return grp;
                }
            }
            catch(Exception ex )
            {

            }
            finally
            {
                conexion.Close();
            }

            return grp;

        }
    }
}
