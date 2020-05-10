//using LoginControlador;
using Entidades;
using LoginControlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MisPirmerasLetras
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private LoginControlador.LoginControlador controlador;

        frmDashboard FrmDashboard = new frmDashboard();
        frmAdminUsers frmAdminUsers = new frmAdminUsers();

        public Form1()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green300, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void label1_Click(object sender, EventArgs e)

        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }
        public void msError(String msg)
        {
            lblMessage.Text = "   " + msg;
            lblMessage.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea salir?", "Mensage de estado",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";


                txtPassword.UseSystemPasswordChar = false;

                txtPassword.PasswordChar = char.MinValue;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                lblMessage.Visible = false;
                if (checkBox1.Checked)
                {
                    txtPassword.PasswordChar = char.MinValue;
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                }
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                lblMessage.Visible = false;
                txtUser.ForeColor = Color.Black;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña" || checkBox1.Checked )
            {
                txtPassword.PasswordChar = char.MinValue;
            }
            else {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnIngresarNuevo_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            msError("");

            if (usuario == "Usuario" || txtPassword.Text == "Contraseña")
            {
                msError("Ingrese usuario y contraseña validos");
            }
            else
            {
                string contrasena = txtPassword.Text;
                Collection<RespuestaLogin> ingreso = this.controlador.ConsultarLogin(usuario, contrasena);

                if (ingreso.Count > 0)
                {
                    this.Hide();
                    this.FrmDashboard.Show();

                }
                else
                {
                    msError("Verificar datos, Error en el inicio de sesion");

                }
            }
        }
    }
}
