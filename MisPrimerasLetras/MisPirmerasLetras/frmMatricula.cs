using Entidades;
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
    public partial class frmMatricula : Form
    {
        private LoginControlador.LoginControlador controlador;
        public frmMatricula()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnGuardarMatricula_Click(object sender, EventArgs e)
        {

            /* PARAMETIZAR ESTOS VALORES  */
            int total_pagar = 500000;
            int saldo = 500000;
            int abono = 0;
           


            /* ENDCOMMENT */



            Alumnos alumnos = new Alumnos();
            alumnos.nombre  = txtNombreA.Text;
            alumnos.primer_apellido = txtPrimerA.Text;
            alumnos.segundo_apellido = txtSegundoA.Text;
            alumnos.fecha_nacimiento = dtpFechaNacimiento.Value; ;
            alumnos.acudiente = txtAcudiente.Text;
            alumnos.direccion = txtDireccion.Text;
            alumnos.telefono = Convert.ToInt32(txtTelefono.Text);
            alumnos.correo = txtCorreo.Text;
            alumnos.ocupacion = txtOcupacion.Text;
            alumnos.observaciones = rchObservaciones.Text;
    

           
           


            //metodo para crear el alumno y que retorne el ID 
            int  IdEstudiante = this.controlador.InsertarAlumnos(alumnos);
            
            if (IdEstudiante > 0)
            {
                Pagos pagos = new Pagos();
                pagos.fk_alumno = IdEstudiante;
                pagos.total = total_pagar;
                pagos.abono = abono;
                pagos.saldo = saldo;
                pagos.fecha_limite =  dtpFechaLimitePago.Value.ToString();
                pagos.fecha_limite =  dtpFechaLimitePago.Value.ToString();
                pagos.mes = "";
                
                int IdPago = this.controlador.InsertarPago(pagos);
                int IdGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());



                if (IdGrupo != 0 && IdPago > 0)
                {

                    Matricula objMatricula = new Matricula();
                    objMatricula.fk_alumno = IdEstudiante;
                    objMatricula.fk_grupo = IdGrupo;
                    objMatricula.fk_pagos = IdPago;

                    Respuesta<object> registroMatricula = this.controlador.InsertarMatricula(objMatricula);
                    if (registroMatricula.ResultData.Count > 0)
                    {
                        MessageBox.Show("este Almuno ha sido pre matriculado con exito");

                    }


                }
                else
                {
                    MessageBox.Show("por favor seleccine un grupo");
                }
            }

            

            //crear alumno
            // crear matricula
            //crear pago
        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
          

            List<Grupo> grupo = this.controlador.mtdListarGrupo();
            grupo.Insert(0, new Grupo() { id_grupo = 0, grupo = "Seleccione" });
            cmbGrupo.DataSource = grupo;
            cmbGrupo.DisplayMember = "Grupo";
            cmbGrupo.ValueMember = "id_grupo";
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            this.Hide();
            frm.OpenFormRight(new frmPagos());
        }
    }
}
