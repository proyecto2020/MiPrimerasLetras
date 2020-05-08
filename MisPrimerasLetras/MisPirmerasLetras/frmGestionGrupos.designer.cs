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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionGrupos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarTodo = new System.Windows.Forms.Button();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.cmbAB = new System.Windows.Forms.ComboBox();
            this.ltbProfesores = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGrupos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameGrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrupos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(476, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(710, 56);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "ADMINISTRACIÓN DE GRUPOS";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
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
            this.btnRegistrarTodo.Location = new System.Drawing.Point(190, 495);
            this.btnRegistrarTodo.Name = "btnRegistrarTodo";
            this.btnRegistrarTodo.Size = new System.Drawing.Size(175, 56);
            this.btnRegistrarTodo.TabIndex = 7;
            this.btnRegistrarTodo.Text = "Guardar";
            this.btnRegistrarTodo.UseVisualStyleBackColor = false;
            this.btnRegistrarTodo.Click += new System.EventHandler(this.btnRegistrarTodo_Click);
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
            this.cmbGrado.SelectedIndexChanged += new System.EventHandler(this.cmbGrado_SelectedIndexChanged);
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
            this.ltbProfesores.SelectedIndexChanged += new System.EventHandler(this.ltbProfesores_SelectedIndexChanged);
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
            // dataGrupos
            // 
            this.dataGrupos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dataGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrupos.EnableHeadersVisualStyles = false;
            this.dataGrupos.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGrupos.Location = new System.Drawing.Point(15, 108);
            this.dataGrupos.Name = "dataGrupos";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dataGrupos.RowHeadersVisible = false;
            this.dataGrupos.RowHeadersWidth = 51;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrupos.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.dataGrupos.RowTemplate.Height = 24;
            this.dataGrupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrupos.Size = new System.Drawing.Size(482, 261);
            this.dataGrupos.TabIndex = 27;
            this.dataGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrupos_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGrupos);
            this.panel2.Location = new System.Drawing.Point(38, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 199);
            this.panel2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(172, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lista de grupos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.lbltitle);
            this.panel3.Location = new System.Drawing.Point(-1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1681, 75);
            this.panel3.TabIndex = 41;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(1055, 120);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 508);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Size = new System.Drawing.Size(578, 479);
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
            this.tabPage9.Size = new System.Drawing.Size(578, 479);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Sede 2";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(1195, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Seleccione un salón";
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
            this.panel4.Location = new System.Drawing.Point(658, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 604);
            this.panel4.TabIndex = 44;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(751, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Creacion de Grupos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(221, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Creacion de Grados";
            // 
            // txtNameGrado
            // 
            this.txtNameGrado.Location = new System.Drawing.Point(167, 58);
            this.txtNameGrado.Name = "txtNameGrado";
            this.txtNameGrado.Size = new System.Drawing.Size(206, 22);
            this.txtNameGrado.TabIndex = 4;
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
            this.btnGrado.Click += new System.EventHandler(this.btnGrado_Click);
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
            this.panel1.Location = new System.Drawing.Point(47, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 269);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Al crear el grupo debes asignar su intensiad horaria haciendo ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(419, 204);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 17);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "cllick aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmGestionGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1679, 810);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionGrupos";
            this.Text = "frmGestion";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrupos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarTodo;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.ComboBox cmbAB;
        private System.Windows.Forms.ListBox ltbProfesores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.DataGridView dataGrupos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
    }
}