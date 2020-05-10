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
using Entidades;

namespace MisPirmerasLetras
{
    public partial class frmGestionGrupos : Form
    {
        private LoginControlador.LoginControlador controlador;
        private bool bandera = true;
        private int  idSalon = 0;
        private int count = 0;
        private int y = 10;
        private int subY = 10;
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
           
            
        }
        private void repuesta(int respuesta, string mensaje )
        {
            if (respuesta > 0)
            {
                txtNameGrado.Text = "";
                cmbGrado.Text = "Seleccione";
                MessageBox.Show(mensaje);
                llenarComoBoxGrupo();

            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }
        private void ltbProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void llenarComoBoxGrupo()
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
           // pn1grados.Hide();

            pn2Grupos.Hide();

            dataGrupos.DataSource = this.controlador.mtdListarGrupo();
            listarSalones();
           

            cmbAB.DropDownStyle = ComboBoxStyle.DropDownList;
            llenarComoBoxGrupo();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void listarSalones(int idGrupo = 0)
        {
            int subyPage2 = 10;
            int x = 25;
            Button btn;

            // recorrer el tabpage hacia atras para eliminar y  hacer "refresh" a los tabs 
            for (int ix = tabPage8.Controls.Count - 1; ix >= 0; --ix)
            {
                tabPage8.Controls[ix].Dispose();
            }



            List<Salones> salones = this.controlador.mtdListarSalones(idGrupo);

           

            if (salones.Count > 1)
            {

                foreach (Salones element in salones)
                {




                    //solo dos sedes
                    if (element.Sede == "1")
                    {

                        btn = crearBoton(element.Nombre, element.IdSalon, y, x);
                        y += 70;
                        count++;
                        if (count > 5 && count <= 10)
                        {
                            x = 180;
                            btn = crearBoton(element.Nombre, element.IdSalon, subY, x);
                            subY += 70;


                        }


                        btn.Click += new System.EventHandler(this.eventoClickBoton);
                        tabPage8.Controls.Add(btn);
                    }
                    else if (element.Sede == "2")
                    {
                        Button btn1 = crearBoton(element.Nombre, element.IdSalon, subyPage2, 25);
                        subyPage2 += 70;
                        tabPage9.Controls.Add(btn1);
                        btn1.Click += new System.EventHandler(this.eventoClickBoton);
                    }
                    //    Console.WriteLine($"Element #: {element.Nombre}");

                }

            }

        }

        Button crearBoton(string nombre, int id, int y, int x)
        {
            Button btn = new Button();

            btn.Height = 62;
            btn.Width = 103;
            btn.Location = new Point(x, y);
            // parametizar
            btn.Image = Image.FromFile(@"C:\wamp64\www\MiPrimerasLetras\MisPrimerasLetras\MisPirmerasLetras\Resources\shool5.png");
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.Cursor = Cursors.Hand;
            btn.BackColor = Color.AliceBlue;
            btn.Enabled = bandera;

            // btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.FlatStyle = FlatStyle.Flat;


            // y += 70;

            btn.Name = id.ToString();
            btn.Text = nombre;

            return btn;

        }


        void eventoClickBoton(Object sender, EventArgs e)
        {
            Button botonActual = (Button)sender;

            //  botonActual.BackColor = Color.DeepSkyBlue;

            MessageBox.Show(botonActual.Name);
            idSalon = int.Parse(botonActual.Name);
        }

        private void btnGrado_Click(object sender, EventArgs e)
        {
            
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void btnVercargaAcademica_Click(object sender, EventArgs e)
        {

        }

        private void pctAccionVerGrado_Click(object sender, EventArgs e)
        {
            pn1grados.Show();
            pn2Grupos.Hide();
        }

        private void ptAccionVerGrupos_Click(object sender, EventArgs e)
        {
            pn2Grupos.Show();
            pn1grados.Hide();
        }

        private void btnGrado_Click_1(object sender, EventArgs e)
        {
            string mensaje = "";
            Grado grado = new Grado();

            int respuesta = 0;
            // int idMateria = int.Parse(cmbMateria.SelectedValue.ToString());
            string nameGrado = txtNameGrado.Text;
            if (nameGrado != "")
            {

                grado.Grados = nameGrado;


                if (this.controlador.mtdValidar(null, grado) == nameGrado)
                {
                    mensaje = "Este Grado ya existe!";
                }
                else
                {
                    respuesta = this.controlador.RegistroDeGrado(grado);
                    if (respuesta > 0)
                    {

                        string message = "registrado con exito, desea agregar su intensidad horaria?";
                        string title = "Mensaje de respuesta";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            frmIntensidadHoraria frm = new frmIntensidadHoraria();
                            frm.Show();

                        }
                        else
                        {
                            //this.Close();
                            // Do something  
                        }


                    }


                }

            }
            else
            {
                mensaje = "error de registro verifique los datos";
            }
            if (mensaje != "")
            {
                this.repuesta(respuesta, mensaje);
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmIntensidadHoraria frm = new frmIntensidadHoraria();
            frm.Show();

        }

        private void btnRegistrarTodo_Click_1(object sender, EventArgs e)
        {
            int respuesta = 0;
            string mensaje = "";

            Grupo grupo = new Grupo();
            Grado selectedG = cmbGrado.SelectedItem as Grado;
            string cbmAB = cmbAB.Text;
            Usuario profesor = ltbProfesores.SelectedItem as Usuario;




            if (profesor != null && profesor.IdUsuario >= 0 && selectedG.IdGrado > 0 && idSalon > 0)
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
                    grupo.fk_salon = idSalon;
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;


                    respuesta = this.controlador.RegistroDeGradoGrupoProfesor(grupo);

                   
                    mensaje = "Guardado con exito su grupo!";
                    dataGrupos.DataSource = this.controlador.mtdListarGrupo();
                    listarSalones();
                }

            }

            else
            {
                if (idSalon.Equals(0))
                {
                    mensaje = "Recuerde seleccionar un salón";
                }
                else
                {
                    mensaje = "error de registro verifique los datos";
                }

            }

            this.repuesta(respuesta, mensaje);
        }
    }
}
