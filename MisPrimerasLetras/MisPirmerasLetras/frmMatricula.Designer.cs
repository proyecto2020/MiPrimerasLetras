namespace MisPirmerasLetras
{
    partial class frmMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblPrimerA = new System.Windows.Forms.Label();
            this.txtPrimerA = new System.Windows.Forms.TextBox();
            this.lblSegundoA = new System.Windows.Forms.Label();
            this.txtSegundoA = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAcudiente = new System.Windows.Forms.Label();
            this.txtAcudiente = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rchObservaciones = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.btnGuardarMatricula = new System.Windows.Forms.Button();
            this.dtpFechaLimitePago = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblFechaLimitePago = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(76, 82);
            this.txtNombreA.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(132, 22);
            this.txtNombreA.TabIndex = 0;
            this.txtNombreA.TextChanged += new System.EventHandler(this.txtNombreA_TextChanged);
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(72, 47);
            this.lblNombreE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(58, 17);
            this.lblNombreE.TabIndex = 1;
            this.lblNombreE.Text = "Nombre";
            this.lblNombreE.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrimerA
            // 
            this.lblPrimerA.AutoSize = true;
            this.lblPrimerA.Location = new System.Drawing.Point(277, 47);
            this.lblPrimerA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerA.Name = "lblPrimerA";
            this.lblPrimerA.Size = new System.Drawing.Size(103, 17);
            this.lblPrimerA.TabIndex = 2;
            this.lblPrimerA.Text = "Primer Apellido";
            this.lblPrimerA.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrimerA
            // 
            this.txtPrimerA.Location = new System.Drawing.Point(280, 84);
            this.txtPrimerA.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimerA.Name = "txtPrimerA";
            this.txtPrimerA.Size = new System.Drawing.Size(132, 22);
            this.txtPrimerA.TabIndex = 3;
            this.txtPrimerA.TextChanged += new System.EventHandler(this.txtPrimerA_TextChanged);
            // 
            // lblSegundoA
            // 
            this.lblSegundoA.AutoSize = true;
            this.lblSegundoA.Location = new System.Drawing.Point(443, 47);
            this.lblSegundoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoA.Name = "lblSegundoA";
            this.lblSegundoA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSegundoA.Size = new System.Drawing.Size(119, 17);
            this.lblSegundoA.TabIndex = 4;
            this.lblSegundoA.Text = "Segundo Apellido";
            this.lblSegundoA.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSegundoA
            // 
            this.txtSegundoA.Location = new System.Drawing.Point(443, 82);
            this.txtSegundoA.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegundoA.Name = "txtSegundoA";
            this.txtSegundoA.Size = new System.Drawing.Size(132, 22);
            this.txtSegundoA.TabIndex = 5;
            this.txtSegundoA.TextChanged += new System.EventHandler(this.txtSegundoA_TextChanged);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(627, 82);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(224, 22);
            this.dtpFechaNacimiento.TabIndex = 6;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha nacimiento";
            // 
            // lblAcudiente
            // 
            this.lblAcudiente.AutoSize = true;
            this.lblAcudiente.Location = new System.Drawing.Point(72, 155);
            this.lblAcudiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcudiente.Name = "lblAcudiente";
            this.lblAcudiente.Size = new System.Drawing.Size(71, 17);
            this.lblAcudiente.TabIndex = 8;
            this.lblAcudiente.Text = "Acudiente";
            this.lblAcudiente.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAcudiente
            // 
            this.txtAcudiente.Location = new System.Drawing.Point(76, 193);
            this.txtAcudiente.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcudiente.Name = "txtAcudiente";
            this.txtAcudiente.Size = new System.Drawing.Size(132, 22);
            this.txtAcudiente.TabIndex = 9;
            this.txtAcudiente.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(277, 155);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(281, 193);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 22);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(454, 155);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(700, 155);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 13;
            this.lblCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(443, 193);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 22);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(627, 193);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(193, 22);
            this.txtCorreo.TabIndex = 15;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Observaciones";
            // 
            // rchObservaciones
            // 
            this.rchObservaciones.Location = new System.Drawing.Point(75, 323);
            this.rchObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.rchObservaciones.Name = "rchObservaciones";
            this.rchObservaciones.Size = new System.Drawing.Size(313, 118);
            this.rchObservaciones.TabIndex = 17;
            this.rchObservaciones.Text = "";
            this.rchObservaciones.TextChanged += new System.EventHandler(this.rchObservaciones_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 273);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Grupo";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(651, 321);
            this.cmbGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(160, 24);
            this.cmbGrupo.TabIndex = 21;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(454, 273);
            this.lblOcupacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(76, 17);
            this.lblOcupacion.TabIndex = 23;
            this.lblOcupacion.Text = "Ocupacion";
            this.lblOcupacion.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(443, 323);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(132, 22);
            this.txtOcupacion.TabIndex = 24;
            this.txtOcupacion.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // btnGuardarMatricula
            // 
            this.btnGuardarMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarMatricula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarMatricula.FlatAppearance.BorderSize = 0;
            this.btnGuardarMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMatricula.Location = new System.Drawing.Point(587, 547);
            this.btnGuardarMatricula.Name = "btnGuardarMatricula";
            this.btnGuardarMatricula.Size = new System.Drawing.Size(174, 62);
            this.btnGuardarMatricula.TabIndex = 32;
            this.btnGuardarMatricula.Text = "Guardar";
            this.btnGuardarMatricula.UseVisualStyleBackColor = false;
            this.btnGuardarMatricula.Click += new System.EventHandler(this.btnGuardarMatricula_Click);
            // 
            // dtpFechaLimitePago
            // 
            this.dtpFechaLimitePago.Location = new System.Drawing.Point(-1, 162);
            this.dtpFechaLimitePago.Name = "dtpFechaLimitePago";
            this.dtpFechaLimitePago.Size = new System.Drawing.Size(321, 22);
            this.dtpFechaLimitePago.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTexto);
            this.panel2.Controls.Add(this.lblFechaLimitePago);
            this.panel2.Controls.Add(this.dtpFechaLimitePago);
            this.panel2.Location = new System.Drawing.Point(874, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 304);
            this.panel2.TabIndex = 35;
            // 
            // lblTexto
            // 
            this.lblTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(16, 47);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(281, 101);
            this.lblTexto.TabIndex = 35;
            this.lblTexto.Text = "Al matricularse tiene una deuda con MIS PRIMERAS LETRAS, por favor ingrese la fec" +
    "ha limite de pago de la deuda";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            // 
            // lblFechaLimitePago
            // 
            this.lblFechaLimitePago.AutoSize = true;
            this.lblFechaLimitePago.Location = new System.Drawing.Point(102, 14);
            this.lblFechaLimitePago.Name = "lblFechaLimitePago";
            this.lblFechaLimitePago.Size = new System.Drawing.Size(144, 17);
            this.lblFechaLimitePago.TabIndex = 34;
            this.lblFechaLimitePago.Text = "Fecha Limite de pago";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(865, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 62);
            this.button1.TabIndex = 36;
            this.button1.Text = "Ir a pago";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(300, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 62);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(507, 470);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(319, 23);
            this.lblError.TabIndex = 38;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 810);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardarMatricula);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.rchObservaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtAcudiente);
            this.Controls.Add(this.lblAcudiente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtSegundoA);
            this.Controls.Add(this.lblSegundoA);
            this.Controls.Add(this.txtPrimerA);
            this.Controls.Add(this.lblPrimerA);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.txtNombreA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMatricula";
            this.Text = "frmMatricula";
            this.Load += new System.EventHandler(this.frmMatricula_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblPrimerA;
        private System.Windows.Forms.TextBox txtPrimerA;
        private System.Windows.Forms.Label lblSegundoA;
        private System.Windows.Forms.TextBox txtSegundoA;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAcudiente;
        private System.Windows.Forms.TextBox txtAcudiente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rchObservaciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.Button btnGuardarMatricula;
        private System.Windows.Forms.DateTimePicker dtpFechaLimitePago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFechaLimitePago;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblError;
    }
}