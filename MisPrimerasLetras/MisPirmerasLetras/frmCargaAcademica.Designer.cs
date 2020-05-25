namespace MisPirmerasLetras
{
    partial class frmCargaAcademica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaAcademica));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHoras = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnSalon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewHorario = new System.Windows.Forms.ListView();
            this.action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHidden = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnIrintensidadHorarias = new System.Windows.Forms.Button();
            this.pnSalon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupo";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(61, 132);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(185, 24);
            this.cmbGrupo.TabIndex = 5;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horas";
            // 
            // cmbHoras
            // 
            this.cmbHoras.FormattingEnabled = true;
            this.cmbHoras.Location = new System.Drawing.Point(61, 284);
            this.cmbHoras.Name = "cmbHoras";
            this.cmbHoras.Size = new System.Drawing.Size(185, 24);
            this.cmbHoras.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Materia";
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(304, 132);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(185, 24);
            this.cmbMateria.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Día";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.comboBox4.Location = new System.Drawing.Point(304, 284);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(185, 24);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.Text = "Seleccione";
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodo.Image")));
            this.btnAgregarTodo.Location = new System.Drawing.Point(546, 212);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(101, 96);
            this.btnAgregarTodo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAgregarTodo, "Agregar campos seleccionados a lista de horario\r\n");
            this.btnAgregarTodo.UseVisualStyleBackColor = false;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(931, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Resultado Horario";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(1130, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn.Location = new System.Drawing.Point(702, 538);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(175, 56);
            this.btn.TabIndex = 15;
            this.btn.Text = "Ver Horarios";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // pnSalon
            // 
            this.pnSalon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSalon.Controls.Add(this.label2);
            this.pnSalon.Controls.Add(this.label7);
            this.pnSalon.Location = new System.Drawing.Point(61, 365);
            this.pnSalon.Name = "pnSalon";
            this.pnSalon.Size = new System.Drawing.Size(445, 157);
            this.pnSalon.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formulario para la creacion de horarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Información";
            // 
            // listViewHorario
            // 
            this.listViewHorario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.action,
            this.Grupo,
            this.Dia,
            this.Hora,
            this.Materia});
            this.listViewHorario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHorario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listViewHorario.HideSelection = false;
            this.listViewHorario.Location = new System.Drawing.Point(686, 91);
            this.listViewHorario.Name = "listViewHorario";
            this.listViewHorario.Size = new System.Drawing.Size(624, 431);
            this.listViewHorario.TabIndex = 0;
            this.listViewHorario.UseCompatibleStateImageBehavior = false;
            this.listViewHorario.View = System.Windows.Forms.View.Details;
            this.listViewHorario.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewHorario_DrawColumnHeader);
            this.listViewHorario.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewHorario_DrawSubItem);
            this.listViewHorario.SelectedIndexChanged += new System.EventHandler(this.listViewHorario_SelectedIndexChanged);
            this.listViewHorario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewHorario_MouseDoubleClick);
            // 
            // action
            // 
            this.action.Text = "";
            this.action.Width = 31;
            // 
            // Grupo
            // 
            this.Grupo.Text = "Grupo";
            this.Grupo.Width = 178;
            // 
            // Dia
            // 
            this.Dia.Text = "Día";
            this.Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dia.Width = 80;
            // 
            // Hora
            // 
            this.Hora.Text = "Horas";
            this.Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hora.Width = 80;
            // 
            // Materia
            // 
            this.Materia.Text = "Materia";
            this.Materia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Materia.Width = 80;
            // 
            // txtHidden
            // 
            this.txtHidden.AutoSize = true;
            this.txtHidden.Location = new System.Drawing.Point(833, 35);
            this.txtHidden.Name = "txtHidden";
            this.txtHidden.Size = new System.Drawing.Size(0, 17);
            this.txtHidden.TabIndex = 19;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "deletev2.png");
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-4, 601);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1352, 109);
            this.materialDivider2.TabIndex = 33;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btnIrintensidadHorarias
            // 
            this.btnIrintensidadHorarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIrintensidadHorarias.Location = new System.Drawing.Point(906, 537);
            this.btnIrintensidadHorarias.Name = "btnIrintensidadHorarias";
            this.btnIrintensidadHorarias.Size = new System.Drawing.Size(195, 56);
            this.btnIrintensidadHorarias.TabIndex = 34;
            this.btnIrintensidadHorarias.Text = "Configurar Intensidad Horaria";
            this.btnIrintensidadHorarias.UseVisualStyleBackColor = false;
            // 
            // frmCargaAcademica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1348, 690);
            this.Controls.Add(this.btnIrintensidadHorarias);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.txtHidden);
            this.Controls.Add(this.listViewHorario);
            this.Controls.Add(this.pnSalon);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargaAcademica";
            this.Text = "frmCargaAcademica";
            this.Load += new System.EventHandler(this.frmCargaAcademica_Load);
            this.pnSalon.ResumeLayout(false);
            this.pnSalon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnSalon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewHorario;
        private System.Windows.Forms.ColumnHeader Grupo;
        private System.Windows.Forms.ColumnHeader Dia;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader Materia;
        private System.Windows.Forms.Label txtHidden;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ColumnHeader action;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Button btnIrintensidadHorarias;
        private System.Windows.Forms.Label label2;
    }
}