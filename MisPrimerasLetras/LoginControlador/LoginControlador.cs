using Entidades;
using Microsoft.Extensions.Configuration;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LoginControlador
{
    public class LoginControlador : SQLCliente
    {
        public SQLCliente cliente;
        private int _reg_por_pagina, _num_pagina = 1;
        public int _seccion { get; set; }
        private int _idCliente = 0;
 
        public LoginControlador()
        {
            this.cliente = new SQLCliente();
        }


        public Collection<RespuestaLogin> ConsultarLogin(string usuario, string clave)
        {
            Collection<RespuestaLogin> resultado = this.cliente.ConsultarLogin(usuario, clave);
            return resultado;
        }


        public Respuesta<object> ValidacionRegistroUsuario(Usuario usuario)
        {
            var respuesta = this.cliente.ValidacionRegistroUsuario(usuario);
            return respuesta;
        }

        public List<DiaHora> ConsultarHoras()
        {
            var resultado = this.cliente.mtdListarHoras();
            return resultado;
        }
        public List<Perfiles> ConsultarPerfiles()
        {
            var resultado = this.cliente.mtdListarPerfiles();
            return resultado;
        }

        public List<Usuario> ConsultarUsuarios()
        {
            var resultado = this.cliente.ConsultarUsuarios();
            return resultado;
        }

        public List<Usuario> ConsultarProfesores()
        {
            var resultado = this.cliente.mtdListarUsuariosPorPerfil(Perfiles.DOCENTE);
            return resultado;
        }

        List<Grado> resultadoGrados = new List<Grado>();
        public List<Grado> ConsultarGrado()
        {
            resultadoGrados = this.cliente.mtdListarGrado();
            return resultadoGrados;
        }


        public int RegistroDeGrado(Grado grado)
        {
            var respuesta = this.cliente.mtdRegistrarGrado(grado);
            return respuesta;
        }

        public int RegistroDeGradoGrupoProfesor(Grupo grupo)
        {
            var respuesta = this.cliente.mtdRegistrarGrupo(grupo);

            return respuesta;
        }

        public int RegistroAreaMateria(Materia materia = null, Area area = null)
        {

            if (materia.materia == "" && area.AreaM == "") { return -1; }


            var respuesta = this.cliente.mtdMateriaArea(materia, area);

            return respuesta;
        }

        public int RegistroAsociacionMateriaArea(Materia materia, int Area)
        {

            var respuesta = this.cliente.mtdAsociacionMateriaArea(materia, Area);

            return respuesta;
        }

        public List<Area> ConsultarAreas()
        {
            var resultado = this.cliente.mtdListarArea();
            return resultado;
        }

        public List<Materia> ConsultarMaterias()
        {
            var resultado = this.cliente.mtdListarMateria();
            return resultado;
        }
        public int InsertarAlumnos(Alumnos alumnos)
        {
            var resultado = this.cliente.InsertarAlumnos(alumnos);
  
            return resultado;
        }

        public int InsertarPago(Pagos pagos)
        {
            var resultado = this.cliente.InsertarPago(pagos);
            return resultado;
        }

        public int InsertarNotas(nota objNota, int materia, int nota)
        {
            var resultado = this.cliente.InsertarNotas(objNota, materia, nota);
            return resultado;
        }

        public Respuesta<object> InsertarMatricula(Matricula matricula)
        {
            var resultado = this.cliente.InsertarMatricula(matricula);
            return resultado;
        }

        public int ActualizarGradoMateriaLogica(string materia, string hora, int grado)
        {
            var resultado = this.cliente.mtdActualizarGradoMateria(materia, hora, grado);
            return resultado;
        }

        public Respuesta<object> InsertarGradoMateria(string  materia, string hora, int grado )
        {
           

         var  resultado = this.cliente.mtdRegistrarGradoMateria(materia, hora, grado);

            
            return resultado;
        }

        List<Grupo> lista = new List<Grupo>();

        public List<Grupo> mtdListarGrupo()
        {
            lista = this.cliente.mtdListarGrupo();
     
            return lista;
        }

        public string mtdValidar(Grupo obGrupo = null, Grado objGrado = null)
        {
            string respuesta = "";
            respuesta = this.cliente.mtdValidacion(obGrupo, objGrado);
            return respuesta;
        }
        public int mtdValidarHorario(string id_hora, string dia, string materia, int id_grupo)
        {
           
           var respuesta = this.cliente.mtdValidacionHorario(id_hora, dia, materia, id_grupo);
            return respuesta;
        }
        public List<Alumnos> mtdListarAlumnos(string campo, int grupo = 0)
        {
            List<Alumnos> query = new List<Alumnos>();
            if (campo.Equals(""))
            {
                query = this.cliente.mtdListarAlumnos(grupo);
            }
            else
            {
                query = this.cliente.mtdBuscarAlumnos(campo);
                
            }
            
            
            return query;
        }

        List<Salones> ListaSalones = new List<Salones>();
        public List<Salones> mtdListarSalones(int idGrupo = 0)
        {
            ListaSalones.Clear();
            if (idGrupo > 0)
            {
               // ListaSalones.Clear();
                ListaSalones = this.cliente.mtdListarSalones(idGrupo);
            }

            if(ListaSalones.Count == 0)
            {
                ListaSalones = this.cliente.mtdListarSalones();
            }
            

            return ListaSalones;
        }



        List<Pagos> ListaPagos = new List<Pagos>();
        public List<Pagos> listarPago(int idAlumno)
        {

            ListaPagos = this.cliente.mtdListarPagos(idAlumno);

            return ListaPagos;
        }

        List<RelacionNotasMateriasClass> ListarNotas = new List<RelacionNotasMateriasClass>();
        public List<RelacionNotasMateriasClass> listarNotas(int idAlumno, string periodo)
        {

            ListarNotas = this.cliente.mtdListarNotas(idAlumno, periodo);

            return ListarNotas;
        }

        public int mtdInsertarPago(Pagos objPagos, decimal saldoDeuda, int id_pago)
        {
            decimal saldo = saldoDeuda - objPagos.abono;
             
              objPagos.saldo = saldo;
           

           int confirmacion =  this.cliente.mtdIngresarPago(objPagos, id_pago);

            return confirmacion;
        }

        List<object> ListaGradoMateria = new List<object>();
        public List<object> mtdListarIntensidadHorariaCliente(int id_grado)
        {
            ListaGradoMateria = this.cliente.mtdListarIntensidadHoraria(id_grado);

            return ListaGradoMateria;
        }


        DataTable horarios = new DataTable();
        public DataTable mtdBuscarHorarioPorGrupo(int IdGrupo)
        {
            horarios = this.cliente.mtdListarHorariosPorGrupo(IdGrupo);

            return horarios;
        }

    }
}
