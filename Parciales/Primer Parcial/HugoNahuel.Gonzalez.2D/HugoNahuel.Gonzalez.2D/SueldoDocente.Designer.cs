namespace HugoNahuel.Gonzalez._2D
{
    partial class SueldoDocente
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
            this.btnSueldoNoDocenteCerrar = new System.Windows.Forms.Button();
            this.listviewSueldoDocente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSueldoNoDocenteCerrar
            // 
            this.btnSueldoNoDocenteCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnSueldoNoDocenteCerrar.FlatAppearance.BorderSize = 0;
            this.btnSueldoNoDocenteCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSueldoNoDocenteCerrar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSueldoNoDocenteCerrar.ForeColor = System.Drawing.Color.White;
            this.btnSueldoNoDocenteCerrar.Location = new System.Drawing.Point(12, 450);
            this.btnSueldoNoDocenteCerrar.Name = "btnSueldoNoDocenteCerrar";
            this.btnSueldoNoDocenteCerrar.Size = new System.Drawing.Size(401, 29);
            this.btnSueldoNoDocenteCerrar.TabIndex = 57;
            this.btnSueldoNoDocenteCerrar.Text = "CERRAR";
            this.btnSueldoNoDocenteCerrar.UseVisualStyleBackColor = false;
            this.btnSueldoNoDocenteCerrar.Click += new System.EventHandler(this.BtnSueldoNoDocenteCerrar_Click);
            // 
            // listviewSueldoDocente
            // 
            this.listviewSueldoDocente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listviewSueldoDocente.HideSelection = false;
            this.listviewSueldoDocente.Location = new System.Drawing.Point(12, 45);
            this.listviewSueldoDocente.Name = "listviewSueldoDocente";
            this.listviewSueldoDocente.Size = new System.Drawing.Size(401, 399);
            this.listviewSueldoDocente.TabIndex = 58;
            this.listviewSueldoDocente.UseCompatibleStateImageBehavior = false;
            this.listviewSueldoDocente.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellido";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sueldo";
            this.columnHeader3.Width = 100;
            // 
            // SueldoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 491);
            this.Controls.Add(this.listviewSueldoDocente);
            this.Controls.Add(this.btnSueldoNoDocenteCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SueldoDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SueldoDocente";
            this.Load += new System.EventHandler(this.SueldoDocente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSueldoNoDocenteCerrar;
        private System.Windows.Forms.ListView listviewSueldoDocente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}