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
            Alumnos alumnos = new Alumnos();
            alumnos.nombre = textBox1.Text;
            alumnos.primer_apellido = textBox2.Text;
            alumnos.segundo_apellido = textBox3.Text;
            alumnos.fecha_nacimiento = dateTimePicker1.Value;
            alumnos.acudiente = textBox4.Text;
            alumnos.direccion = textBox5.Text;
            alumnos.telefono = Convert.ToInt32(textBox6.Text);
            alumnos.correo = textBox7.Text;
            alumnos.observaciones = richTextBox1.Text;
            alumnos.fk_grupo = Convert.ToInt32(comboBox2.Text);
            alumnos.ocupacion = textBox8.Text;

            Respuesta<object> registroEstudiantes = this.controlador.InsertarAlumnos(alumnos);
            if(registroEstudiantes.ResultData.Count> 0)
            {
                MessageBox.Show("El Alumno Se Creo Correctamente");
            }

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
    }
}
