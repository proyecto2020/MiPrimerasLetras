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
    public partial class frmIntensidadHoraria : Form
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

            dtMaterias.DataSource = null;
            this.Controls.Add(dtMaterias);
            //dtMaterias.Rows.Clear();
            dtMaterias.Refresh();

            data = this.controlador.mtdListarIntensidadHorariaCliente(_idGrado);

            
            if (data.Count.Equals(0))
            {

                try
                {
                    DataGridViewTextBoxColumn Nmateria = new DataGridViewTextBoxColumn();
                    DataGridViewTextBoxColumn Thoras = new DataGridViewTextBoxColumn();

                    Nmateria.HeaderText = "Materia";
                    Thoras.HeaderText = "Hora";

                    dtMaterias.Columns.AddRange(Nmateria, Thoras);

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


                    this.Controls.Add(dtMaterias);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                

                /* creamos una nueva tabla */

            }
            else
            {
                dtMaterias.EditMode = DataGridViewEditMode.EditOnEnter;
                dtMaterias.DataSource = data;
                


            }

           

            //string nombre = Convert.ToString(dataGEstudiantes.CurrentRow.Cells[1].Value);
            //string apellido = Convert.ToString(dataGEstudiantes.CurrentRow.Cells[2].Value);
            //lblNombreEs.Text = nombre + "  " + apellido;
            //lblDeuda.Text = Convert.ToString(resultado[0].total);
            //lblFechaDeuda.Text = Convert.ToString(resultado[0].fecha_limite);
            //lblUltimoPago.Text = Convert.ToString(resultado[0].saldo);
            //lblFechaPago.Text = Convert.ToString(resultado[0].mes);
            //saldo = resultado[0].saldo;
            //total_pagar = resultado[0].total;
            //Id_pago = resultado[0].id_pago;
            //fecha_limite = resultado[0].fecha_limite;
            //numero_ticket = Convert.ToString(resultado[0].id_pago);
        }

        private void dtMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dtMaterias.EditMode = DataGridViewEditMode.EditOnEnter;
        }
    }
}
