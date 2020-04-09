using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisPirmerasLetras.Libreria
{
    class EventosTextBox
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condición que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            // condicion que permite no dar salto de línea cuando se oprime Enter.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condición que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condición que nos permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public void numberKeyPress(KeyPressEventArgs e)
        {
            //Condición que solo nos permite ingresar datos de tipo texto
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            // condicion que permite no dar salto de línea cuando se oprime Enter.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condición que no permite ingresar datos de tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            //Condición que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condición que nos permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public void numberDecimalKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            //Condición que solo nos permite ingresar datos numéricos
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            // condicion que permite no dar salto de línea cuando se oprime Enter.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condición que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condición que verifica si hay un punto decimal
            else if ((e.KeyChar == '.') && (!textBox.Text.Contains("."))) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public bool comprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
