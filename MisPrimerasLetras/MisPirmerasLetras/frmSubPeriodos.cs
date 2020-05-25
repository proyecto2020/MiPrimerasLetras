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
    public partial class frmSubPeriodos : Form
    {
        frmDashboard frm = new frmDashboard();
        public frmSubPeriodos()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SoporteControlador.CacheUsuario.periodo = "1";
             this.Hide();
            //frmNotas frmNotas = new frmNotas();
            //frm.OpenFormRight(new frmNotas());
           // frmNotas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoporteControlador.CacheUsuario.periodo = "2";
            this.Hide();
            frm.OpenFormRight(new frmNotas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoporteControlador.CacheUsuario.periodo = "3";
            this.Hide();
            frm.OpenFormRight(new frmNotas());
        }

        private void frmSubPeriodos_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoporteControlador.CacheUsuario.periodo = "4";
            this.Hide();
            frm.OpenFormRight(new frmNotas());
        }
    }
}
