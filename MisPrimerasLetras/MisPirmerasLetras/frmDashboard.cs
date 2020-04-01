using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;

using Entidades;
using LoginControlador;

namespace MisPirmerasLetras
{
    public partial class frmDashboard : Form
    {
        private LoginControlador.LoginControlador controlador;
        public frmDashboard()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }
        //palabras reservadas, de la libreria.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(mnVertical.Width == 205)
            {
                mnVertical.Width = 70; //pixeles! test
                pnlSubMenu.Visible = false;
            }
            else
            {
                mnVertical.Width = 205;
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void OpenFormRight(object frmHijo)
        {
            if(this.panelContendor.Controls.Count > 0)
            {
                this.panelContendor.Controls.RemoveAt(0);
                Panel p = this.panelContendor as Panel;
                Form fh = frmHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContendor.Controls.Add(fh);
                this.panelContendor.Tag = fh;
                fh.Show();
            }
            
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
           string rol =  SoporteControlador.CacheUsuario.ApellidoUsuario;
            if(rol == "administrador")
            {

                OpenFormRight(new frmAdminUsers());
            }
            else
            {
                MessageBox.Show("No tienes permisos!");
            }
            
        }

        private void panelContendor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            pnlSubMenu.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormRight(new frmMatricula());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = false;
            OpenFormRight(new frmGestionGrupos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = false;
            OpenFormRight(new frmGestionMaterias());
        }

        private void panelContendor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            DatosUsuario();
        }

        private void DatosUsuario()
        {
            

            lblApellidoUser.Text = SoporteControlador.CacheUsuario.ApellidoUsuario;
            lblNombreUser.Text = SoporteControlador.CacheUsuario.NombreUsuario;
            lblPerfil.Text = SoporteControlador.CacheUsuario.Perfil;
        }

        private void panelContendor_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
