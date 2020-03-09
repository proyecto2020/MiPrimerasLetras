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
            this.lbltitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameGrado = new System.Windows.Forms.TextBox();
            this.listProfesores = new System.Windows.Forms.CheckedListBox();
            this.btnRegistrarTodo = new System.Windows.Forms.Button();
            this.btnGuardarGrado = new System.Windows.Forms.Button();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.cmbAB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGuardarAM = new System.Windows.Forms.Button();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.lbMateria = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // listProfesores
            // 
            this.listProfesores.FormattingEnabled = true;
            this.listProfesores.Location = new System.Drawing.Point(307, 228);
            this.listProfesores.Name = "listProfesores";
            this.listProfesores.Size = new System.Drawing.Size(205, 174);
            this.listProfesores.TabIndex = 6;
            // 
            // btnRegistrarTodo
            // 
            this.btnRegistrarTodo.Location = new System.Drawing.Point(307, 471);
            this.btnRegistrarTodo.Name = "btnRegistrarTodo";
            this.btnRegistrarTodo.Size = new System.Drawing.Size(205, 67);
            this.btnRegistrarTodo.TabIndex = 7;
            this.btnRegistrarTodo.Text = "Guardar";
            this.btnRegistrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarGrado
            // 
            this.btnGuardarGrado.Location = new System.Drawing.Point(94, 215);
            this.btnGuardarGrado.Name = "btnGuardarGrado";
            this.btnGuardarGrado.Size = new System.Drawing.Size(168, 33);
            this.btnGuardarGrado.TabIndex = 8;
            this.btnGuardarGrado.Text = "Guardar";
            this.btnGuardarGrado.UseVisualStyleBackColor = true;
            // 
            // cmbGrado
            // 
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(307, 168);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(205, 24);
            this.cmbGrado.TabIndex = 9;
            // 
            // cmbAB
            // 
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(786, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1005, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 14;
            // 
            // btnGuardarAM
            // 
            this.btnGuardarAM.Location = new System.Drawing.Point(995, 240);
            this.btnGuardarAM.Name = "btnGuardarAM";
            this.btnGuardarAM.Size = new System.Drawing.Size(169, 49);
            this.btnGuardarAM.TabIndex = 15;
            this.btnGuardarAM.Text = "Guardar";
            this.btnGuardarAM.UseVisualStyleBackColor = true;
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 16;
            this.lbArea.Items.AddRange(new object[] {
            "uno",
            "dos"});
            this.lbArea.Location = new System.Drawing.Point(741, 376);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(253, 244);
            this.lbArea.TabIndex = 16;
            // 
            // lbMateria
            // 
            this.lbMateria.FormattingEnabled = true;
            this.lbMateria.Items.AddRange(new object[] {
            "pep",
            "epepe"});
            this.lbMateria.Location = new System.Drawing.Point(1005, 376);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(244, 242);
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
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 810);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMateria);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.btnGuardarAM);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAB);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.btnGuardarGrado);
            this.Controls.Add(this.btnRegistrarTodo);
            this.Controls.Add(this.listProfesores);
            this.Controls.Add(this.txtNameGrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestion";
            this.Text = "frmGestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameGrado;
        private System.Windows.Forms.CheckedListBox listProfesores;
        private System.Windows.Forms.Button btnRegistrarTodo;
        private System.Windows.Forms.Button btnGuardarGrado;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.ComboBox cmbAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGuardarAM;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.CheckedListBox lbMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}