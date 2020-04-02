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
    public partial class frmGestionMaterias : Form
    {
        private LoginControlador.LoginControlador controlador;
        public frmGestionMaterias()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
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

            if (respuesta > 0)
            {
                MessageBox.Show("se han asociado con exito!");
            }

        }

        private void frmGestionMaterias_Load(object sender, EventArgs e)
        {
            llenarArea();
            llenarMateria();
        }

        private void btnGuardarAM_Click(object sender, EventArgs e)
        {
            string AreaNombre = txtArea.Text;
            string MateriaNombre = txtMateria.Text;
            Materia ObjMateria = new Materia();
            Area objArea = new Area();
            int respuesta = 0;



            if (AreaNombre != "" || MateriaNombre != "")
            {
                ObjMateria.NombreMateria = MateriaNombre;
                objArea.AreaM = AreaNombre;

                respuesta = this.controlador.RegistroAreaMateria(ObjMateria, objArea);
            }
            else
            {
                MessageBox.Show("Por favor ingrese datos validos");
            }

            if (respuesta > 0)
            {
                MessageBox.Show("Creado con exito!");
                txtArea.Text = "";
                txtMateria.Text = "";
            }
            else { MessageBox.Show("no se pudieron ingresar los datos"); }
        }
    }
}
