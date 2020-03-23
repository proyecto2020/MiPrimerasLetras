namespace MisPirmerasLetras
{
    partial class frmGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestion));
            this.lbltitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameGrado = new System.Windows.Forms.TextBox();
            this.btnRegistrarTodo = new System.Windows.Forms.Button();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.cmbAB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.btnGuardarAM = new System.Windows.Forms.Button();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.lbMateria = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ltbProfesores = new System.Windows.Forms.ListBox();
            this.btnGuardarARMA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(284, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(658, 56);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "ADMINISTRACIÓN GENERAL";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupo";
            // 
            // txtNameGrado
            // 
            this.txtNameGrado.Location = new System.Drawing.Point(94, 168);
            this.txtNameGrado.Name = "txtNameGrado";
            this.txtNameGrado.Size = new System.Drawing.Size(168, 22);
            this.txtNameGrado.TabIndex = 4;
            // 
            // btnRegistrarTodo
            // 
            this.btnRegistrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarTodo.FlatAppearance.BorderSize = 0;
            this.btnRegistrarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTodo.Location = new System.Drawing.Point(307, 471);
            this.btnRegistrarTodo.Name = "btnRegistrarTodo";
            this.btnRegistrarTodo.Size = new System.Drawing.Size(205, 67);
            this.btnRegistrarTodo.TabIndex = 7;
            this.btnRegistrarTodo.Text = "Guardar";
            this.btnRegistrarTodo.UseVisualStyleBackColor = false;
            this.btnRegistrarTodo.Click += new System.EventHandler(this.btnRegistrarTodo_Click);
            // 
            // cmbGrado
            // 
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(307, 168);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(205, 24);
            this.cmbGrado.TabIndex = 9;
            this.cmbGrado.SelectedIndexChanged += new System.EventHandler(this.cmbGrado_SelectedIndexChanged);
            // 
            // cmbAB
            // 
            this.cmbAB.DisplayMember = "1,2";
            this.cmbAB.FormattingEnabled = true;
            this.cmbAB.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbAB.Location = new System.Drawing.Point(541, 168);
            this.cmbAB.Name = "cmbAB";
            this.cmbAB.Size = new System.Drawing.Size(47, 24);
            this.cmbAB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1016, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Materia";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(786, 168);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(166, 22);
            this.txtArea.TabIndex = 13;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(1005, 168);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(159, 22);
            this.txtMateria.TabIndex = 14;
            // 
            // btnGuardarAM
            // 
            this.btnGuardarAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.FlatAppearance.BorderSize = 0;
            this.btnGuardarAM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAM.Location = new System.Drawing.Point(995, 240);
            this.btnGuardarAM.Name = "btnGuardarAM";
            this.btnGuardarAM.Size = new System.Drawing.Size(205, 67);
            this.btnGuardarAM.TabIndex = 15;
            this.btnGuardarAM.Text = "Guardar";
            this.btnGuardarAM.UseVisualStyleBackColor = false;
            this.btnGuardarAM.Click += new System.EventHandler(this.btnGuardarAM_Click);
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 16;
            this.lbArea.Location = new System.Drawing.Point(741, 376);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(253, 244);
            this.lbArea.TabIndex = 16;
            // 
            // lbMateria
            // 
            this.lbMateria.FormattingEnabled = true;
            this.lbMateria.Location = new System.Drawing.Point(1005, 376);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(253, 242);
            this.lbMateria.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Selccionar Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1016, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seleccionar Materia(s)";
            // 
            // ltbProfesores
            // 
            this.ltbProfesores.FormattingEnabled = true;
            this.ltbProfesores.ItemHeight = 16;
            this.ltbProfesores.Location = new System.Drawing.Point(307, 205);
            this.ltbProfesores.Name = "ltbProfesores";
            this.ltbProfesores.Size = new System.Drawing.Size(205, 212);
            this.ltbProfesores.TabIndex = 21;
            this.ltbProfesores.SelectedIndexChanged += new System.EventHandler(this.ltbProfesores_SelectedIndexChanged);
            // 
            // btnGuardarARMA
            // 
            this.btnGuardarARMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarARMA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.FlatAppearance.BorderSize = 0;
            this.btnGuardarARMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarARMA.Location = new System.Drawing.Point(1040, 637);
            this.btnGuardarARMA.Name = "btnGuardarARMA";
            this.btnGuardarARMA.Size = new System.Drawing.Size(205, 67);
            this.btnGuardarARMA.TabIndex = 22;
            this.btnGuardarARMA.Text = "Guardar";
            this.btnGuardarARMA.UseVisualStyleBackColor = false;
            this.btnGuardarARMA.Click += new System.EventHandler(this.btnGuardarARMA_Click);
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 810);
            this.Controls.Add(this.btnGuardarARMA);
            this.Controls.Add(this.ltbProfesores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMateria);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.btnGuardarAM);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAB);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.btnRegistrarTodo);
            this.Controls.Add(this.txtNameGrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestion";
            this.Text = "frmGestion";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameGrado;
        private System.Windows.Forms.Button btnRegistrarTodo;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.ComboBox cmbAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnGuardarAM;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.CheckedListBox lbMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ltbProfesores;
        private System.Windows.Forms.Button btnGuardarARMA;
    }
}