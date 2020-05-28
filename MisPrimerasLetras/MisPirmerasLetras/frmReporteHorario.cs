using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Microsoft.Reporting.WinForms;

namespace MisPirmerasLetras
{
    public partial class frmReporteHorario : Form
    {
        private LoginControlador.LoginControlador controlador;
        private int _idGrupo, materia;
        public frmReporteHorario()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }
        private List<Grupo> listaGrupo;
        private void frmReporteHorario_Load(object sender, EventArgs e)
        {
            listaGrupo = this.controlador.mtdListarGrupo();
            dataGEstudiantes.DataSource = listaGrupo;
            this.reportViewer1.RefreshReport();
        }
        List<object> ObjhorarioAnonymus = new List<object>();
        private void dataGEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGEstudiantes.Rows.Count != 0)
                _idGrupo = Convert.ToInt16(dataGEstudiantes.CurrentRow.Cells[0].Value);

            var resultado = this.controlador.mtdBuscarHorarioPorGrupo( _idGrupo);
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                
               
                string materia = resultado.Rows[i][1].ToString();
                string Dia = resultado.Rows[i][2].ToString();
                string horaInicial = resultado.Rows[i][3].ToString();
                string horaFinal = resultado.Rows[i][4].ToString();
                //creamos este objeto de manera mockeada implementar una mejor manera ya que no se entiende muy bien 
                var newObject = new {fk_materia = materia, dia = Dia, fk_dia_hora = horaInicial, fk_grupo = horaFinal};

                ObjhorarioAnonymus.Add(newObject);
              
            }

            ReportDataSource reportData = new ReportDataSource("DataHorario", ObjhorarioAnonymus);
            reportViewer1.LocalReport.ReportEmbeddedResource = "MisPirmerasLetras.Reportes.horarioReporte.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportData);
            reportViewer1.RefreshReport();
        }
    }
}
