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
            this.components = new System.ComponentModel.Container();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.gbAlumnos = new System.Windows.Forms.GroupBox();
            this.lstbAlumnos = new System.Windows.Forms.ListBox();
            this.tmrEvaluando = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTiempoEvaluando = new System.Windows.Forms.Label();
            this.lblRecreo = new System.Windows.Forms.Label();
            this.gbAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.BackColor = System.Drawing.Color.Wheat;
            this.btnEvaluar.FlatAppearance.BorderSize = 0;
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluar.Location = new System.Drawing.Point(12, 31);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(212, 55);
            this.btnEvaluar.TabIndex = 0;
            this.btnEvaluar.Text = "Evaluar Alumnos";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // gbAlumnos
            // 
            this.gbAlumnos.Controls.Add(this.lstbAlumnos);
            this.gbAlumnos.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlumnos.Location = new System.Drawing.Point(230, 12);
            this.gbAlumnos.Name = "gbAlumnos";
            this.gbAlumnos.Size = new System.Drawing.Size(194, 418);
            this.gbAlumnos.TabIndex = 1;
            this.gbAlumnos.TabStop = false;
            this.gbAlumnos.Text = "Alumnos";
            // 
            // lstbAlumnos
            // 
            this.lstbAlumnos.FormattingEnabled = true;
            this.lstbAlumnos.ItemHeight = 14;
            this.lstbAlumnos.Location = new System.Drawing.Point(6, 14);
            this.lstbAlumnos.Name = "lstbAlumnos";
            this.lstbAlumnos.Size = new System.Drawing.Size(182, 396);
            this.lstbAlumnos.TabIndex = 0;
            // 
            // tmrEvaluando
            // 
            this.tmrEvaluando.Interval = 1000;
            this.tmrEvaluando.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(168, 399);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(13, 14);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "0";
            this.lblTimer.Click += new System.EventHandler(this.LblTimer_Click);
            // 
            // lblTiempoEvaluando
            // 
            this.lblTiempoEvaluando.AutoSize = true;
            this.lblTiempoEvaluando.Location = new System.Drawing.Point(35, 399);
            this.lblTiempoEvaluando.Name = "lblTiempoEvaluando";
            this.lblTiempoEvaluando.Size = new System.Drawing.Size(98, 13);
            this.lblTiempoEvaluando.TabIndex = 3;
            this.lblTiempoEvaluando.Text = "Tiempo evaluando:";
            // 
            // lblRecreo
            // 
            this.lblRecreo.AutoSize = true;
            this.lblRecreo.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecreo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRecreo.Location = new System.Drawing.Point(71, 161);
            this.lblRecreo.Name = "lblRecreo";
            this.lblRecreo.Size = new System.Drawing.Size(0, 25);
            this.lblRecreo.TabIndex = 4;
            // 
            // JardinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(435, 442);
            this.Controls.Add(this.lblRecreo);
            this.Controls.Add(this.lblTiempoEvaluando);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.gbAlumnos);
            this.Controls.Add(this.btnEvaluar);
            this.Name = "JardinMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo Nahuel González 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAlumnos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.GroupBox gbAlumnos;
        private System.Windows.Forms.ListBox lstbAlumnos;
        private System.Windows.Forms.Timer tmrEvaluando;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTiempoEvaluando;
        private System.Windows.Forms.Label lblRecreo;
    }
}

