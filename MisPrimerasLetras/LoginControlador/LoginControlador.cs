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
    public class LoginControlador
    {
        public SQLCliente cliente;
        public LoginControlador()
        {
            this.cliente = new SQLCliente();
        }
        public Collection<RespuestaLogin> ConsultarLogin(string usuario, string clave)
        {
            Collection<RespuestaLogin> resultado = this.cliente.ConsultarLogin( usuario, clave);   
            return resultado;
        }


        public Respuesta<object> ValidacionRegistroUsuario(Usuario usuario)
        {
            var respuesta = this.cliente.ValidacionRegistroUsuario(usuario);
            return respuesta;
        }


        public List<Perfiles> ConsultarPerfiles()
        {
           var resultado =   this.cliente.mtdListarPerfiles();
           return resultado;
        }
        
        public List<Usuario> ConsultarUsuarios()
        {
            var resultado = this.cliente.ConsultarUsuarios();
            return resultado;
        }
    }
}
