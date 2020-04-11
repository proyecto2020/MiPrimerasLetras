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

        public List<Grado> ConsultarGrado()
        {
            var resultado = this.cliente.mtdListarGrado();
            return resultado;
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

            if (materia.NombreMateria == "" && area.AreaM == "") { return -1; }


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
        public Respuesta<object> InsertarAlumnos(Alumnos alumnos)
        {
            var resultado = this.cliente.InsertarAlumnos(alumnos);
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
        public List<Alumnos> mtdListarAlumnos()
        {
            List<Alumnos> query = new List<Alumnos>();
            query = this.cliente.mtdListarAlumnos();
            return query;
        }
        List<Pagos> ListaPagos = new List<Pagos>();
        public List<Pagos> listarPago(int idAlumno)
        {

            ListaPagos = this.cliente.mtdListarPagos(idAlumno);

            return ListaPagos;
        }

        public int mtdInsertarPago(Pagos objPagos, decimal saldoDeuda, int id_pago)
        {
            decimal saldo = saldoDeuda - objPagos.abono;
             
              objPagos.saldo = saldo;
           

           int confirmacion =  this.cliente.mtdIngresarPago(objPagos, id_pago);

            return confirmacion;
        }

    }
}
