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
        public string ConsultarLogin(string usuario, string clave)
        { 
            var resultado = this.cliente.ObtenerLista( usuario, clave);   
            return resultado;
        }

        //TODO ESTO PASARLO A UN COTROLADOR USUARIO? *
        Usuario objUsuario = new Usuario();
        public int ValidacionRegistroUsuario(string Nombre, string PrimerAp, string SegApellido, string Correo, int Perfil)
        {
            int  bandera = 0; 

            if(Nombre == "" || PrimerAp == "" || SegApellido == "" ||  Correo == ""  || Perfil == 0) //verficar si hay un rol con valor 0
            {
                bandera = -2;
            }
            else
            {
           
                objUsuario.Nombre = Nombre;
                objUsuario.PirmerApellido = PrimerAp;
                objUsuario.SegundoApellido = SegApellido;
                objUsuario.Correo = Correo;
                objUsuario.IdPerfil = Perfil;




              bandera  =  this.cliente.mtdRegistrarUsario(objUsuario);
            }

            return bandera;
        }


        public List<Perfiles> ConsultarPerfiles()
        {
           var resultado =   this.cliente.mtdListarPerfiles();
           return resultado;
        }
        

    }
}
