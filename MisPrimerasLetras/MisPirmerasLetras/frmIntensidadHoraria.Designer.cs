namespace MisPirmerasLetras
{
    partial class frmIntensidadHoraria
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
            this.btnGuardarAM = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtgrados = new System.Windows.Forms.DataGridView();
            this.dtMaterias = new System.Windows.Forms.DataGridView();
            this.materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Grados";
            // 
            // btnGuardarAM
            // 
            this.btnGuardarAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.FlatAppearance.BorderSize = 0;
            this.btnGuardarAM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAM.Location = new System.Drawing.Point(1001, 711);
            this.btnGuardarAM.Name = "btnGuardarAM";
            this.btnGuardarAM.Size = new System.Drawing.Size(119, 65);
            this.btnGuardarAM.TabIndex = 37;
            this.btnGuardarAM.Text = "Guardar";
            this.btnGuardarAM.UseVisualStyleBackColor = false;
            this.btnGuardarAM.Click += new System.EventHandler(this.btnGuardarAM_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(817, 711);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 65);
            this.button2.TabIndex = 39;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(922, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Materias";
            // 
            // Dtgrados
            // 
            this.Dtgrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtgrados.Location = new System.Drawing.Point(138, 160);
            this.Dtgrados.Name = "Dtgrados";
            this.Dtgrados.RowHeadersWidth = 51;
            this.Dtgrados.RowTemplate.Height = 24;
            this.Dtgrados.Size = new System.Drawing.Size(498, 526);
            this.Dtgrados.TabIndex = 44;
            this.Dtgrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgrados_CellContentClick);
            // 
            // dtMaterias
            // 
            this.dtMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materias,
            this.horas});
            this.dtMaterias.Location = new System.Drawing.Point(817, 160);
            this.dtMaterias.Name = "dtMaterias";
            this.dtMaterias.RowHeadersWidth = 51;
            this.dtMaterias.RowTemplate.Height = 24;
            this.dtMaterias.Size = new System.Drawing.Size(303, 526);
            this.dtMaterias.TabIndex = 45;
            this.dtMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMaterias_CellClick);
            this.dtMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMaterias_CellContentClick);
            this.dtMaterias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtMaterias_KeyDown);
            // 
            // materias
            // 
            this.materias.HeaderText = "Materias";
            this.materias.MinimumWidth = 6;
            this.materias.Name = "materias";
            this.materias.Width = 125;
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas";
            this.horas.MinimumWidth = 6;
            this.horas.Name = "horas";
            this.horas.Width = 125;
            // 
            // frmIntensidadHoraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 788);
            this.Controls.Add(this.dtMaterias);
            this.Controls.Add(this.Dtgrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardarAM);
            this.Controls.Add(this.label1);
            this.Name = "frmIntensidadHoraria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion Intensidad horaria";
            this.Load += new System.EventHandler(this.frmIntensidadHoraria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarAM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dtgrados;
        private System.Windows.Forms.DataGridView dtMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
    }
}