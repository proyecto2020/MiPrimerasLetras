namespace MisPirmerasLetras
{
    partial class frmAdminUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUsers));
            this.lbltitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntAddUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataEstudiantes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PirmerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstudiantes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(179, 9);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(201, 44);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "USUARIOS";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(37, 78);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(122, 20);
            this.tbxName.TabIndex = 8;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbRol);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.bntAddUsuario);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 194);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "contraseña";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "estado";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(461, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(464, 78);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(122, 20);
            this.txtCorreo.TabIndex = 14;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(324, 140);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(122, 21);
            this.cmbRol.TabIndex = 13;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            this.cmbRol.SelectedValueChanged += new System.EventHandler(this.cmbRol_SelectedValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bntAddUsuario
            // 
            this.bntAddUsuario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bntAddUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAddUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.bntAddUsuario.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntAddUsuario.Location = new System.Drawing.Point(214, 512);
            this.bntAddUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.bntAddUsuario.Name = "bntAddUsuario";
            this.bntAddUsuario.Size = new System.Drawing.Size(111, 54);
            this.bntAddUsuario.TabIndex = 1;
            this.bntAddUsuario.Text = "Agregar";
            this.bntAddUsuario.UseVisualStyleBackColor = false;
            this.bntAddUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(48, 512);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 78);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label6.Location = new System.Drawing.Point(321, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Perfil";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(321, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Segundo Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Primer Apellido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(470, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 21);
            this.button3.TabIndex = 17;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataEstudiantes
            // 
            this.dataEstudiantes.AllowUserToAddRows = false;
            this.dataEstudiantes.AllowUserToDeleteRows = false;
            this.dataEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PirmerApellido,
            this.SegundoApellido,
            this.correo,
            this.perfil});
            this.dataEstudiantes.Location = new System.Drawing.Point(37, 25);
            this.dataEstudiantes.Name = "dataEstudiantes";
            this.dataEstudiantes.Size = new System.Drawing.Size(536, 166);
            this.dataEstudiantes.TabIndex = 6;
            this.dataEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEstudiantes_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // PirmerApellido
            // 
            this.PirmerApellido.DataPropertyName = "PirmerApellido";
            this.PirmerApellido.HeaderText = "Prirmer Apellido";
            this.PirmerApellido.Name = "PirmerApellido";
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            // 
            // correo
            // 
            this.correo.DataPropertyName = "Correo";
            this.correo.HeaderText = "correo";
            this.correo.Name = "correo";
            // 
            // perfil
            // 
            this.perfil.DataPropertyName = "Perfil";
            this.perfil.HeaderText = "perfil";
            this.perfil.Name = "perfil";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataEstudiantes);
            this.panel2.Location = new System.Drawing.Point(12, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 194);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // frmAdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(629, 640);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminUsers";
            this.Text = "frmAdminUsers";
            this.Load += new System.EventHandler(this.frmAdminUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstudiantes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bntAddUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataEstudiantes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PirmerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
    }
}