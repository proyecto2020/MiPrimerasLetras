namespace MisPirmerasLetras
{
    partial class frmGestionGrupos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionGrupos));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.cmbAB = new System.Windows.Forms.ComboBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.ltbProfesores = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.pn1grados = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrupos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameGrado = new System.Windows.Forms.TextBox();
            this.pn2Grupos = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarTodo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.pctAccionVerGrado = new System.Windows.Forms.PictureBox();
            this.ptAccionVerGrupos = new System.Windows.Forms.PictureBox();
            this.pn1grados.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrupos)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn2Grupos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAccionVerGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAccionVerGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGrado
            // 
            this.cmbGrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(24, 42);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(205, 24);
            this.cmbGrado.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cmbGrado, "Seleccione por favor un grupo");
            // 
            // cmbAB
            // 
            this.cmbAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAB.DisplayMember = "1,2";
            this.cmbAB.FormattingEnabled = true;
            this.cmbAB.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbAB.Location = new System.Drawing.Point(282, 42);
            this.cmbAB.Name = "cmbAB";
            this.cmbAB.Size = new System.Drawing.Size(47, 24);
            this.cmbAB.TabIndex = 10;
            this.cmbAB.Text = "A";
            this.toolTip1.SetToolTip(this.cmbAB, "Seleccione A o B para la division de su grupo");
            // 
            // ltbProfesores
            // 
            this.ltbProfesores.FormattingEnabled = true;
            this.ltbProfesores.ItemHeight = 16;
            this.ltbProfesores.Location = new System.Drawing.Point(24, 146);
            this.ltbProfesores.Name = "ltbProfesores";
            this.ltbProfesores.Size = new System.Drawing.Size(205, 276);
            this.ltbProfesores.TabIndex = 21;
            this.toolTip2.SetToolTip(this.ltbProfesores, "Seleccione un profesor para su grupo");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(528, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Seleccione un salón";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(964, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Crear de Grupos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(179, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Crear de Grados";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-10, 730);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1690, 102);
            this.materialDivider2.TabIndex = 47;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // pn1grados
            // 
            this.pn1grados.Controls.Add(this.panel2);
            this.pn1grados.Controls.Add(this.panel1);
            this.pn1grados.Location = new System.Drawing.Point(24, 76);
            this.pn1grados.Name = "pn1grados";
            this.pn1grados.Size = new System.Drawing.Size(617, 634);
            this.pn1grados.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGrupos);
            this.panel2.Location = new System.Drawing.Point(14, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 261);
            this.panel2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(216, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lista de grupos";
            // 
            // dataGrupos
            // 
            this.dataGrupos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrupos.EnableHeadersVisualStyles = false;
            this.dataGrupos.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGrupos.Location = new System.Drawing.Point(64, 43);
            this.dataGrupos.Name = "dataGrupos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrupos.RowHeadersVisible = false;
            this.dataGrupos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrupos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrupos.RowTemplate.Height = 24;
            this.dataGrupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrupos.Size = new System.Drawing.Size(482, 261);
            this.dataGrupos.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnGrado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNameGrado);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(14, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 269);
            this.panel1.TabIndex = 29;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(450, 204);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 17);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "cllick aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Al crear el grupo debes asignar su intensiad horaria haciendo ";
            // 
            // btnGrado
            // 
            this.btnGrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGrado.FlatAppearance.BorderSize = 0;
            this.btnGrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGrado.Image = ((System.Drawing.Image)(resources.GetObject("btnGrado.Image")));
            this.btnGrado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGrado.Location = new System.Drawing.Point(167, 102);
            this.btnGrado.Name = "btnGrado";
            this.btnGrado.Size = new System.Drawing.Size(200, 55);
            this.btnGrado.TabIndex = 26;
            this.btnGrado.Text = "Guardar";
            this.btnGrado.UseVisualStyleBackColor = false;
            this.btnGrado.Click += new System.EventHandler(this.btnGrado_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(163, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grado";
            // 
            // txtNameGrado
            // 
            this.txtNameGrado.Location = new System.Drawing.Point(167, 58);
            this.txtNameGrado.Name = "txtNameGrado";
            this.txtNameGrado.Size = new System.Drawing.Size(206, 22);
            this.txtNameGrado.TabIndex = 4;
            // 
            // pn2Grupos
            // 
            this.pn2Grupos.Controls.Add(this.panel4);
            this.pn2Grupos.Controls.Add(this.tabControl1);
            this.pn2Grupos.Controls.Add(this.label4);
            this.pn2Grupos.Location = new System.Drawing.Point(659, 76);
            this.pn2Grupos.Name = "pn2Grupos";
            this.pn2Grupos.Size = new System.Drawing.Size(898, 648);
            this.pn2Grupos.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cmbGrado);
            this.panel4.Controls.Add(this.cmbAB);
            this.panel4.Controls.Add(this.btnRegistrarTodo);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.ltbProfesores);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(13, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 604);
            this.panel4.TabIndex = 46;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(24, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 56);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(29, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupo";
            // 
            // btnRegistrarTodo
            // 
            this.btnRegistrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarTodo.FlatAppearance.BorderSize = 0;
            this.btnRegistrarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTodo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarTodo.Image")));
            this.btnRegistrarTodo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegistrarTodo.Location = new System.Drawing.Point(210, 495);
            this.btnRegistrarTodo.Name = "btnRegistrarTodo";
            this.btnRegistrarTodo.Size = new System.Drawing.Size(151, 56);
            this.btnRegistrarTodo.TabIndex = 7;
            this.btnRegistrarTodo.Text = "Guardar";
            this.btnRegistrarTodo.UseVisualStyleBackColor = false;
            this.btnRegistrarTodo.Click += new System.EventHandler(this.btnRegistrarTodo_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(229, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "divición de grupo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(21, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Profesor";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(410, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 492);
            this.tabControl1.TabIndex = 45;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Size = new System.Drawing.Size(467, 463);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Sede 1";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage9.Size = new System.Drawing.Size(467, 463);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Sede 2";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // pctAccionVerGrado
            // 
            this.pctAccionVerGrado.BackColor = System.Drawing.Color.LightGray;
            this.pctAccionVerGrado.Image = ((System.Drawing.Image)(resources.GetObject("pctAccionVerGrado.Image")));
            this.pctAccionVerGrado.Location = new System.Drawing.Point(383, 30);
            this.pctAccionVerGrado.Name = "pctAccionVerGrado";
            this.pctAccionVerGrado.Size = new System.Drawing.Size(28, 26);
            this.pctAccionVerGrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctAccionVerGrado.TabIndex = 50;
            this.pctAccionVerGrado.TabStop = false;
            this.pctAccionVerGrado.Click += new System.EventHandler(this.pctAccionVerGrado_Click);
            // 
            // ptAccionVerGrupos
            // 
            this.ptAccionVerGrupos.BackColor = System.Drawing.Color.LightGray;
            this.ptAccionVerGrupos.Image = ((System.Drawing.Image)(resources.GetObject("ptAccionVerGrupos.Image")));
            this.ptAccionVerGrupos.Location = new System.Drawing.Point(1165, 30);
            this.ptAccionVerGrupos.Name = "ptAccionVerGrupos";
            this.ptAccionVerGrupos.Size = new System.Drawing.Size(28, 26);
            this.ptAccionVerGrupos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptAccionVerGrupos.TabIndex = 51;
            this.ptAccionVerGrupos.TabStop = false;
            this.ptAccionVerGrupos.Click += new System.EventHandler(this.ptAccionVerGrupos_Click);
            // 
            // frmGestionGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1679, 810);
            this.Controls.Add(this.pn2Grupos);
            this.Controls.Add(this.pn1grados);
            this.Controls.Add(this.ptAccionVerGrupos);
            this.Controls.Add(this.pctAccionVerGrado);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionGrupos";
            this.Text = "frmGestion";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            this.pn1grados.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrupos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn2Grupos.ResumeLayout(false);
            this.pn2Grupos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctAccionVerGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAccionVerGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Panel pn1grados;
        private System.Windows.Forms.Panel pn2Grupos;
        private System.Windows.Forms.PictureBox pctAccionVerGrado;
        private System.Windows.Forms.PictureBox ptAccionVerGrupos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrupos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameGrado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.ComboBox cmbAB;
        private System.Windows.Forms.Button btnRegistrarTodo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox ltbProfesores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
    }
}