namespace HugoNahuel.Gonzalez._2D
{
    partial class BuscadorPorApellido
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
            this.txtBusquedaApellido = new System.Windows.Forms.TextBox();
            this.listviewBusquedaApellido = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAltaDocenteCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBusquedaApellido
            // 
            this.txtBusquedaApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtBusquedaApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaApellido.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.txtBusquedaApellido.Location = new System.Drawing.Point(12, 51);
            this.txtBusquedaApellido.Name = "txtBusquedaApellido";
            this.txtBusquedaApellido.Size = new System.Drawing.Size(148, 22);
            this.txtBusquedaApellido.TabIndex = 0;
            // 
            // listviewBusquedaApellido
            // 
            this.listviewBusquedaApellido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listviewBusquedaApellido.HideSelection = false;
            this.listviewBusquedaApellido.Location = new System.Drawing.Point(12, 93);
            this.listviewBusquedaApellido.Name = "listviewBusquedaApellido";
            this.listviewBusquedaApellido.Size = new System.Drawing.Size(298, 399);
            this.listviewBusquedaApellido.TabIndex = 2;
            this.listviewBusquedaApellido.UseCompatibleStateImageBehavior = false;
            this.listviewBusquedaApellido.View = System.Windows.Forms.View.Details;
            this.listviewBusquedaApellido.SelectedIndexChanged += new System.EventHandler(this.ListviewBusquedaApellido_SelectedIndexChanged);
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
            this.columnHeader3.Text = "Relación";
            this.columnHeader3.Width = 100;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(166, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 22);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // btnAltaDocenteCerrar
            // 
            this.btnAltaDocenteCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnAltaDocenteCerrar.FlatAppearance.BorderSize = 0;
            this.btnAltaDocenteCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaDocenteCerrar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaDocenteCerrar.ForeColor = System.Drawing.Color.White;
            this.btnAltaDocenteCerrar.Location = new System.Drawing.Point(12, 511);
            this.btnAltaDocenteCerrar.Name = "btnAltaDocenteCerrar";
            this.btnAltaDocenteCerrar.Size = new System.Drawing.Size(298, 29);
            this.btnAltaDocenteCerrar.TabIndex = 9;
            this.btnAltaDocenteCerrar.Text = "CERRAR";
            this.btnAltaDocenteCerrar.UseVisualStyleBackColor = false;
            this.btnAltaDocenteCerrar.Click += new System.EventHandler(this.BtnAltaDocenteCerrar_Click);
            // 
            // BuscadorPorApellido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 552);
            this.Controls.Add(this.btnAltaDocenteCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.listviewBusquedaApellido);
            this.Controls.Add(this.txtBusquedaApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BuscadorPorApellido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscadorPorApellido";
            this.Load += new System.EventHandler(this.BuscadorPorApellido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaApellido;
        private System.Windows.Forms.ListView listviewBusquedaApellido;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAltaDocenteCerrar;
    }
}