using System;
using LoginControlador;
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
    public partial class frmAdminUsers : Form
    {
        private LoginControlador.LoginControlador controlador;
      
        public frmAdminUsers()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            string Nombre = tbxName.Text;
            string PrimerAp = textBox1.Text;
            string SegundAp = textBox2.Text;
            string Correo = txtCorreo.Text;
            int Perfil = int.Parse(cmbRol.SelectedValue.ToString());



         int registro =    this.controlador.ValidacionRegistroUsuario(Nombre, PrimerAp, SegundAp, Correo, Perfil);

            if(registro == 1)
            {
                MessageBox.Show("Persona Registrado");
            }
            else
            {
                MessageBox.Show("Datos Nulos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        
        private void frmAdminUsers_Load(object sender, EventArgs e)
        {
            
            cmbRol.DataSource = this.controlador.ConsultarPerfiles(); //llenamos el cmb con los perfiles
            cmbRol.DisplayMember = "Perfil";
            cmbRol.ValueMember = "IdPerfil";
        }
    }
}
