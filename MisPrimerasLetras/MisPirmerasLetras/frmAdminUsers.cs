using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

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
           
            string Nombre = tbxName.Text;
            string PrimerAp = textBox1.Text;
            string SegundAp = textBox2.Text;
            string Correo = txtCorreo.Text;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        
        private void frmAdminUsers_Load(object sender, EventArgs e)
        {
            List<Perfiles> perfiles = this.controlador.ConsultarPerfiles();
            perfiles.Insert(0, new Perfiles() { IdPerfil = 0, Perfil = "Seleccione" });
            cmbRol.DataSource = perfiles;
            cmbRol.DisplayMember = "Perfil";
            cmbRol.ValueMember = "IdPerfil";
        }

        private void cmbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
      
        private void button3_Click_1(object sender, EventArgs e)
        {
            string Nombre = tbxName.Text;
            string PrimerApellido = textBox1.Text;
            string SegundoApellido = textBox2.Text;
            string correo = txtCorreo.Text;
            int Perfil = int.Parse(cmbRol.SelectedValue.ToString());
            int estado = int.Parse(textBox3.Text);
            string contraseña = textBox4.Text;
            


            Usuario usuario = new Usuario();
            usuario.Nombre = Nombre;
            usuario.PirmerApellido = PrimerApellido;
            usuario.SegundoApellido = SegundoApellido;
            usuario.Correo = correo;
            usuario.IdPerfil = Perfil;
            usuario.Estado = Convert.ToBoolean(estado);
            usuario.contrasena = contraseña;
            Respuesta<object> registro =this.controlador.ValidacionRegistroUsuario(usuario);
            if (registro.ResultData.Count > 0)
            {
                MessageBox.Show("El usuario Se Creo Correctamente");
            }

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            List<Usuario> lista = new List<Usuario>();
            lista = this.controlador.ConsultarUsuarios();
            if(lista.Count > 0)
            {
                dataEstudiantes.AutoGenerateColumns = false;
                dataEstudiantes.DataSource = lista;
                this.dataEstudiantes.Refresh();

            }
        }

        private void dataEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
