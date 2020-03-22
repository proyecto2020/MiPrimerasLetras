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

namespace MisPirmerasLetras
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
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
            if(mnVertical.Width == 244)
            {
                mnVertical.Width = 70; //pixeles! test
            }
            else
            {
                mnVertical.Width = 244;
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
            OpenFormRight(new frmAdminUsers());
        }

        private void panelContendor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFormRight(new frmGestion());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
