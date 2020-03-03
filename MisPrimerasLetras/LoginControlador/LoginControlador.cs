using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginControlador
{
    public class LoginControlador
    {
        private SQLCliente cliente;
        public LoginControlador()
        {
            this.cliente = new SQLCliente();
        }
        public IActionResult ConsultarLogin(string usuario, string clave)
        {
            var resultado = this.cliente.ObtenerLista(usuario, clave);
            return resultado;
        }
    }
}
