namespace HugoNahuel.Gonzalez._2D
{
    partial class InformacionPadres
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
            this.btnAltaDocenteCerrar = new System.Windows.Forms.Button();
            this.listviewInfoPadres = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAltaDocenteCerrar
            // 
            this.btnAltaDocenteCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnAltaDocenteCerrar.FlatAppearance.BorderSize = 0;
            this.btnAltaDocenteCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaDocenteCerrar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaDocenteCerrar.ForeColor = System.Drawing.Color.White;
            this.btnAltaDocenteCerrar.Location = new System.Drawing.Point(12, 430);
            this.btnAltaDocenteCerrar.Name = "btnAltaDocenteCerrar";
            this.btnAltaDocenteCerrar.Size = new System.Drawing.Size(434, 29);
            this.btnAltaDocenteCerrar.TabIndex = 11;
            this.btnAltaDocenteCerrar.Text = "CERRAR";
            this.btnAltaDocenteCerrar.UseVisualStyleBackColor = false;
            // 
            // listviewInfoPadres
            // 
            this.listviewInfoPadres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.Telefono});
            this.listviewInfoPadres.HideSelection = false;
            this.listviewInfoPadres.Location = new System.Drawing.Point(12, 12);
            this.listviewInfoPadres.Name = "listviewInfoPadres";
            this.listviewInfoPadres.Size = new System.Drawing.Size(434, 399);
            this.listviewInfoPadres.TabIndex = 10;
            this.listviewInfoPadres.UseCompatibleStateImageBehavior = false;
            this.listviewInfoPadres.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Relación";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido Alum";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre Alum";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sala Color";
            this.columnHeader4.Width = 80;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            this.Telefono.Width = 80;
            // 
            // InformacionPadres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 474);
            this.Controls.Add(this.btnAltaDocenteCerrar);
            this.Controls.Add(this.listviewInfoPadres);
            this.Name = "InformacionPadres";
            this.Text = "InformacionPadres";
            this.Load += new System.EventHandler(this.InformacionPadres_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaDocenteCerrar;
        private System.Windows.Forms.ListView listviewInfoPadres;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Telefono;
    }
}