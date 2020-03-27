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
            this.lbltitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameGrado = new System.Windows.Forms.TextBox();
            this.btnRegistrarTodo = new System.Windows.Forms.Button();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.cmbAB = new System.Windows.Forms.ComboBox();
            this.ltbProfesores = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(242, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(710, 56);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "ADMINISTRACIÓN DE GRUPOS";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupo";
            // 
            // txtNameGrado
            // 
            this.txtNameGrado.Location = new System.Drawing.Point(13, 58);
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
            this.btnRegistrarTodo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarTodo.Image")));
            this.btnRegistrarTodo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegistrarTodo.Location = new System.Drawing.Point(226, 500);
            this.btnRegistrarTodo.Name = "btnRegistrarTodo";
            this.btnRegistrarTodo.Size = new System.Drawing.Size(205, 67);
            this.btnRegistrarTodo.TabIndex = 7;
            this.btnRegistrarTodo.Text = "Guardar";
            this.btnRegistrarTodo.UseVisualStyleBackColor = false;
            this.btnRegistrarTodo.Click += new System.EventHandler(this.btnRegistrarTodo_Click);
            // 
            // cmbGrado
            // 
            this.cmbGrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(226, 58);
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
            this.cmbAB.Location = new System.Drawing.Point(484, 58);
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
            this.ltbProfesores.Location = new System.Drawing.Point(226, 162);
            this.ltbProfesores.Name = "ltbProfesores";
            this.ltbProfesores.Size = new System.Drawing.Size(205, 276);
            this.ltbProfesores.TabIndex = 21;
            this.toolTip2.SetToolTip(this.ltbProfesores, "Seleccione un profesor para su grupo");
            this.ltbProfesores.SelectedIndexChanged += new System.EventHandler(this.ltbProfesores_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Profesor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "divicion de grupo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbAB);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNameGrado);
            this.panel1.Controls.Add(this.ltbProfesores);
            this.panel1.Controls.Add(this.btnRegistrarTodo);
            this.panel1.Controls.Add(this.cmbGrado);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(80, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 604);
            this.panel1.TabIndex = 26;
            // 
            // frmGestionGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1275, 810);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionGrupos";
            this.Text = "frmGestion";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ListBox ltbProfesores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Panel panel1;
    }
}