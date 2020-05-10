namespace HugoNahuel.Gonzalez._2D
{
    partial class AltaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAula));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewConAula = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Profesor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listviewSinAula = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbAulaColores = new System.Windows.Forms.ComboBox();
            this.lblDocenteFemenino = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAulaDocentes = new System.Windows.Forms.ComboBox();
            this.btnAltAulaCerrar = new System.Windows.Forms.Button();
            this.btnAltAulaGuardar = new System.Windows.Forms.Button();
            this.btnCrearAula = new System.Windows.Forms.Button();
            this.grpAulasActuales = new System.Windows.Forms.GroupBox();
            this.listViewAulasActuales = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpAulasActuales.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewConAula);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 289);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos en Aula";
            // 
            // listViewConAula
            // 
            this.listViewConAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.listViewConAula.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.Profesor});
            this.listViewConAula.HideSelection = false;
            this.listViewConAula.Location = new System.Drawing.Point(6, 19);
            this.listViewConAula.Name = "listViewConAula";
            this.listViewConAula.Size = new System.Drawing.Size(365, 263);
            this.listViewConAula.TabIndex = 1;
            this.listViewConAula.UseCompatibleStateImageBehavior = false;
            this.listViewConAula.View = System.Windows.Forms.View.Details;
            this.listViewConAula.SelectedIndexChanged += new System.EventHandler(this.ListViewConAula_SelectedIndexChanged);
            this.listViewConAula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewConAula_MouseClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Apellido";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nombre";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Legajo";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Sala";
            this.columnHeader8.Width = 57;
            // 
            // Profesor
            // 
            this.Profesor.Text = "Profesor";
            this.Profesor.Width = 76;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listviewSinAula);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.groupBox2.Location = new System.Drawing.Point(392, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 449);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alumnos sin Aula";
            // 
            // listviewSinAula
            // 
            this.listviewSinAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.listviewSinAula.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listviewSinAula.HideSelection = false;
            this.listviewSinAula.Location = new System.Drawing.Point(6, 19);
            this.listviewSinAula.Name = "listviewSinAula";
            this.listviewSinAula.Size = new System.Drawing.Size(387, 423);
            this.listviewSinAula.TabIndex = 0;
            this.listviewSinAula.UseCompatibleStateImageBehavior = false;
            this.listviewSinAula.View = System.Windows.Forms.View.Details;
            this.listviewSinAula.SelectedIndexChanged += new System.EventHandler(this.ListviewSinAula_SelectedIndexChanged);
            this.listviewSinAula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListviewSinAula_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellido";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Legajo";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Responsable";
            this.columnHeader4.Width = 90;
            // 
            // cmbAulaColores
            // 
            this.cmbAulaColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAulaColores.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAulaColores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.cmbAulaColores.FormattingEnabled = true;
            this.cmbAulaColores.Location = new System.Drawing.Point(81, 40);
            this.cmbAulaColores.Name = "cmbAulaColores";
            this.cmbAulaColores.Size = new System.Drawing.Size(159, 27);
            this.cmbAulaColores.TabIndex = 30;
            this.cmbAulaColores.SelectedIndexChanged += new System.EventHandler(this.cmbAulaColores_SelectedIndexChanged);
            // 
            // lblDocenteFemenino
            // 
            this.lblDocenteFemenino.AutoSize = true;
            this.lblDocenteFemenino.BackColor = System.Drawing.Color.Transparent;
            this.lblDocenteFemenino.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocenteFemenino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.lblDocenteFemenino.Location = new System.Drawing.Point(30, 44);
            this.lblDocenteFemenino.Name = "lblDocenteFemenino";
            this.lblDocenteFemenino.Size = new System.Drawing.Size(45, 17);
            this.lblDocenteFemenino.TabIndex = 31;
            this.lblDocenteFemenino.Text = "Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(284, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Turno:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTurnos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(339, 40);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(159, 27);
            this.cmbTurnos.TabIndex = 32;
            this.cmbTurnos.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 56;
            // 
            // cmbAulaDocentes
            // 
            this.cmbAulaDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAulaDocentes.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAulaDocentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.cmbAulaDocentes.FormattingEnabled = true;
            this.cmbAulaDocentes.Location = new System.Drawing.Point(607, 40);
            this.cmbAulaDocentes.Name = "cmbAulaDocentes";
            this.cmbAulaDocentes.Size = new System.Drawing.Size(159, 27);
            this.cmbAulaDocentes.TabIndex = 34;
            this.cmbAulaDocentes.SelectedIndexChanged += new System.EventHandler(this.CmbAulaDocentes_SelectedIndexChanged);
            // 
            // btnAltAulaCerrar
            // 
            this.btnAltAulaCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnAltAulaCerrar.FlatAppearance.BorderSize = 0;
            this.btnAltAulaCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltAulaCerrar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltAulaCerrar.ForeColor = System.Drawing.Color.White;
            this.btnAltAulaCerrar.Location = new System.Drawing.Point(604, 527);
            this.btnAltAulaCerrar.Name = "btnAltAulaCerrar";
            this.btnAltAulaCerrar.Size = new System.Drawing.Size(187, 39);
            this.btnAltAulaCerrar.TabIndex = 54;
            this.btnAltAulaCerrar.Text = "CERRAR";
            this.btnAltAulaCerrar.UseVisualStyleBackColor = false;
            this.btnAltAulaCerrar.Click += new System.EventHandler(this.btnAltAulaCerrar_Click);
            // 
            // btnAltAulaGuardar
            // 
            this.btnAltAulaGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnAltAulaGuardar.FlatAppearance.BorderSize = 0;
            this.btnAltAulaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltAulaGuardar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltAulaGuardar.ForeColor = System.Drawing.Color.White;
            this.btnAltAulaGuardar.Location = new System.Drawing.Point(392, 527);
            this.btnAltAulaGuardar.Name = "btnAltAulaGuardar";
            this.btnAltAulaGuardar.Size = new System.Drawing.Size(206, 39);
            this.btnAltAulaGuardar.TabIndex = 53;
            this.btnAltAulaGuardar.Text = "GUARDAR";
            this.btnAltAulaGuardar.UseVisualStyleBackColor = false;
            this.btnAltAulaGuardar.Click += new System.EventHandler(this.BtnAltAulaGuardar_Click);
            // 
            // btnCrearAula
            // 
            this.btnCrearAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnCrearAula.FlatAppearance.BorderSize = 0;
            this.btnCrearAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearAula.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAula.ForeColor = System.Drawing.Color.White;
            this.btnCrearAula.Location = new System.Drawing.Point(9, 528);
            this.btnCrearAula.Name = "btnCrearAula";
            this.btnCrearAula.Size = new System.Drawing.Size(377, 39);
            this.btnCrearAula.TabIndex = 55;
            this.btnCrearAula.Text = "CREAR AULA";
            this.btnCrearAula.UseVisualStyleBackColor = false;
            this.btnCrearAula.Click += new System.EventHandler(this.BtnCrearAula_Click);
            // 
            // grpAulasActuales
            // 
            this.grpAulasActuales.Controls.Add(this.listViewAulasActuales);
            this.grpAulasActuales.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAulasActuales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.grpAulasActuales.Location = new System.Drawing.Point(12, 73);
            this.grpAulasActuales.Name = "grpAulasActuales";
            this.grpAulasActuales.Size = new System.Drawing.Size(374, 154);
            this.grpAulasActuales.TabIndex = 29;
            this.grpAulasActuales.TabStop = false;
            this.grpAulasActuales.Text = "Aulas Actuales";
            // 
            // listViewAulasActuales
            // 
            this.listViewAulasActuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.listViewAulasActuales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewAulasActuales.HideSelection = false;
            this.listViewAulasActuales.Location = new System.Drawing.Point(6, 15);
            this.listViewAulasActuales.Name = "listViewAulasActuales";
            this.listViewAulasActuales.Size = new System.Drawing.Size(362, 133);
            this.listViewAulasActuales.TabIndex = 1;
            this.listViewAulasActuales.UseCompatibleStateImageBehavior = false;
            this.listViewAulasActuales.View = System.Windows.Forms.View.Details;
            this.listViewAulasActuales.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Color";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Turno";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Profesor";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Alumnos";
            this.columnHeader12.Width = 80;
            // 
            // AltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.grpAulasActuales);
            this.Controls.Add(this.btnCrearAula);
            this.Controls.Add(this.btnAltAulaCerrar);
            this.Controls.Add(this.btnAltAulaGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAulaDocentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTurnos);
            this.Controls.Add(this.lblDocenteFemenino);
            this.Controls.Add(this.cmbAulaColores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignación de Aula";
            this.Load += new System.EventHandler(this.AltaAula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpAulasActuales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listviewSinAula;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewConAula;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cmbAulaColores;
        private System.Windows.Forms.Label lblDocenteFemenino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAulaDocentes;
        private System.Windows.Forms.Button btnAltAulaCerrar;
        private System.Windows.Forms.Button btnAltAulaGuardar;
        private System.Windows.Forms.Button btnCrearAula;
        private System.Windows.Forms.ColumnHeader Profesor;
        private System.Windows.Forms.GroupBox grpAulasActuales;
        private System.Windows.Forms.ListView listViewAulasActuales;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}