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
using LinqToDB;
using LinqToDB.Data;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics.Contracts;

namespace Persistencia
{

    public class SQLCliente : DataConnection
    {
        SqlCommand cmdRegistrar;
        SqlDataAdapter adaptador;
        private static string connectionString = ConfigurationManager.ConnectionStrings["MisPirmerasLetras.Properties.Settings.conexion"].ToString();
        private SqlConnection conexion = new SqlConnection(connectionString);

        /**************************************
          *                                    *
          *      CODIGO DE COFIGURACION        * 
          *                                    *
          **************************************/
            /* INSTANCIAS DE TABLAS LINQTO*/
        public ITable<Alumnos> TAlumnos { get { return GetTable<Alumnos>(); } }
        public ITable<Pagos> TPagos { get { return GetTable<Pagos>(); } }
        public ITable<gradoMateria> TGradoMateria { get { return GetTable<gradoMateria>(); } }
        public ITable<Materia> TMateria { get { return GetTable<Materia>(); } }






        private Respuesta<object> respuesta;
        private Respuesta<RespuestaLogin> respuestaLogin;
        DataTable tblGeneralRetorno = new DataTable();



        /***********************************/
        /* INSTANCIAS DE LISTA DE OBJETOS*/
        List<gradoMateria> GradoMaterias = new List<gradoMateria>();
        List<Perfiles> Perfiles = new List<Perfiles>();
        List<DiaHora> diaHoras = new List<DiaHora>();
        List<Salones> salones = new List<Salones>();
        List<Usuario> Usuario = new List<Usuario>();
        List<Grado> Grado = new List<Grado>();
        List<Area> area = new List<Area>();
        List<Materia> materia = new List<Materia>();

                     /* END */
        /***********************************/



        public SQLCliente()
        {
            respuesta = new Respuesta<object>();
            respuestaLogin = new Respuesta<RespuestaLogin>();
        }

        public Collection<RespuestaLogin> ConsultarLogin(string usuario, string contrasena)
        {

            DynamicParameters parameter = new DynamicParameters();
            Collection<RespuestaLogin> objectoR = new Collection<RespuestaLogin>();
            //Comment J.B 25.03.2020
            string queryString = $"EXEC " + "PR_consultar_usuario_login " +
                usuario + "," + contrasena + " ";
            //End Comment J.B 25.03.2020
            //Add J.B 25.03.2020
            //string queryString = $"EXEC " + "PR_consultar_usuario_login " +
            //    usuario + ",'" + this.Encripsha512(contrasena) + "' ";
            //End Add J.B 25.03.2020

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                parameter.Add("@usuario", usuario);

                //Comment J.B 25.03.2020
                ////parameter.Add("@contrasena", contrasena);
                //End Comment J.B 25.03.2020
                //Add J.B 25.03.2020
                parameter.Add("@contrasena", contrasena);
                //End Add J.B 25.03.2020
                using (var multipleResponse = connection.QueryMultiple(queryString, parameter))
                {
                    objectoR = new ObservableCollection<RespuestaLogin>(multipleResponse.Read<RespuestaLogin>().ToList());
                }

                if (objectoR.Count > 0)
                {

                    SoporteControlador.CacheUsuario.Perfil = objectoR[0].perfil;
                    SoporteControlador.CacheUsuario.NombreUsuario = objectoR[0].nombre;
                    SoporteControlador.CacheUsuario.ApellidoUsuario = objectoR[0].primer_apellido;
                    SoporteControlador.CacheUsuario.Correo = objectoR[0].correo;

                }
            }
            conexion.Close();

            return objectoR;
        }


        public Respuesta<object> ValidacionRegistroUsuario(Usuario usuario)
        {
            string contrasena = CreatePassword(10);
            //Add J.B 25.03.2020
            contrasena = this.Encripsha512(contrasena);
            //End Add J.B 25.03.2020
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
       
        public List<Perfiles> mtdListarPerfiles()
        {
            string consulta = RecursosSQL.ConsultaPerfiles;
            tblGeneralRetorno = this.mtdSelect(consulta);

            for (int i = 0; i < tblGeneralRetorno.Rows.Count; i++)
            {
                Perfiles objPerfil = new Perfiles();
                objPerfil.IdPerfil = int.Parse(tblGeneralRetorno.Rows[i][0].ToString());
                objPerfil.Perfil = tblGeneralRetorno.Rows[i][1].ToString();
                Perfiles.Add(objPerfil);
            }
            return Perfiles;
        }

       
        public List<DiaHora> mtdListarHoras()
        {
            string consulta = "select dia_hora.id_dia_hora, dia_hora.hora_inicial, dia_hora.hora_final from dia_hora";

            tblGeneralRetorno = this.mtdSelect(consulta);

            for (int i = 0; i < tblGeneralRetorno.Rows.Count; i++)
            {
                DiaHora objDiaHora = new DiaHora();
                objDiaHora.id_dia_hora = int.Parse(tblGeneralRetorno.Rows[i][0].ToString());
                objDiaHora.HoraInicial = int.Parse(tblGeneralRetorno.Rows[i][1].ToString());
                objDiaHora.HoraFinal = int.Parse(tblGeneralRetorno.Rows[i][2].ToString());



                diaHoras.Add(objDiaHora);
            }
            return diaHoras;
        }

       
        public List<Salones> mtdListarSalones(int id_grupo = 0)
        {
            string consulta = "";
            if (id_grupo > 0)
            {
                //seleccionar 
                consulta = "SELECT  salon.id_salon, salon.nombre,  salon.sede FROM salon INNER JOIN horario h ON h.fk_salon = salon.id_salon WHERE h.fk_grupo = " + id_grupo + "GROUP BY  salon.nombre, salon.id_salon, salon.sede";
            }
            else
            {
                // seleccionar salones donde no esten asociados a un grupo o horario
                //SELECT * FROM salon WHERE NOT EXISTS(SELECT 1 FROM   horario WHERE  salon.id_salon = horario.fk_salon)
                consulta = "SELECT * FROM salon WHERE NOT EXISTS(SELECT 1 FROM   grupo WHERE  salon.id_salon = grupo.fk_salon)";
            }


            tblGeneralRetorno = this.mtdSelect(consulta);

            for (int i = 0; i < tblGeneralRetorno.Rows.Count; i++)
            {
                Salones objSalon = new Salones();
                objSalon.IdSalon = int.Parse(tblGeneralRetorno.Rows[i][0].ToString());
                objSalon.Nombre = tblGeneralRetorno.Rows[i][1].ToString();
                objSalon.Sede = tblGeneralRetorno.Rows[i][2].ToString();




                salones.Add(objSalon);
            }
            return salones;
        }


        
        public List<Usuario> mtdListarUsuariosPorPerfil(int perfil)
        {
           // string consulta = "select  id_usuario, nombre, primer_apellido from usuario where fk_perfiles = " + perfil;

           string consulta = "select  id_usuario, nombre, primer_apellido FROM usuario u WHERE NOT EXISTS(SELECT NULL FROM grupo g WHERE g.fk_usuario = u.id_usuario ) AND u.fk_perfiles = " + perfil + "";
            tblGeneralRetorno = this.mtdSelect(consulta);

            for (int i = 0; i < tblGeneralRetorno.Rows.Count; i++)
            {
                Usuario objUsuario = new Usuario();
                objUsuario.IdUsuario = int.Parse(tblGeneralRetorno.Rows[i][0].ToString());
                objUsuario.Nombre = tblGeneralRetorno.Rows[i][1].ToString();
                objUsuario.PrimerApellido = tblGeneralRetorno.Rows[i][2].ToString();
                Usuario.Add(objUsuario);
            }
            return Usuario;
        }

       
        public List<Grado> mtdListarGrado()
        {
             string consulta = "select id_grado, grado from Grado";

            tblGeneralRetorno = this.mtdSelect(consulta);

            for (int i = 0; i < tblGeneralRetorno.Rows.Count; i++)
            {
                Grado objGrado = new Grado();
                objGrado.IdGrado = int.Parse(tblGeneralRetorno.Rows[i][0].ToString());
                objGrado.Grados = tblGeneralRetorno.Rows[i][1].ToString();
                Grado.Add(objGrado);
            }
            return Grado;
        }

        public int mtdRegistrarGrado(Grado grado)
        {
            string storedProcedure = RecursosSQL.insertar_grado;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {



                SqlCommand myCommand = new SqlCommand(storedProcedure, connection);
                myCommand.CommandType = CommandType.StoredProcedure;


                myCommand.Parameters.AddWithValue("@grado", grado.Grados);
                myCommand.Parameters.AddWithValue("@usuario_creacion", "pepe");

                //myCommand.ExecuteNonQuery();
                connection.Open();

                Int32 IdCreado = Convert.ToInt32(myCommand.ExecuteScalar());
                return IdCreado;

            }



        }
        public int mtdRegistrarGrupo(Grupo grupo)
        {
            string storedProcedure = "INSERT INTO grupo(grupo, fk_grado, fk_usuario, fk_salon) values ('" + grupo.grupo + "'," + grupo.Grado + "," + grupo.Usuario + "," + grupo.fk_salon + ")";

            int respuesta = this.mtdIDU(storedProcedure);
            return respuesta;
        }

        public int ObtenerIdS(string materia)
        {
            int id = 0;
            switch (materia)
            {
                case "Biología":
                    id = 1;
                    break;

                case "Sociales":
                    id = 2;
                    break;

                case "Artes Plásticas":
                    id = 3;
                    break;

                case "Música":
                    id = 1002;
                    break;
                case "Ética":
                    id = 1004;
                    break;
                case "Religión":
                    id = 1005;
                    break;
                case "Educación Física":
                    id = 1006;
                    break;
                case "Danzas":
                    id = 1007;
                    break;
                case "Lengua Castellana":
                    id = 1008;
                    break;
                case "inglés":
                    id = 1009;
                    break;
                case "Matemáticas":
                    id = 1010;
                    break;
                case "Informática":
                    id = 1011;
                    break;

                default:
                    throw new System.InvalidOperationException("No existe tal materia!");
               
                   
            }

            return id;
        }

        public Respuesta<object> mtdRegistrarGradoMateria(string materia, string hora, int grado)
        {
            int Idmateria = this.ObtenerIdS(materia);
            DynamicParameters parameter = new DynamicParameters();
            string storedProcedure = RecursosSQL.insertarGradoMateria;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                parameter.Add("@fk_grado", grado);
                parameter.Add("@fk_materia", Idmateria);
                parameter.Add("@horas", int.Parse(hora));



                int rowAffected = connection.Execute(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
                respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }

            return respuesta;

        }

        public int mtdActualizarGradoMateria(string materia, string hora, int grado)
        {
            int Idmateria = this.ObtenerIdS(materia);
            string storedProcedure = "UPDATE gradoMateria SET horas = "+int.Parse(hora) +" WHERE fk_grado ="+grado+ " AND fk_materia = "+Idmateria+"";

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

            if (area.AreaM != "")
            {
                storedProcedure = "INSERT INTO area(area, fecha_creacion) values ('" + area.AreaM + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                respuesta = this.mtdIDU(storedProcedure);

            }


            return respuesta;


        }
        public int mtdAsociacionMateriaArea(Materia materia, int idArea)
        {
            string storedProcedure = "UPDATE materia SET fk_area = " + idArea + " WHERE materia.id_materia = " + materia.IdMateria + "";

            int respuesta = this.mtdIDU(storedProcedure);
            return respuesta;
        }

  
        public List<Area> mtdListarArea()
        {
            string consulta = "select  id_area, area  from area";

            tblGeneralRetorno = this.mtdSelect(consulta);

            for (int i = 0; i < tblGeneralRetorno.Rows.Count; i++)
            {
                Area objArea = new Area();
                objArea.IdArea = int.Parse(tblGeneralRetorno.Rows[i][0].ToString());
                objArea.AreaM = tblGeneralRetorno.Rows[i][1].ToString();

                area.Add(objArea);
            }
            return area;
        }


       
        public  List<object> mtdListarIntensidadHoraria(int id_grado)
        {

            DataTable tblgradoMaterias = new DataTable();
            List<object> gradoMaterias = new List<object>();

            string consulta = "select m.materia, gm.horas from gradoMateria gm INNER JOIN materia m ON m.id_materia = gm.fk_materia  where fk_grado = " + id_grado;


            tblgradoMaterias = this.mtdSelect(consulta);

            for (int i = 0; i < tblgradoMaterias.Rows.Count; i++)
            {
               
                string Materia_nombre  = tblgradoMaterias.Rows[i][0].ToString();
                int thoras  = int.Parse(tblgradoMaterias.Rows[i][1].ToString());
                var newObject = new { Materia = Materia_nombre, Horas = thoras }; // creamos un objeto anonimo ya que necesitamos lo que n

                gradoMaterias.Add(newObject);
            }
            
            return gradoMaterias;

          

        }

        public List<Materia> mtdListarMateria()
        {
          
             string consulta = "select id_materia, materia  from materia";


            tblGeneralRetorno = this.mtdSelect(consulta);

            for (int i = 0; i < tblGeneralRetorno.Rows.Count; i++)
            {
                Materia objMateria = new Materia();
                objMateria.IdMateria = int.Parse(tblGeneralRetorno.Rows[i][0].ToString());
                objMateria.NombreMateria = tblGeneralRetorno.Rows[i][1].ToString();

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

            conexion.Close();

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
        public int InsertarAlumnos(Alumnos alumnos)
        {
            
            DynamicParameters parameter = new DynamicParameters();
            string storedProcedure = RecursosSQL.InsertarAlumnos;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                

                SqlCommand myCommand = new SqlCommand(storedProcedure, connection);
                myCommand.CommandType = CommandType.StoredProcedure;
                

                myCommand.Parameters.AddWithValue("@nombres", alumnos.nombre);
                myCommand.Parameters.AddWithValue("@PrimerApellido", alumnos.primer_apellido);
                myCommand.Parameters.AddWithValue("@SegundoApellido", alumnos.segundo_apellido);
                myCommand.Parameters.AddWithValue("@FechaNacimiento", alumnos.fecha_nacimiento);
                myCommand.Parameters.AddWithValue("@Acudiente", alumnos.acudiente).SqlDbType.ToString();
                myCommand.Parameters.AddWithValue("@Direccion", alumnos.direccion).SqlDbType.ToString(); ;
                myCommand.Parameters.AddWithValue("@Telefono", alumnos.telefono);
                myCommand.Parameters.AddWithValue("@Correo", alumnos.correo).SqlDbType.ToString(); ;
                myCommand.Parameters.AddWithValue("@Observaciones", alumnos.observaciones).SqlDbType.ToString(); ;
                myCommand.Parameters.AddWithValue("@ocupacion", alumnos.ocupacion);
                //myCommand.ExecuteNonQuery();
                connection.Open();

                Int32  IdCreado = Convert.ToInt32(myCommand.ExecuteScalar());
                return IdCreado;

            }

           
        }



        public int InsertarPago(Pagos tblPagos)
        {

            DynamicParameters parameter = new DynamicParameters();
            string storedProcedure = RecursosSQL.InsertarPago;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand myCommand = new SqlCommand(storedProcedure, connection);
                myCommand.CommandType = CommandType.StoredProcedure;


                myCommand.Parameters.AddWithValue("@fk_alumno", tblPagos.fk_alumno);
                myCommand.Parameters.AddWithValue("@total", tblPagos.total);
                myCommand.Parameters.AddWithValue("@saldo", tblPagos.saldo);
                myCommand.Parameters.AddWithValue("@abono", tblPagos.abono);
                myCommand.Parameters.AddWithValue("@mes", tblPagos.mes);
                myCommand.Parameters.AddWithValue("@usuario_modificacion", "PEPE");
                myCommand.Parameters.AddWithValue("@fecha_limite", tblPagos.fecha_limite);
                
                //myCommand.ExecuteNonQuery();
                connection.Open();

                Int32 IdCreado = Convert.ToInt32(myCommand.ExecuteScalar());
                return IdCreado;

            }


        }

        public Respuesta<object> InsertarMatricula(Matricula tblMatricula)
        {
            DynamicParameters parameter = new DynamicParameters();
            string storedProcedure = RecursosSQL.InsertarMatricula;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                parameter.Add("@fk_alumno", tblMatricula.fk_alumno);
                parameter.Add("@fk_grupo", tblMatricula.fk_grupo);
                parameter.Add("@fk_pagos", tblMatricula.fk_pagos);
                parameter.Add("@usuario_creacion", tblMatricula.usuario_creacion);
                

                int rowAffected = connection.Execute(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
                respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }

            return respuesta;
        }



        public List<Grupo> mtdListarGrupo(int idGrupo = 0)
        {

            string concat = "";

            if (idGrupo > 0)
            {
                // buscamos mi grado(TRANSICION) desde mi grupo (TRANSICION B)
              
                    concat = "WHERE  grupo.id_grupo = "+idGrupo+"";

                
            }

            //string consulta = "select grupo.id_grupo, grupo.grupo FROM grupo inner join grado ON grado.id_grado = grupo.fk_grado order by grupo.fk_grado desc";
            string consulta = "select grupo.id_grupo, grupo.grupo, grupo.fk_grado FROM grupo " + concat+"  order by grupo.id_grupo desc";

           
            List<Grupo> listaGrupo = new List<Grupo>();

            tblGeneralRetorno = this.mtdSelect(consulta);

            for (int i = 0; i < tblGeneralRetorno.Rows.Count; i++)
            {
                Grupo objGrupo = new Grupo();
                objGrupo.id_grupo = int.Parse(tblGeneralRetorno.Rows[i][0].ToString());
                objGrupo.grupo = tblGeneralRetorno.Rows[i][1].ToString();
                objGrupo.Grado = int.Parse(tblGeneralRetorno.Rows[i][2].ToString());


                listaGrupo.Add(objGrupo);
            }

            return listaGrupo;


        }
        public List<Alumnos> mtdListarAlumnos()
        {
            List<Alumnos> lstAlumnos = new List<Alumnos>();
            lstAlumnos = TAlumnos.ToList();
            return lstAlumnos;
        }

        public List<Alumnos> mtdBuscarAlumnos(string campo)
        {
            List<Alumnos> lstAlumnos = new List<Alumnos>();
            lstAlumnos = TAlumnos.Where(a => a.correo.StartsWith(campo) || a.nombre.StartsWith(campo)
               || a.primer_apellido.StartsWith(campo)).ToList();

            return lstAlumnos;
        }



        public List<Pagos> mtdListarPagos(int idAlumno)
        {
            DataTable tblPagos = new DataTable();
            List<Pagos> listaPagos = new List<Pagos>();
             
            var query = TAlumnos.Join(TPagos,
                     t => t.id_alumno,
                     a => a.fk_alumno,
                    (t, a) => new
                    {
                    
                        a.id_pago,
                        a.fk_alumno,
                        a.total,
                        a.saldo,
                        a.abono,
                        a.mes,
                        a.paz_y_salvo,
                        a.fecha_limite,
                        a.fecha_modificacion,
                        a.ticket

                    }).Where(a => a.fk_alumno.Equals(idAlumno) && a.fecha_modificacion.Equals(null)).ToList();

            if (0 < query.Count)
            {
                foreach (var item in query)
                {
                    var cliente = new Pagos
                    {
                        id_pago = item.id_pago,
                        fk_alumno = item.fk_alumno,
                        total = item.total,
                        saldo = item.saldo,
                        abono = item.abono,
                        mes = item.mes,
                        paz_y_salvo = item.paz_y_salvo,
                        fecha_limite = item.fecha_limite,
                        ticket = item.ticket

                    };
                    listaPagos.Add(cliente);
                }
                

            }
            return listaPagos;
        }

        public int mtdIngresarPago(Pagos objPagos, int id_pago)
        {
            TPagos.Where(u => u.id_pago.Equals(id_pago))
                                                                      .Set(u => u.fecha_modificacion, DateTime.Now)
                                                                      .Update();

            int retorno =  TPagos.Value(u => u.fk_alumno, objPagos.fk_alumno)
                                          .Value(u => u.abono, objPagos.abono)
                                               .Value(u => u.saldo, objPagos.saldo)
                                               .Value(u => u.mes, objPagos.mes)
                                               .Value(u => u.ticket, objPagos.ticket)
                                               .Value(u => u.total, objPagos.total)
                                               .Value(u => u.fecha_creacion, DateTime.Now)
                                               .Value(u => u.fecha_limite, objPagos.fecha_limite)
                                               .Value(u => u.paz_y_salvo, objPagos.paz_y_salvo)
                                               .Value(u => u.usuario_modificacion, "SSS")
                                               .Insert();
     
           
            return retorno;
        }

        public string mtdValidacion(Grupo objGrupo = null, Grado objGrado = null)
        {
            string grp = "";
            string consulta = "";
            string parametro = "";
            object objValue = null; // por default
            if (objGrupo != null)
            {
                consulta = "select grupo from Grupo where grupo = @grupo";
                parametro = "@grupo";
                objValue = objGrupo.grupo;

            }
            else if (objGrado != null)
            {
                consulta = "select grado from grado where grado = @grado";
                parametro = "@grado";
                objValue = objGrado.Grados;



            }
            try
            {

                cmdRegistrar = new SqlCommand(consulta, conexion);
                cmdRegistrar.Parameters.AddWithValue(parametro, objValue);
                conexion.Open();


                if (cmdRegistrar.ExecuteScalar() != null)
                {
                    return cmdRegistrar.ExecuteScalar().ToString();
                }
                else
                {
                    return grp;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexion.Close();
            }

            return grp;

        }

       
        public int  mtdValidacionHorario(string id_hora, string dia, string materia, int id_grupo)
        {
            
            string consulta = "";
            int respuesta = 0;
            int _idMateria = this.ObtenerIdS(materia);
            int _idHora = this.IdsHoras(id_hora);
            List <Grupo> grado = this.mtdListarGrupo(id_grupo); //obtenemos el grado de este grupo 

            //validamos la intensidad horara de una materia en el grupo, 
            //validamos que esa hora no este asiganada a una materia en el mismo grupo
            //validar que se puede agregar la misma hora, la misma materia pero diferente dia
            //validar que o haya otro registro y que no se hagan doble registro cuando el usuario de enter otra vez y cuando cargue el horario que no se guarden los nuevos items en el list view 
            gradoMateria objUsuario = new gradoMateria();
            if (_idHora > 0)
            {
                //validamos la intenisidad horaria
                consulta = "SELECT gm.horas from gradoMateria gm where  gm.fk_materia = "+ _idMateria +"AND gm.fk_grado ="+ grado[0].Grado + "";

                tblGeneralRetorno = this.mtdSelect(consulta);

                if (tblGeneralRetorno.Rows.Count.Equals(0))
                {
                    return -1;
                }

                objUsuario.horas = int.Parse(tblGeneralRetorno.Rows[0][0].ToString());

                GradoMaterias.Add(objUsuario);
               
            }

            //sino optenemos resultados insertamos 
            if(_idHora <= objUsuario.horas )
            {
                respuesta = this.mtdInsertarIntensidadHoraria(id_grupo, _idHora, dia, _idMateria);
            }

            return respuesta;

        }

        public int mtdInsertarIntensidadHoraria(int id_grupo, int hora, string  dia, int materia)
        {
            string consulta = "";

            if (id_grupo > 0)
            {
                 consulta = "INSERT INTO horario(fk_grupo, fk_dia_hora, dia, fk_materia) VALUES("+id_grupo+","+ hora + ",'" +dia+"',"+materia+")";     
            }

            int respuesta = this.mtdIDU(consulta);
            return respuesta;

            // consulta = "SELECT * FROM horario INNER JOIN dia_hora dh ON dh.id_dia_hora = horario.fk_dia_hora where horario.fk_dia_hora = @idHora AND fk_grupo = @idGrupo AND dia = @dia";
            //try
            //{

            //    cmdRegistrar = new SqlCommand(consulta, conexion);
            //    SqlParameter idHora = new SqlParameter("@idHora", SqlDbType.Int);
            //    SqlParameter idGrupo = new SqlParameter("@idGrupo", SqlDbType.Int);
            //    SqlParameter nDia = new SqlParameter("@dia", SqlDbType.VarChar);

            //    idHora.Value = id_hora;
            //    idGrupo.Value = id_grupo;
            //    nDia.Value = dia;

            //    cmdRegistrar.Parameters.Add(idHora);
            //    cmdRegistrar.Parameters.Add(idGrupo);
            //    cmdRegistrar.Parameters.Add(nDia);
            //    conexion.Open();
            //    SqlDataReader myReader = cmdRegistrar.ExecuteReader(CommandBehavior.CloseConnection);



            //    Console.WriteLine(consulta);
            //    if (myReader.Read() == true)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //finally
            //{
            //    conexion.Close();
            //}

            //return false;

        }

        //Add J.B 25.03.2020
        public string Encripsha512(string im_contra)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(im_contra);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

        private int IdsHoras(string horas)
        {
            int id = 0;
            switch (horas)
            {
                    case "7 A 8":
                    id = 1;
                    break;case "8 A 9":
                    id = 2;
                    break;case "10 A 11":
                    id = 3;
                    break;case "11 A 12":
                    id = 4;
                    break;case "12 A 13":
                    id = 5;
                    break;case "14 A 15":
                    id = 6;
                    break;

            }

            return id;
        }
        //End Add J.B 25.03.2020
    
    
        //private object mtdBusquedaAvanzada(string consulta, List<Object> lista, int id, string nombre )
        //{
        //    DataTable tblRol = new DataTable();
        //    tblRol = this.mtdSelect(consulta);

        //    for (int i = 0; i < tblRol.Rows.Count; i++)
        //    {
        //        Materia objMateria = new Materia();
        //            id   = int.Parse(tblRol.Rows[i][0].ToString());
        //            nombre  = tblRol.Rows[i][1].ToString();

        //        lista.Add(objMateria);
        //    }
        //    return lista;
        //}
    }
}
