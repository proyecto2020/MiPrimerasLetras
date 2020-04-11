using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginControlador;
using MisPirmerasLetras.Libreria;
using LinqToDB;
using System.IO;

namespace MisPirmerasLetras
{
   
    public partial class frmPagos : Form
    {
        private LoginControlador.LoginControlador controlador;

        public int _seccion { get; set; }
        private int _idCliente = 0;
        private int _reg_por_pagina = 10, _num_pagina = 1;
        private decimal saldo, total_pagar;
        private int Id_pago;
        
        public frmPagos()
        {
            InitializeComponent();
            this.controlador = new LoginControlador.LoginControlador();
        }

        private void lblDeuda_Click(object sender, EventArgs e)
        {

        }

        private void frmPagos_Load(object sender, EventArgs e)
        {

            List<Alumnos> alumnos = this.controlador.mtdListarAlumnos();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if (0 < alumnos.Count)
            {
                dataGEstudiantes.DataSource = alumnos.Skip(inicio).Take(_reg_por_pagina).ToList();
                dataGEstudiantes.Columns[0].Visible = false;
                dataGEstudiantes.Columns[8].Visible = false;
                dataGEstudiantes.Columns[14].Visible = false;
                dataGEstudiantes.Columns[13].Visible = false;
                dataGEstudiantes.Columns[10].Visible = false;
                dataGEstudiantes.Columns[11].Visible = false;
                dataGEstudiantes.Columns[12].Visible = false;
                dataGEstudiantes.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGEstudiantes.Columns[7].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }
        private int _idEstudante;

        private void llenarDatosDePago()
        {

            _idEstudante = Convert.ToInt16(dataGEstudiantes.CurrentRow.Cells[0].Value);

            var resultado = this.controlador.listarPago(_idEstudante);

            string nombre = Convert.ToString(dataGEstudiantes.CurrentRow.Cells[1].Value);
            string apellido = Convert.ToString(dataGEstudiantes.CurrentRow.Cells[2].Value);
            lblNombreEs.Text = nombre + "  " + apellido;
            lblDeuda.Text = Convert.ToString(resultado[0].total);
            lblFechaDeuda.Text = Convert.ToString(resultado[0].fecha_limite);
            lblUltimoPago.Text = Convert.ToString(resultado[0].saldo);
            lblFechaPago.Text = Convert.ToString(resultado[0].mes);
            saldo = resultado[0].saldo;
            total_pagar = resultado[0].total;
            Id_pago = resultado[0].id_pago;

            if (resultado[0].paz_y_salvo)
            {
                btnGuardarARMA.Enabled = false;
                lblStatus.Text = "El estudiante no tienen deduda";
            }
            else
            {
                lblStatus.Text = "";
                btnGuardarARMA.Enabled = true;
            }
        }
        private void dataGEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGEstudiantes.Rows.Count != 0)
                llenarDatosDePago();

                //_idCliente = Convert.ToInt16(dataEstudiantes.CurrentRow.Cells[0].Value);
                //lblDeuda.Text = Convert.ToString(dataEstudiantes.CurrentRow.Cells[1].Value);



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objetos.eventos.numberDecimalKeyPress(txtPagoAlumno, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void btnGuardarARMA_Click(object sender, EventArgs e)
        {
            _idEstudante = Convert.ToInt16(dataGEstudiantes.CurrentRow.Cells[0].Value);
            if (_idEstudante.Equals(0))
            {
                labelReport_Pagos.Text = "Seleccione un estudiante";
            }
            else
            {
                if (txtPagoAlumno.Text.Equals(""))
                {
                    labelReport_Pagos.Text = "Ingrese el pago";
                    txtPagoAlumno.Focus();
                }
                else
                {
                    var dateNow = DateTime.Now;
                    var nowDate = $"{dateNow.Day}/{dateNow.Month}/{dateNow.Year}";
                    Codigos codigos = new Codigos();
                    if (!lblDeuda.Equals(0))
                    {
                        var date = DateTime.Now.AddMonths(1);

                        var fechalimite = lblFechaDeuda.Equals(0) ? "--/--/--" : $"{date.Day}/{date.Month}/{ date.Year}";
                        var ticket = codigos.codigosTickets("0000000000");

                        var pago = String.Format("{0:#,###,###,##0.00####}", txtPagoAlumno);
                        var deuda = String.Format("{0:#,###,###,##0.00####}", lblDeuda);
                        var saldoActual = String.Format("{0:#,###,###,##0.00####}", lblUltimoPago);

                        // creamos el objeto

                        Pagos objPago = new Pagos();
                        objPago.abono = Decimal.Parse(txtPagoAlumno.Text);
                        objPago.mes = nowDate; //mes en el que pago
                        objPago.fk_alumno = _idEstudante;
                        objPago.ticket = ticket;
                        objPago.total = total_pagar;
                        objPago.fecha_limite = fechalimite; // la fecha limite la podemos sacar cuando el estudiante es matricualdo y saca credito con el jardin



                        if (objPago.abono == saldo)
                        {
                            objPago.paz_y_salvo = true;
                        }
                        else
                        {
                            objPago.paz_y_salvo = false;
                        }
                            

                        //var cambio = String.Format("{0:#,###,###,##0.00####}", _cambio);
                        int validar =  this.controlador.mtdInsertarPago(objPago, saldo, Id_pago);

                        if (validar.Equals(1))
                        {
                            MessageBox.Show("Se ha registrado con exito su pago");
                            txtPagoAlumno.Text = "";
                            llenarDatosDePago();
                        }

                        Ticket Ticket1 = new Ticket();
                        Ticket1.AbreCajon();  //abre el cajon
                        Ticket1.TextoCentro("Jardin infantil, Mis primeras Letras"); // imprime en el centro 
                        Ticket1.TextoIzquierda("Direccion: Cll x # x - xxx");
                        Ticket1.TextoIzquierda("Bogotá, Cundinamarca");
                        Ticket1.TextoIzquierda("Tel 658912146");
                        Ticket1.LineasGuion();
                        Ticket1.TextoCentro("FACTURA"); // imprime en el centro 
                        Ticket1.LineasGuion();
                        Ticket1.TextoIzquierda($"Factura:{ticket}");
                        Ticket1.TextoIzquierda($"Cliente:{lblNombreEs.Text}");
                        Ticket1.TextoIzquierda($"Fecha:{nowDate}");
                        //Ticket1.TextoIzquierda($"Usuario:{usuario}");
                        Ticket1.LineasGuion();
                        Ticket1.TextoExtremo("Saldo:", $"{saldoActual}");
                        Ticket1.TextoExtremo("Pago:", $"{pago}");

                        Ticket1.TextoExtremo("Deuda:", $"{deuda}");
                        Ticket1.TextoExtremo("Próximo pago:", $"{fechalimite}");
                        Ticket1.TextoCentro("PDHN");

                        Ticket1.CortaTicket(); // corta el ticket

                       // Ticket1.ImprimirTicket("Microsoft XPS Document Writer");




                    }
                }
            }
        }

        private void lblHidden1_Click(object sender, EventArgs e)
        {

        }

        private void dataEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e){ }
    }
}
