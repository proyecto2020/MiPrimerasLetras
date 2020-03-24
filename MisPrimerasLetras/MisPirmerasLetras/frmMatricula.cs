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
            alumnos.Nombres = textBox1.Text;
            alumnos.PrimerApellido = textBox2.Text;
            alumnos.SegundoApellido = textBox3.Text;
            alumnos.FechaNacimiento = dateTimePicker1.Value;
            alumnos.Acudiente = textBox4.Text;
            alumnos.Dirección = textBox5.Text;
            alumnos.Telefono = Convert.ToInt32(textBox6.Text);
            alumnos.Correo = textBox7.Text;
            alumnos.Observaciones = richTextBox1.Text;
            alumnos.IdGrado= Convert.ToInt32(comboBox1.Text);
            alumnos.IdGrupo = Convert.ToInt32(comboBox2.Text);

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
    }
}
