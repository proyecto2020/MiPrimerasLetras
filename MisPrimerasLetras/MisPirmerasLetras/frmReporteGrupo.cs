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
    public partial class frmReporteGrupo : Form
    {
        private LoginControlador.LoginControlador controlador;
        private int _idGrupo, materia;
        public frmReporteGrupo()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }
        private List<Grupo> listaGrupo;
        private List<Materia> listaMateria;
        private void frmReporteGrupo_Load(object sender, EventArgs e)
        {
            listaGrupo = this.controlador.mtdListarGrupo();
            listaMateria = this.controlador.ConsultarMaterias();

            dataGridView1.DataSource = listaMateria;
            dataGEstudiantes.DataSource = listaGrupo;

            this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGEstudiantes.Rows.Count != 0)
                _idGrupo = Convert.ToInt16(dataGEstudiantes.CurrentRow.Cells[0].Value);

            var resultado = this.controlador.ConsultarAlumnos(0, _idGrupo);
            ReportDataSource reportData = new ReportDataSource("DataAlumnoGrupo", resultado);
            reportViewer1.LocalReport.ReportEmbeddedResource = "MisPirmerasLetras.Reportes.alumnoGrupo.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportData);
            reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                materia = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

            var resultado = this.controlador.ConsultarAlumnos(materia);
            ReportDataSource reportData = new ReportDataSource("DataAlumnosMateria", resultado);
            reportViewer1.LocalReport.ReportEmbeddedResource = "MisPirmerasLetras.Reportes.alumnosMateria.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportData);
            reportViewer1.RefreshReport();
        }
    }
}
