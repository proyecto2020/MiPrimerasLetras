using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MisPirmerasLetras
{
    public partial class frmReportes : Form
    {
        private LoginControlador.LoginControlador controlador;
        private int _reg_por_pagina = 30, _num_pagina = 1, _actualizable,  _idEstudante;
        public frmReportes()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            List<Alumnos> alumnos = this.controlador.mtdListarAlumnos();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if (0 < alumnos.Count)
            {
                dataGEstudiantes.DataSource = alumnos.Skip(inicio).Take(_reg_por_pagina).ToList();
                dataGEstudiantes.Columns[0].Visible = false;
                dataGEstudiantes.Columns[8].Visible = false;
                //  dataGEstudiantes.Columns[14].Visible = false;
                dataGEstudiantes.Columns[13].Visible = false;
                dataGEstudiantes.Columns[10].Visible = false;
                dataGEstudiantes.Columns[11].Visible = false;
                dataGEstudiantes.Columns[12].Visible = false;
                dataGEstudiantes.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[7].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            this.reportViewer1.RefreshReport();
        }

        public void ObtenerNotasPorAlumno()
        {


        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _idEstudante = Convert.ToInt16(dataGEstudiantes.CurrentRow.Cells[0].Value);

            var resultado = this.controlador.listarPago(_idEstudante);

            ReportDataSource reportData = new ReportDataSource("DataPagos", resultado);
            reportViewer1.LocalReport.ReportEmbeddedResource = "MisPirmerasLetras.Reportes.pagos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportData);
            reportViewer1.RefreshReport();

        }

        private void dataGEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnGuardarARMA_Click(object sender, EventArgs e)
        {
            try
            {
                _idEstudante = Convert.ToInt16(dataGEstudiantes.CurrentRow.Cells[0].Value);
                if (dataGEstudiantes.Rows.Count != 0 && txtPeriodo.Text != "")
                {
                    var resultado = this.controlador.listarNotas(_idEstudante, txtPeriodo.Text);

                    ReportDataSource reportData = new ReportDataSource("NotasPeriodo", resultado);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "MisPirmerasLetras.Reportes.notas.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(reportData);
                    reportViewer1.RefreshReport();

                }
                else
                {
                    MessageBox.Show("Seleccione un estudiante o periodo");
                }


            }catch(Exception ex){
                Console.WriteLine(ex);
            }
        }
    }
}
