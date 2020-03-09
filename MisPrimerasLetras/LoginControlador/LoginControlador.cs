using Entidades;
using Microsoft.Extensions.Configuration;
using Persistencia;
using System;
using System.Collections.Generic;
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
        public Respuesta<object> ConsultarLogin(string usuario, string clave)
        { 
            var resultado = this.cliente.ObtenerLista( usuario, clave);   
            return resultado;
        }


        public Respuesta<object> ValidacionRegistroUsuario(Usuario usuario)
        {
            var respuesta = this.cliente.mtdRegistrarUsario(usuario);
            return respuesta;
        }


        public List<Perfiles> ConsultarPerfiles()
        {
           var resultado =   this.cliente.mtdListarPerfiles();
           return resultado;
        }
        

    }
}
