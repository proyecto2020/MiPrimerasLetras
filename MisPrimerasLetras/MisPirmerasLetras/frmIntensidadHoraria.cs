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

namespace MisPirmerasLetras
{
    public partial class frmIntensidadHoraria : MaterialSkin.Controls.MaterialForm
    {
        private int _idGrado;
        private List<object> data;
        private LoginControlador.LoginControlador controlador;
       
        public frmIntensidadHoraria()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }
   

        private void frmIntensidadHoraria_Load(object sender, EventArgs e)
        {
            Dtgrados.DataSource = this.controlador.ConsultarGrado();
     
        }

        private int fleet;
        Respuesta<object> registro;
        int isUpdate = 0;
        private void btnGuardarAM_Click(object sender, EventArgs e)
        {
                
                
           
                foreach (DataGridViewRow row in dtMaterias.Rows)
                {
                    if (fleet <= 11)
                    {
                        string materia = row.Cells[0].Value.ToString();
                        string hora = row.Cells[1].Value.ToString();
                        System.Console.WriteLine(row.Cells[1].Value);
                        if (data.Count > 0) //Actualizamos 
                        {
                        isUpdate = this.controlador.ActualizarGradoMateriaLogica(materia, hora, _idGrado);

                        }
                        else
                        {
                        registro = this.controlador.InsertarGradoMateria(materia, hora, _idGrado);

                        }

                }

                    fleet++;
                
            }
            


           // Respuesta<object> registro = this.controlador.InsertarGradoMateria(graMateria, grado.IdGrado);
            if (registro.ResultData.Count > 0 && fleet >= 12)
            {
                MessageBox.Show("Guardado con exito!");

            }else if (isUpdate > 0)
            {
                MessageBox.Show("Actualizado con exito!");
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
        
        private void Dtgrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (Dtgrados.Rows.Count != 0)
                _idGrado = Convert.ToInt16(Dtgrados.CurrentRow.Cells[0].Value);

           
            //dtMaterias.Rows.Clear();
            dtMaterias.Refresh();

            data = this.controlador.mtdListarIntensidadHorariaCliente(_idGrado);
            dtMaterias.EditMode = DataGridViewEditMode.EditOnEnter;
            
            if (data.Count.Equals(0))
            {
               

                try
                {
                    dtMaterias.Rows.Clear();

                    dtMaterias.DataSource = null;
                    //   this.Controls.Add(dtMaterias);



                    /*  DataGridViewTextBoxColumn Nmateria = new DataGridViewTextBoxColumn();
                       DataGridViewTextBoxColumn Thoras = new DataGridViewTextBoxColumn();

                      Nmateria.HeaderText = "Materia";
                      Thoras.HeaderText = "Hora";

                      dtMaterias.Columns.AddRange(Nmateria, Thoras);
                       */
                    dtMaterias.Rows.Add("Biología", 0);
                     dtMaterias.Rows.Add("Sociales", 0);
                     dtMaterias.Rows.Add("Artes Plásticas", 0);
                     dtMaterias.Rows.Add("Música", 0);
                     dtMaterias.Rows.Add("Ética", 0);
                     dtMaterias.Rows.Add("Religión", 0);
                     dtMaterias.Rows.Add("Educación Física", 0);
                     dtMaterias.Rows.Add("Danzas", 0);
                     dtMaterias.Rows.Add("Lengua Castellana", 0);
                     dtMaterias.Rows.Add("inglés", 0);
                     dtMaterias.Rows.Add("Matemáticas", 0);
                     dtMaterias.Rows.Add("Informática", 0);
                    // dtMaterias.Rows[].ReadOnly = false;


                     this.Controls.Add(dtMaterias);

                    //DataTable dt = new DataTable();
                    //dt.Columns.Add("Materias");
                    //dt.Columns.Add("Horas");
                    //dt.Rows.Add("Sociales", 0);
                    //dt.Rows.Add("Artes Plásticas", 0);
                    //dt.Rows.Add("Música", 0);
                    //dt.Rows.Add("Ética", 0);
                    //dt.Rows.Add("Religión", 0);
                    //dt.Rows.Add("Educación Física", 0);
                    //dt.Rows.Add("Danzas", 0);
                    //dt.Rows.Add("Lengua Castellana", 0);
                    //dt.Rows.Add("inglés", 0);
                    //dt.Rows.Add("Matemáticas", 0);
                    //dt.Rows.Add("Informática", 0);
                    //dtMaterias.AutoGenerateColumns = true;
                    //dtMaterias.ColumnCount = 2;
                    //dtMaterias.Columns[0].Name = "Materias";
                    //dtMaterias.Columns[0].HeaderText = "Materias";
                    //dtMaterias.Columns[0].DataPropertyName = "Materias";
                    //dtMaterias.Columns[1].HeaderText = "Horas";
                    //dtMaterias.Columns[1].Name = "Horas";
                    //dtMaterias.Columns[1].DataPropertyName = "Horas";
                    //dtMaterias.Columns[2].Name = "Insurance";
                    //dtMaterias.Columns[2].HeaderText = "Insurance";
                    //dtMaterias.Columns[2].DataPropertyName = "Insurance";
                   // dtMaterias.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                

                /* creamos una nueva tabla */

            }
            else
            {
                dtMaterias.Columns.Clear();
                //dtMaterias.Columns.AddRange(null);
                dtMaterias.DataSource = data;
                


            }

        }

        private void dtMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dtMaterias.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void dtMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // e.Handled = true;
            //DataGridViewCell cell = dtMaterias.Rows[0].Cells[0];
            //dtMaterias.CurrentCell = cell;
            //dtMaterias.BeginEdit(true);
        }

        private void dtMaterias_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Tab && dtMaterias.CurrentCell.ColumnIndex == 1)
            //{
            //    e.Handled = true;
            //    DataGridViewCell cell = dtMaterias.Rows[0].Cells[0];
            //    dtMaterias.CurrentCell = cell;
            //    dtMaterias.BeginEdit(true);
            //}
        }
    }
}
