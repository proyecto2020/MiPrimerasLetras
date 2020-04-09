using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginControlador;
using MisPirmerasLetras.Libreria;


namespace MisPirmerasLetras
{
   
    public partial class frmPagos : Form
    {
        private LoginControlador.LoginControlador controlador;

        public int _seccion { get; set; }
        private int _idCliente = 0;
        private int _reg_por_pagina = 10, _num_pagina = 1;
        public frmPagos()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }

        private void lblDeuda_Click(object sender, EventArgs e)
        {

        }

        private void frmPagos_Load(object sender, EventArgs e)
        {

            List<Alumnos> alumnos = this.controlador.mtdListarAlumnos();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if (0 < alumnos.Count)
            {
                dataGEstudiantes.DataSource = alumnos.Skip(inicio).Take(_reg_por_pagina).ToList();
                dataGEstudiantes.Columns[0].Visible = false;
                dataGEstudiantes.Columns[8].Visible = false;
                dataGEstudiantes.Columns[14].Visible = false;
                dataGEstudiantes.Columns[13].Visible = false;
                dataGEstudiantes.Columns[10].Visible = false;
                dataGEstudiantes.Columns[11].Visible = false;
                dataGEstudiantes.Columns[12].Visible = false;
                dataGEstudiantes.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[7].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }
        private int _idEstudante;

        private void dataGEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGEstudiantes.Rows.Count != 0)

                //_idCliente = Convert.ToInt16(dataEstudiantes.CurrentRow.Cells[0].Value);
                //lblDeuda.Text = Convert.ToString(dataEstudiantes.CurrentRow.Cells[1].Value);

                _idEstudante = Convert.ToInt16(dataGEstudiantes.CurrentRow.Cells[0].Value);

            var resultado = this.controlador.listarPago(_idEstudante);

            string nombre = Convert.ToString(dataGEstudiantes.CurrentRow.Cells[1].Value);
            string apellido = Convert.ToString(dataGEstudiantes.CurrentRow.Cells[2].Value);
            lblNombreEs.Text = nombre + "  " + apellido;
            lblDeuda.Text = Convert.ToString(resultado[0].total);
            lblFechaDeuda.Text = Convert.ToString(resultado[0].mes);
            lblUltimoPago.Text = Convert.ToString(resultado[0].abono);
            lblFechaPago.Text = Convert.ToString(resultado[0].mes);


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objetos.eventos.numberDecimalKeyPress(txtPagoAlumno, e);
        }

        private void dataEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e){ }
    }
}
