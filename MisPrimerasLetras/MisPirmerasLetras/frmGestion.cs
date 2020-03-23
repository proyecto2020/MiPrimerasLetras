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
    public partial class frmGestion : Form
    {
        private LoginControlador.LoginControlador controlador;
        public frmGestion()
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
                respuesta = this.controlador.RegistroDeGrado(grado);

                mensaje = "Guardado con exito su Grado " + nameGrado;

            }
            else if(profesor!= null && profesor.IdUsuario >= 0 && selectedG.IdGrado > 0)
            {
                
                grupo.Grupos = cmbGrado.Text + cbmAB;
                grupo.Grado = selectedG.IdGrado;
                grupo.Usuario = profesor.IdUsuario;
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;


                respuesta = this.controlador.RegistroDeGradoGrupoProfesor(grupo);

                
                mensaje = "Guardado con exito su grupo!";
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

        public void llenarComoBox()
        {
            List<Grado> Grado = this.controlador.ConsultarGrado();
            Grado.Insert(0, new Grado() { IdGrado = 0, Grados = "Seleccione" });
            cmbGrado.DataSource = Grado;
            cmbGrado.DisplayMember = "Grados";
            cmbGrado.ValueMember = "IdGrado";
        }

        public void llenarArea()
        {
            List<Area> Area = this.controlador.ConsultarAreas();


            foreach (Area areas in Area)
            {
                lbArea.Items.Add(areas);

            }
        }
        public void llenarMateria()
        {
            List<Materia> Materia = this.controlador.ConsultarMaterias();


            foreach (Materia materias in Materia)
            {
                lbMateria.Items.Add(materias);

            }
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
            llenarComoBox();
            llenarUsuarios();
            llenarArea();
            llenarMateria();
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnGuardarAM_Click(object sender, EventArgs e)
        {
            string AreaNombre = txtArea.Text;
            string MateriaNombre = txtMateria.Text;
            Materia ObjMateria = new Materia();
            Area objArea = new Area();
            int respuesta = 0;



            if(AreaNombre != "" || MateriaNombre != "")
            {
                ObjMateria.NombreMateria = MateriaNombre;
                objArea.AreaM = AreaNombre;

                respuesta = this.controlador.RegistroAreaMateria(ObjMateria, objArea);
            }
            else
            {
                MessageBox.Show("Por favor ingrese datos validos");
            }

            if(respuesta > 0)
            {
                MessageBox.Show("Creado con exito!");
                txtArea.Text = "";
                txtMateria.Text = "";
            }
            else { MessageBox.Show("no se pudieron ingresar los datos");}
        }

        private void btnGuardarARMA_Click(object sender, EventArgs e)
        {
           
            int respuesta = 0;
            Materia objMateria = new Materia();
            int[] array1;

            Area area = lbArea.SelectedItem as Area;


            if (lbMateria.Items.Count > 0 && area != null)
            {
                
                foreach (Materia materia in lbMateria.CheckedItems)
                {
                    respuesta = this.controlador.RegistroAsociacionMateriaArea(materia, area.IdArea);
               
                }



            }

            if(respuesta > 0)
            {
                MessageBox.Show("se han asociado con exito!");
            }



        }
    }
}
