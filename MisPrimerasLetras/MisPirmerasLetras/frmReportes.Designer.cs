namespace MisPirmerasLetras
{
    partial class frmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAlumno_Buscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHidden1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.btnGuardarARMA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxAlumno_Buscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(769, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(778, 64);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // textBoxAlumno_Buscar
            // 
            this.textBoxAlumno_Buscar.Location = new System.Drawing.Point(487, 26);
            this.textBoxAlumno_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAlumno_Buscar.Multiline = true;
            this.textBoxAlumno_Buscar.Name = "textBoxAlumno_Buscar";
            this.textBoxAlumno_Buscar.Size = new System.Drawing.Size(263, 30);
            this.textBoxAlumno_Buscar.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(412, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(87, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Alumnos";
            // 
            // lblHidden1
            // 
            this.lblHidden1.AutoSize = true;
            this.lblHidden1.Location = new System.Drawing.Point(581, 84);
            this.lblHidden1.Name = "lblHidden1";
            this.lblHidden1.Size = new System.Drawing.Size(0, 17);
            this.lblHidden1.TabIndex = 7;
            this.lblHidden1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGEstudiantes);
            this.panel2.Location = new System.Drawing.Point(757, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 545);
            this.panel2.TabIndex = 6;
            // 
            // dataGEstudiantes
            // 
            this.dataGEstudiantes.AllowUserToAddRows = false;
            this.dataGEstudiantes.AllowUserToDeleteRows = false;
            this.dataGEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGEstudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGEstudiantes.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGEstudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGEstudiantes.ColumnHeadersHeight = 39;
            this.dataGEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGEstudiantes.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGEstudiantes.EnableHeadersVisualStyles = false;
            this.dataGEstudiantes.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGEstudiantes.Location = new System.Drawing.Point(33, 26);
            this.dataGEstudiantes.Name = "dataGEstudiantes";
            this.dataGEstudiantes.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGEstudiantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGEstudiantes.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGEstudiantes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGEstudiantes.RowTemplate.Height = 24;
            this.dataGEstudiantes.Size = new System.Drawing.Size(749, 613);
            this.dataGEstudiantes.TabIndex = 30;
            this.dataGEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGEstudiantes_CellContentClick);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(901, 664);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeriodo.Multiline = true;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(73, 39);
            this.txtPeriodo.TabIndex = 9;
            // 
            // btnGuardarARMA
            // 
            this.btnGuardarARMA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardarARMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarARMA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.FlatAppearance.BorderSize = 0;
            this.btnGuardarARMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarARMA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarARMA.Location = new System.Drawing.Point(993, 664);
            this.btnGuardarARMA.Name = "btnGuardarARMA";
            this.btnGuardarARMA.Size = new System.Drawing.Size(136, 104);
            this.btnGuardarARMA.TabIndex = 32;
            this.btnGuardarARMA.Text = "Notas";
            this.btnGuardarARMA.UseVisualStyleBackColor = false;
            this.btnGuardarARMA.Click += new System.EventHandler(this.btnGuardarARMA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(733, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Periodo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1405, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 104);
            this.button1.TabIndex = 34;
            this.button1.Text = "Pagos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(35, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(700, 574);
            this.reportViewer1.TabIndex = 35;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 780);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarARMA);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblHidden1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxAlumno_Buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHidden1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGEstudiantes;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Button btnGuardarARMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}