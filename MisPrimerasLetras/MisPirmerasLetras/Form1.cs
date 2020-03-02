using LoginControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisPirmerasLetras
{
    public partial class Form1 : Form
    {
        private LoginControlador.LoginControlador controlador;
        public Form1()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.controlador.ConsultarLogin("usuario","clave");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
