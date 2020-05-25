using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Entidades;
using SoporteControlador;

namespace MisPirmerasLetras
{
    public partial class frmNotas : Form
    {
        private LoginControlador.LoginControlador controlador;
        private int _reg_por_pagina = 30, _num_pagina = 1, _actualizable;
        private int _idEstudante, _periodo, _grupo;
        public frmNotas()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();

        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            _grupo = SoporteControlador.CacheUsuario.grupo; // obtenemos el grupo del usuario 

            if (_grupo.Equals(0) )
            {
                panel27.Visible = true;
                btnGuardarARMA.Enabled = false;


            }
            else
            {
                List<Alumnos> alumnos = this.controlador.mtdListarAlumnos(_grupo);
                int inicio = (_num_pagina - 1) * _reg_por_pagina;
                if (alumnos.Count > 0)
                {
                    dataGEstudiantes.DataSource = alumnos.Skip(inicio).Take(_reg_por_pagina).ToList();
                    dataGEstudiantes.Columns[0].Visible = false;
                    dataGEstudiantes.Columns[1].Visible = false;
                    //  dataGEstudiantes.Columns[14].Visible = false;
                    dataGEstudiantes.Columns[2].Visible = false;
                    dataGEstudiantes.Columns[3].Visible = false;
                    //dataGEstudiantes.Columns[11].Visible = false;
                    //dataGEstudiantes.Columns[12].Visible = false;
                    //dataGEstudiantes.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    //dataGEstudiantes.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    //dataGEstudiantes.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    //dataGEstudiantes.Columns[7].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            
            

        }

        private void btnGuardarARMA_Click(object sender, EventArgs e)
        {
            // DataTable data = SoporteControlador.CacheUsuario.dataTable; PODEMOS ACCEDER A LOS PARAEMTROS
            // EJ> ACCEDEMOS A EL PERIODO ACTUAL  data.Rows[1][1].ToString();



            int[] notas = {
               Convert.ToInt32(txtMbiologia.Text),
                Convert.ToInt32(txtMsociales.Text),
                Convert.ToInt32(txtMartesplasticas.Text),
                Convert.ToInt32(txtMmusica.Text),
                Convert.ToInt32(txtMetica.Text),
                Convert.ToInt32(txtMreligion.Text),
                Convert.ToInt32(txtMefisica.Text),
                Convert.ToInt32(txtMdanzas.Text),
                Convert.ToInt32(txtMlenguacast.Text),
                Convert.ToInt32(txtMingles.Text),
                Convert.ToInt32(txtMmate.Text),
                Convert.ToInt32(txtMinformatica.Text)

            };

            int[] materias = {
               Convert.ToInt32(txtMbiologia.Name),
                Convert.ToInt32(txtMsociales.Name),
                Convert.ToInt32(txtMartesplasticas.Name),
                Convert.ToInt32(txtMmusica.Name),
                Convert.ToInt32(txtMetica.Name),
                Convert.ToInt32(txtMreligion.Name),
                Convert.ToInt32(txtMefisica.Name),
                Convert.ToInt32(txtMdanzas.Name),
                Convert.ToInt32(txtMlenguacast.Name),
                Convert.ToInt32(txtMingles.Name),
                Convert.ToInt32(txtMmate.Name),
                Convert.ToInt32(txtMinformatica.Name)

            };


            // insertamos las notas 
            nota objNota = new nota();
            objNota.fk_alumno = _idEstudante;
            objNota.valor_nota = 0; //lo dejamos por defecto para que cuando no exita un perido inserte en vez de actualizar
            objNota.periodo = SoporteControlador.CacheUsuario.periodo;

            int registro = -1;
            for (int i = 0; i < notas.Length; i++)
            {
                 registro = this.controlador.InsertarNotas(objNota, materias[i], notas[i]);
             
            }

            if (registro.Equals(0))
            {
                MessageBox.Show("Insertado con exito ! ");
                llenarDatosDeNotas();
            }
           



        
         
        }

        private void textBoxAlumno_Buscar_TextChanged(object sender, EventArgs e)
        {

            List<Alumnos> alumnos = this.controlador.mtdListarAlumnos(textBoxAlumno_Buscar.Text);
            dataGEstudiantes.DataSource = alumnos;
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ValidarColor(Control panel, double valor)
        {
            if (valor < 6)
            {
                panel.BackColor = Color.Red;
            }
            else if (valor < 8)
            {
                panel.BackColor = Color.DodgerBlue;
            }
            else if (valor < 9)
            {
                panel.BackColor = Color.DeepSkyBlue;
            }
            else if (valor <= 10)
            {
                panel.BackColor = SystemColors.MenuHighlight;
            }
            else
            {
                panel.BackColor = SystemColors.MenuHighlight;
            }
            
        }
        private void llenarDatosDeNotas()
        {

            _idEstudante = Convert.ToInt16(dataGEstudiantes.CurrentRow.Cells[0].Value);
            string periodo = SoporteControlador.CacheUsuario.periodo;
            var resultado = this.controlador.listarNotas(_idEstudante, periodo);

               if(resultado.Count > 0)
                {

            
                _actualizable = 0;
                txtMbiologia.Text = Convert.ToString(resultado[0].valor_nota);
                txtMbiologia.Name = Convert.ToString(resultado[0].fk_materia); //LE DAMOS SU ID
                ValidarColor(panel15, resultado[0].valor_nota);
                

                txtMsociales.Text = Convert.ToString(resultado[1].valor_nota);
                txtMsociales.Name = Convert.ToString(resultado[1].fk_materia);
                ValidarColor(panel16, resultado[1].valor_nota);

                txtMartesplasticas.Text = Convert.ToString(resultado[2].valor_nota);
                txtMartesplasticas.Name = Convert.ToString(resultado[2].fk_materia);
                ValidarColor(panel17, resultado[2].valor_nota);

                txtMmusica.Text = Convert.ToString(resultado[3].valor_nota);
                txtMmusica.Name = Convert.ToString(resultado[3].fk_materia);
                ValidarColor(panel18, resultado[3].valor_nota);


                txtMetica.Text = Convert.ToString(resultado[4].valor_nota);
                txtMetica.Name = Convert.ToString(resultado[4].fk_materia);
                ValidarColor(panel19, resultado[4].valor_nota);

                txtMreligion.Text = Convert.ToString(resultado[5].valor_nota);
                txtMreligion.Name = Convert.ToString(resultado[5].fk_materia);
                ValidarColor(panel20, resultado[5].valor_nota);

                txtMefisica.Text = Convert.ToString(resultado[6].valor_nota);
                txtMefisica.Name = Convert.ToString(resultado[6].fk_materia);
                ValidarColor(panel21, resultado[6].valor_nota);

                txtMdanzas.Text = Convert.ToString(resultado[7].valor_nota);
                txtMdanzas.Name = Convert.ToString(resultado[7].fk_materia); 
                ValidarColor(panel22, resultado[7].valor_nota);

                txtMlenguacast.Text = Convert.ToString(resultado[8].valor_nota);
                txtMlenguacast.Name = Convert.ToString(resultado[8].fk_materia);
                ValidarColor(panel23, resultado[8].valor_nota);

                txtMingles.Text = Convert.ToString(resultado[9].valor_nota);
                txtMingles.Name = Convert.ToString(resultado[9].fk_materia);
                ValidarColor(panel24, resultado[9].valor_nota);

                txtMmate.Text = Convert.ToString(resultado[10].valor_nota);
                txtMmate.Name = Convert.ToString(resultado[10].fk_materia);
                ValidarColor(panel25, resultado[10].valor_nota);

                txtMinformatica.Text = Convert.ToString(resultado[11].valor_nota);
                txtMinformatica.Name = Convert.ToString(resultado[11].fk_materia);
                ValidarColor(panel26, resultado[11].valor_nota);
                //lblFechaDeuda.Text = Convert.ToString(resultado[0].fecha_limite);
            }
            else
            {
                // SINO EXISTE LO INSERTAMOS 
                nota objNota = new nota();
                objNota.fk_alumno = _idEstudante;
                objNota.valor_nota = 0; //lo dejamos por defecto para que cuando no exita un perido inserte en vez de actualizar
                objNota.periodo = SoporteControlador.CacheUsuario.periodo;
                int  registro = this.controlador.InsertarNotas(objNota);
                llenarDatosDeNotas(); 
            }

        }
        private void dataGEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGEstudiantes.Rows.Count != 0)
                llenarDatosDeNotas();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
