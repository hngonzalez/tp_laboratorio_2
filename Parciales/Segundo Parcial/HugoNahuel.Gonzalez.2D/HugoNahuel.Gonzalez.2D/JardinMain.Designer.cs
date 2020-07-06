namespace HugoNahuel.Gonzalez._2D
{
    partial class JardinMain
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
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.gbAlumnos = new System.Windows.Forms.GroupBox();
            this.lstbAlumnos = new System.Windows.Forms.ListBox();
            this.gbAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(12, 12);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(212, 55);
            this.btnEvaluar.TabIndex = 0;
            this.btnEvaluar.Text = "Evaluar Alumnos";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // gbAlumnos
            // 
            this.gbAlumnos.Controls.Add(this.lstbAlumnos);
            this.gbAlumnos.Location = new System.Drawing.Point(378, 101);
            this.gbAlumnos.Name = "gbAlumnos";
            this.gbAlumnos.Size = new System.Drawing.Size(194, 329);
            this.gbAlumnos.TabIndex = 1;
            this.gbAlumnos.TabStop = false;
            this.gbAlumnos.Text = "Alumnos";
            // 
            // lstbAlumnos
            // 
            this.lstbAlumnos.FormattingEnabled = true;
            this.lstbAlumnos.Location = new System.Drawing.Point(6, 19);
            this.lstbAlumnos.Name = "lstbAlumnos";
            this.lstbAlumnos.Size = new System.Drawing.Size(182, 303);
            this.lstbAlumnos.TabIndex = 0;
            // 
            // JardinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.gbAlumnos);
            this.Controls.Add(this.btnEvaluar);
            this.Name = "JardinMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAlumnos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.GroupBox gbAlumnos;
        private System.Windows.Forms.ListBox lstbAlumnos;
    }
}

