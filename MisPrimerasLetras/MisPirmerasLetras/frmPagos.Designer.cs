namespace MisPirmerasLetras
{
    partial class frmPagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarARMA = new System.Windows.Forms.Button();
            this.txtPagoAlumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreEs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGEstudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblTxFechaPago = new System.Windows.Forms.Label();
            this.lblUltimoPago = new System.Windows.Forms.Label();
            this.lblTxUltimoPago = new System.Windows.Forms.Label();
            this.lblFechaDeuda = new System.Windows.Forms.Label();
            this.lblTxFechaDeuda = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblTxDeuda = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGEstudiantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información de pago";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnGuardarARMA);
            this.panel1.Controls.Add(this.txtPagoAlumno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTicket);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNombreEs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 742);
            this.panel1.TabIndex = 1;
            // 
            // btnGuardarARMA
            // 
            this.btnGuardarARMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarARMA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.FlatAppearance.BorderSize = 0;
            this.btnGuardarARMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarARMA.Location = new System.Drawing.Point(308, 661);
            this.btnGuardarARMA.Name = "btnGuardarARMA";
            this.btnGuardarARMA.Size = new System.Drawing.Size(174, 62);
            this.btnGuardarARMA.TabIndex = 31;
            this.btnGuardarARMA.Text = "Guardar";
            this.btnGuardarARMA.UseVisualStyleBackColor = false;
            // 
            // txtPagoAlumno
            // 
            this.txtPagoAlumno.Location = new System.Drawing.Point(90, 607);
            this.txtPagoAlumno.Name = "txtPagoAlumno";
            this.txtPagoAlumno.Size = new System.Drawing.Size(171, 22);
            this.txtPagoAlumno.TabIndex = 14;
            this.txtPagoAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pago";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(185, 504);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(153, 23);
            this.lblTicket.TabIndex = 12;
            this.lblTicket.Text = "0000000000000";
            this.lblTicket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ticket:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Información adicional";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreEs
            // 
            this.lblNombreEs.AutoSize = true;
            this.lblNombreEs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEs.Location = new System.Drawing.Point(200, 77);
            this.lblNombreEs.Name = "lblNombreEs";
            this.lblNombreEs.Size = new System.Drawing.Size(170, 21);
            this.lblNombreEs.TabIndex = 1;
            this.lblNombreEs.Text = "Nombre Estudiante";
            this.lblNombreEs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGEstudiantes);
            this.panel2.Location = new System.Drawing.Point(623, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 664);
            this.panel2.TabIndex = 2;
            // 
            // dataGEstudiantes
            // 
            this.dataGEstudiantes.AllowUserToAddRows = false;
            this.dataGEstudiantes.AllowUserToDeleteRows = false;
            this.dataGEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGEstudiantes.Location = new System.Drawing.Point(35, 33);
            this.dataGEstudiantes.Name = "dataGEstudiantes";
            this.dataGEstudiantes.ReadOnly = true;
            this.dataGEstudiantes.RowHeadersWidth = 51;
            this.dataGEstudiantes.RowTemplate.Height = 24;
            this.dataGEstudiantes.Size = new System.Drawing.Size(859, 613);
            this.dataGEstudiantes.TabIndex = 29;
            this.dataGEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGEstudiantes_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblFechaPago);
            this.groupBox1.Controls.Add(this.lblTxFechaPago);
            this.groupBox1.Controls.Add(this.lblUltimoPago);
            this.groupBox1.Controls.Add(this.lblTxUltimoPago);
            this.groupBox1.Controls.Add(this.lblFechaDeuda);
            this.groupBox1.Controls.Add(this.lblTxFechaDeuda);
            this.groupBox1.Controls.Add(this.lblDeuda);
            this.groupBox1.Controls.Add(this.lblTxDeuda);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(15, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 264);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(289, 228);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(76, 23);
            this.lblFechaPago.TabIndex = 17;
            this.lblFechaPago.Text = "--/--/--";
            this.lblFechaPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTxFechaPago
            // 
            this.lblTxFechaPago.AutoSize = true;
            this.lblTxFechaPago.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxFechaPago.Location = new System.Drawing.Point(309, 180);
            this.lblTxFechaPago.Name = "lblTxFechaPago";
            this.lblTxFechaPago.Size = new System.Drawing.Size(145, 19);
            this.lblTxFechaPago.TabIndex = 16;
            this.lblTxFechaPago.Text = " Fecha del pago";
            this.lblTxFechaPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUltimoPago
            // 
            this.lblUltimoPago.AutoSize = true;
            this.lblUltimoPago.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoPago.Location = new System.Drawing.Point(64, 228);
            this.lblUltimoPago.Name = "lblUltimoPago";
            this.lblUltimoPago.Size = new System.Drawing.Size(48, 23);
            this.lblUltimoPago.TabIndex = 15;
            this.lblUltimoPago.Text = "0.00";
            this.lblUltimoPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTxUltimoPago
            // 
            this.lblTxUltimoPago.AutoSize = true;
            this.lblTxUltimoPago.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxUltimoPago.Location = new System.Drawing.Point(55, 180);
            this.lblTxUltimoPago.Name = "lblTxUltimoPago";
            this.lblTxUltimoPago.Size = new System.Drawing.Size(112, 19);
            this.lblTxUltimoPago.TabIndex = 14;
            this.lblTxUltimoPago.Text = "Ultimo pago ";
            this.lblTxUltimoPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFechaDeuda
            // 
            this.lblFechaDeuda.AutoSize = true;
            this.lblFechaDeuda.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeuda.Location = new System.Drawing.Point(289, 66);
            this.lblFechaDeuda.Name = "lblFechaDeuda";
            this.lblFechaDeuda.Size = new System.Drawing.Size(76, 23);
            this.lblFechaDeuda.TabIndex = 13;
            this.lblFechaDeuda.Text = "--/--/--";
            this.lblFechaDeuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTxFechaDeuda
            // 
            this.lblTxFechaDeuda.AutoSize = true;
            this.lblTxFechaDeuda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxFechaDeuda.Location = new System.Drawing.Point(309, 28);
            this.lblTxFechaDeuda.Name = "lblTxFechaDeuda";
            this.lblTxFechaDeuda.Size = new System.Drawing.Size(171, 19);
            this.lblTxFechaDeuda.TabIndex = 12;
            this.lblTxFechaDeuda.Text = " Fecha de la deuda";
            this.lblTxFechaDeuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(64, 66);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(48, 23);
            this.lblDeuda.TabIndex = 11;
            this.lblDeuda.Text = "0.00";
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTxDeuda
            // 
            this.lblTxDeuda.AutoSize = true;
            this.lblTxDeuda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxDeuda.Location = new System.Drawing.Point(55, 28);
            this.lblTxDeuda.Name = "lblTxDeuda";
            this.lblTxDeuda.Size = new System.Drawing.Size(69, 19);
            this.lblTxDeuda.TabIndex = 10;
            this.lblTxDeuda.Text = "Deuda:";
            this.lblTxDeuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 765);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGEstudiantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreEs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.TextBox txtPagoAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarARMA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGEstudiantes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblTxFechaPago;
        private System.Windows.Forms.Label lblUltimoPago;
        private System.Windows.Forms.Label lblTxUltimoPago;
        private System.Windows.Forms.Label lblFechaDeuda;
        private System.Windows.Forms.Label lblTxFechaDeuda;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblTxDeuda;
    }
}