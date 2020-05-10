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
            this.label7 = new System.Windows.Forms.Label();
            this.txtIntensidadhoraria = new System.Windows.Forms.TextBox();
            this.lbGrados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarAM = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtgrados = new System.Windows.Forms.DataGridView();
            this.dtMaterias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(1139, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Intensidad horaria";
            // 
            // txtIntensidadhoraria
            // 
            this.txtIntensidadhoraria.Location = new System.Drawing.Point(1143, 115);
            this.txtIntensidadhoraria.Name = "txtIntensidadhoraria";
            this.txtIntensidadhoraria.Size = new System.Drawing.Size(168, 22);
            this.txtIntensidadhoraria.TabIndex = 34;
            // 
            // lbGrados
            // 
            this.lbGrados.FormattingEnabled = true;
            this.lbGrados.ItemHeight = 16;
            this.lbGrados.Location = new System.Drawing.Point(1143, 488);
            this.lbGrados.Name = "lbGrados";
            this.lbGrados.Size = new System.Drawing.Size(114, 164);
            this.lbGrados.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 75);
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
            this.btnGuardarAM.Location = new System.Drawing.Point(787, 687);
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
            this.button2.Location = new System.Drawing.Point(619, 687);
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
            this.label3.Location = new System.Drawing.Point(721, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Materias";
            // 
            // Dtgrados
            // 
            this.Dtgrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtgrados.Location = new System.Drawing.Point(54, 113);
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
            this.dtMaterias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dtMaterias.Location = new System.Drawing.Point(619, 113);
            this.dtMaterias.Name = "dtMaterias";
            this.dtMaterias.RowHeadersWidth = 51;
            this.dtMaterias.RowTemplate.Height = 24;
            this.dtMaterias.Size = new System.Drawing.Size(303, 526);
            this.dtMaterias.TabIndex = 45;
            this.dtMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMaterias_CellContentClick);
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
            this.Controls.Add(this.lbGrados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIntensidadhoraria);
            this.Name = "frmIntensidadHoraria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIntensidadHoraria";
            this.Load += new System.EventHandler(this.frmIntensidadHoraria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIntensidadhoraria;
        private System.Windows.Forms.ListBox lbGrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarAM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dtgrados;
        private System.Windows.Forms.DataGridView dtMaterias;
    }
}