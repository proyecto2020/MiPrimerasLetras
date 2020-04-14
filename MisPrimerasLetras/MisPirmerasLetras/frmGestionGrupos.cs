using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisPirmerasLetras
{
    public partial class frmGestionGrupos : Form
    {
        private LoginControlador.LoginControlador controlador;
        public frmGestionGrupos()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarTodo_Click(object sender, EventArgs e)
        {
            int respuesta = 0;
            string mensaje = "";
            Grado grado = new Grado();
            Grupo grupo = new Grupo();


            string nameGrado = txtNameGrado.Text;
            Grado selectedG = cmbGrado.SelectedItem as Grado;
            string cbmAB = cmbAB.Text;
            Usuario  profesor = ltbProfesores.SelectedItem  as Usuario;


 
            if (nameGrado != "")
            {

                grado.Grados = nameGrado;
                if (this.controlador.mtdValidar(null,grado) == nameGrado)
                {
                    mensaje = "Este grupo ya existe!";
                }
                else
                {
                    respuesta = this.controlador.RegistroDeGrado(grado);

                    mensaje = "Guardado con exito su Grado " + nameGrado;
                }
                
              

            }
            else if(profesor!= null && profesor.IdUsuario >= 0 && selectedG.IdGrado > 0)
            {
               
                grupo.grupo = cmbGrado.Text + cbmAB;
                if (this.controlador.mtdValidar(grupo, null) == cmbGrado.Text + cbmAB)
                {
                    mensaje = "Este grupo ya existe!";
                }
                else
                {

                    grupo.Grado = selectedG.IdGrado;
                    grupo.Usuario = profesor.IdUsuario;
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;


                    respuesta = this.controlador.RegistroDeGradoGrupoProfesor(grupo);


                    mensaje = "Guardado con exito su grupo!";
                    dataGrupos.DataSource = this.controlador.mtdListarGrupo();
                }
                
            }
            else
            {
                mensaje = "error de registro verifique los datos";
            }

            if (respuesta > 0)
            {
                txtNameGrado.Text = "";
                cmbGrado.Text = "Seleccione";
                MessageBox.Show(mensaje);
                llenarComoBox();

            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void ltbProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void llenarComoBox()
        {
            List<Grado> Grado = this.controlador.ConsultarGrado();
            Grado.Insert(0, new Grado() { IdGrado = 0, Grados = "Seleccione" });
            cmbGrado.DataSource = Grado;
            cmbGrado.DisplayMember = "Grados";
            cmbGrado.ValueMember = "IdGrado";
        }

       
        public void llenarUsuarios()
        {
            List<Usuario> Usuario = this.controlador.ConsultarProfesores();


            foreach (Usuario atributos in Usuario)
            {
                ltbProfesores.Items.Add(atributos);

            }


        }
    

        private void frmGestion_Load(object sender, EventArgs e)
        {
            dataGrupos.DataSource = this.controlador.mtdListarGrupo();
 

            cmbAB.DropDownStyle = ComboBoxStyle.DropDownList; 
            llenarComoBox();
            llenarUsuarios();
           
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnGuardarAM_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarARMA_Click(object sender, EventArgs e)
        {
           


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
