using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MisPirmerasLetras
{
    public partial class frmCargaAcademica : Form
    {
        private LoginControlador.LoginControlador controlador;
        private string _hora =  "";
        private string _dia =  "";
        private bool bandera = false;
        private int count = 0;
        private int y = 10;
        private  int subY = 10;
        private int IdGrupo;
        private string _nuevoGrupoSelecionado;
        public frmCargaAcademica()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }   


        public void llenarMateria()
        {
            List<Materia> materias = this.controlador.ConsultarMaterias();

            materias.Insert(0, new Materia() { IdArea = 0, materia = "Seleccione" });
            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "materia";
            cmbMateria.ValueMember = "IdArea";
        }


        public void listarHoraDia()
        {

            List<DiaHora> diahora = this.controlador.ConsultarHoras();
            //diahora.Insert(0, new DiaHora() { id_dia_hora = 0 });
            cmbHoras.DataSource = diahora;
            cmbHoras.DisplayMember = "ConcatenarHoras";
            
            cmbHoras.ValueMember = "id_dia_hora";
        }

      
        private void frmCargaAcademica_Load(object sender, EventArgs e)
        {
            llenarMateria();
            listarHoraDia();
           // listarSalones();


           


            List<Grupo> grupo = this.controlador.mtdListarGrupo();
            grupo.Insert(0, new Grupo() { id_grupo = 0, grupo = "Seleccione" });
            cmbGrupo.DataSource = grupo;
            cmbGrupo.DisplayMember = "Grupo";
            cmbGrupo.ValueMember = "id_grupo";
        }

       
        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            int IdGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());
            int IdHora = int.Parse(cmbGrupo.SelectedValue.ToString());


            if (listViewHorario.Items.Count == 12)
            {
                this.mensajeAdvertencia("No puedes Agregar mas materias, gurarda los cambios para este grupo!", false);
            }
            else
            {
                if (cmbGrupo.Text == "Seleccione")
                {
                    MessageBox.Show("Por favor seleccione un Grupo!");

                }
                else if (cmbMateria.Text == "Seleccione")
                {
                    MessageBox.Show("Por favor seleccione una Materia!");
                }
                else if (comboBox4.Text == "Seleccione")
                {
                    MessageBox.Show("Por favor seleccione un dia!");

                }
                else
                {

                    



                    ListViewItem list1 = new ListViewItem();
                    // ListViewItem list1 = new ListViewItem(cmbGrupo.Text);
                    list1.SubItems.Add(cmbGrupo.Text);
                    list1.SubItems.Add(comboBox4.Text);
                    list1.SubItems.Add(cmbHoras.Text);
                    list1.SubItems.Add(cmbMateria.Text);

                    if (validacionLista(cmbHoras.Text, comboBox4.Text))
                    {

                        //large
                        // imageList2.ImageSize = new Size(50, 50);
                        listViewHorario.SmallImageList = imageList2;
                        for (int j = 0; j < imageList2.Images.Count; j++)
                        {
                            list1.ImageIndex = j;
                            listViewHorario.Items.Add(list1);
                        }


                    }

                }


            }




            //listViewHorario.Columns[2].ListView.Items.Add(cmbGrupo.Text);
            //listViewHorario.Items.Add(cmbMateria.Text);
            //listViewHorario.Items.Add(cmbHoras.Text);
            //listViewHorario.Items.Add(comboBox4.Text);
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            int repuesta = 0;
            // int IdGrupo = cmbGrupo.SelectedText;
             IdGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());
            
            //int Iddia = int.Parse(cmbGrupo.SelectedValue.ToString());
            for (int i = 0; i < listViewHorario.Items.Count; i++)
            {
                //for (int j = 0; j < listViewHorario.Items[i].SubItems.Count; j++)
                //{
                   // MessageBox.Show(listViewHorario.Items[i].SubItems[2].Text);

                    string _materia = listViewHorario.Items[i].SubItems[4].Text; // tomamos la materia 
                     _dia= listViewHorario.Items[i].SubItems[2].Text; // tomamos el dia 
                     _hora = listViewHorario.Items[i].SubItems[3].Text; // tomamos la hora 


                //}

               repuesta =  this.controlador.mtdValidarHorario(_hora, _dia, _materia, IdGrupo);

                if (repuesta == -1)
                {
                    mensajeAdvertencia("Lo sentimos no puedes agregar hora a esta  materia "+_materia+" sin intensidad horaria, creela por favor", true);
                    break;
                }
                else if (repuesta == -2)
                {
                    mensajeAdvertencia("El horario para este grupo ya existe", true);
                    break;
                }
                else if (repuesta == -3)
                {
                    mensajeAdvertencia("Esta sobre pasando la intensidad horaria  para esta materia " + _materia + "", true);
                    break;
                }
                else
                {
                    MessageBox.Show("Guardado con exito!");
                    break;
                }



            }



        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
           
                _nuevoGrupoSelecionado = cmbGrupo.Text.ToString();
                string grupoenLista = "";

                if (listViewHorario.Items.Count > 0)
                {
                     grupoenLista = listViewHorario.Items[0].SubItems[1].Text;
                }

                if (_nuevoGrupoSelecionado != grupoenLista && listViewHorario.Items.Count > 0)
                {
                    this.mensajeAdvertencia("Hey! no puedes seleccionar otro grupo, guarda los cambios!", false);
                    btnAgregarTodo.Enabled = false;
                }
                else
                {
                    listViewHorario.Items.Clear();
                    //horario objHorario = new horario();
                    IdGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());
                    var listaHorario = controlador.mtdBuscarHorarioPorGrupo(IdGrupo);


                    for (int i = 0; i < listaHorario.Rows.Count; i++)
                    {
                        ListViewItem list2 = new ListViewItem();
                        list2.SubItems.Add(listaHorario.Rows[i][0].ToString());
                        list2.SubItems.Add(listaHorario.Rows[i][2].ToString());
                        list2.SubItems.Add(listaHorario.Rows[i][4].ToString() + " A " + listaHorario.Rows[i][3].ToString());
                        list2.SubItems.Add(listaHorario.Rows[i][1].ToString());
                       
                        // list2.SubItems.Add();


                        listViewHorario.Items.Add(list2);

                    }


                    // foreach (var element in listaHorario)
                    // {

                    // list2.SubItems.Add(listaHorario[count].ToString());
                    // list2.SubItems.Add(((ArrayList)element)[count].ToString());
                    //list2.SubItems.Add(element.ToString());
                    //list2.SubItems.Add(element.ToString());
                    //  count++;



                    //}

                    // ListViewItem list1 = new ListViewItem(cmbGrupo.Text);


                    // listViewHorario.Text = nombre + "  " + apellido;

                    //Buscamos por el Id del grupo el horario que hay 
                    btnAgregarTodo.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           

        }

        private void mensajeAdvertencia(string mensaje, bool statusBoton)
        {
            MessageBox.Show(mensaje, "Advertencia",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnAgregarTodo.Enabled = statusBoton;
        }

        private void listViewHorario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro que quieres eliminar este registro?", "Mensaje", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < listViewHorario.Items.Count; i++)
                {
                    if (listViewHorario.Items[i].Selected)
                    {
                        listViewHorario.Items[i].Remove();
                        i--;
                    }
                }
            }
            
        }

        private void listViewHorario_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            

        }

        private void listViewHorario_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listViewHorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool validacionLista(string NuevaHora, string NuevoDia )
        {
            bool retorno = true;

            for (int i = 0; i < listViewHorario.Items.Count; i++)
            {
               // MessageBox.Show(listViewHorario.Items[i].SubItems[2].Text);

                _dia = listViewHorario.Items[i].SubItems[2].Text; // tomamos el dia 
                _hora = listViewHorario.Items[i].SubItems[3].Text; // tomamos la hora 

                if (_dia == NuevoDia && _hora == NuevaHora)
                {

                    this.mensajeAdvertencia("Esta Hora  ya esta asignada para este dia!",true);
                    retorno = false;
                }

            }
            return retorno;

        }
    }
}
