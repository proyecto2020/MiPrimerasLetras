namespace MisPirmerasLetras
{
    partial class frmGestionMaterias
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMateria = new System.Windows.Forms.CheckedListBox();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.btnGuardarAM = new System.Windows.Forms.Button();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarARMA = new System.Windows.Forms.Button();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Seleccionar Materia(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Selccionar Area";
            // 
            // lbMateria
            // 
            this.lbMateria.FormattingEnabled = true;
            this.lbMateria.Location = new System.Drawing.Point(301, 85);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(253, 242);
            this.lbMateria.TabIndex = 27;
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 16;
            this.lbArea.Location = new System.Drawing.Point(37, 85);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(253, 244);
            this.lbArea.TabIndex = 26;
            // 
            // btnGuardarAM
            // 
            this.btnGuardarAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.FlatAppearance.BorderSize = 0;
            this.btnGuardarAM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAM.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardarAM.Location = new System.Drawing.Point(136, 230);
            this.btnGuardarAM.Name = "btnGuardarAM";
            this.btnGuardarAM.Size = new System.Drawing.Size(205, 67);
            this.btnGuardarAM.TabIndex = 25;
            this.btnGuardarAM.Text = "Guardar";
            this.btnGuardarAM.UseVisualStyleBackColor = false;
            this.btnGuardarAM.Click += new System.EventHandler(this.btnGuardarAM_Click);
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(249, 120);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(205, 23);
            this.txtMateria.TabIndex = 24;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(23, 120);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(205, 23);
            this.txtArea.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Area";
            // 
            // btnGuardarARMA
            // 
            this.btnGuardarARMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarARMA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.FlatAppearance.BorderSize = 0;
            this.btnGuardarARMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarARMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarARMA.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarARMA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardarARMA.Location = new System.Drawing.Point(349, 383);
            this.btnGuardarARMA.Name = "btnGuardarARMA";
            this.btnGuardarARMA.Size = new System.Drawing.Size(205, 67);
            this.btnGuardarARMA.TabIndex = 30;
            this.btnGuardarARMA.Text = "Guardar";
            this.btnGuardarARMA.UseVisualStyleBackColor = false;
            this.btnGuardarARMA.Click += new System.EventHandler(this.btnGuardarARMA_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 61);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1261, 10);
            this.materialDivider1.TabIndex = 31;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-5, 697);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1278, 111);
            this.materialDivider2.TabIndex = 32;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lbArea);
            this.panel4.Controls.Add(this.lbMateria);
            this.panel4.Controls.Add(this.btnGuardarARMA);
            this.panel4.Controls.Add(this.label6);
            this.panel4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(652, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 574);
            this.panel4.TabIndex = 45;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtArea);
            this.panel1.Controls.Add(this.txtMateria);
            this.panel1.Controls.Add(this.btnGuardarAM);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(89, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 327);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Puedes crear area o materia con los siguientes campos";
            // 
            // frmGestionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1275, 810);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionMaterias";
            this.Text = "frmGestionMaterias";
            this.Load += new System.EventHandler(this.frmGestionMaterias_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox lbMateria;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.Button btnGuardarAM;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarARMA;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}