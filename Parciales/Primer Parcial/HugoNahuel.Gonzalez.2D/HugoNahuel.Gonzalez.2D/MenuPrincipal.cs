using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;

namespace HugoNahuel.Gonzalez._2D
{
    public partial class MenuPrincipal : Form
    {
        #region Atributtes
        private List<Alumno> listaAlumnos = new List<Alumno>();
        private List<Docente> listaDocentes = new List<Docente>();
        private List<Aula> listaAulas = new List<Aula>();
        private List<Administrativo> listaNoDocentes = new List<Administrativo>();
        #endregion

        public MenuPrincipal()
        {
            InitializeComponent();

        }

        #region Properties
        public List<Alumno> ListaAlumnos
        {
            get
            {
                return this.listaAlumnos;
            }
        }

        public List<Docente> ListaDocentes
        {
            get
            {
                return this.listaDocentes;
            }
        }

        public List<Aula> ListaAulas
        {
            get
            {
                return this.listaAulas;
            }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.FromArgb(255, 255, 255);
                }
            }            


        }

        /// <summary>
        /// Opción Alta Docente del ToolStrip
        /// </summary>
        private void AltaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDocente altaDocente = new AltaDocente();
            altaDocente.MdiParent = this.MdiParent;
            if (altaDocente.ShowDialog() == DialogResult.OK)
            {
                this.listaDocentes.Add(altaDocente.Docen);
            }
        }

        /// <summary>
        /// Opción Alta No Docente del ToolStrip
        /// </summary>
        private void AltaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaNoDocente altaNoDocente = new AltaNoDocente();
            altaNoDocente.MdiParent = this.MdiParent;
            if (altaNoDocente.ShowDialog() == DialogResult.OK)
            {
                //this.listaDocentes.Add(altaNoDocente.NoDocen);
            }
        }

        private void AltaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAlumno altaAlumno = new AltaAlumno();
            altaAlumno.MdiParent = this.MdiParent;
            if (altaAlumno.ShowDialog() == DialogResult.OK)
            {
                this.listaAlumnos.Add(altaAlumno.Alum);
            }
        }

        private void AltaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAula altaAula = new AltaAula(this.listaAulas);
            altaAula.MdiParent = this.MdiParent;
            altaAula.ListAlumnos = this.listaAlumnos;
            altaAula.ListDocentes = this.listaDocentes;
            if (altaAula.ShowDialog() == DialogResult.OK)
            {
                this.listaAulas.Add(altaAula.Aula);
            }
        }



        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// Opción del menu que llama al método de carga de datos para testeo
        /// </summary>
        private void RANDOMVALUESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTestValues();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int x;
        int a;
        private void SueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SueldoNoDocente noDocenteSueldo = new SueldoNoDocente();
            noDocenteSueldo.MdiParent = this.MdiParent;
            noDocenteSueldo.ShowDialog();
        }

       

        private void Button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Button2_MouseHover_1(object sender, EventArgs e)
        {
            x = 0;
            a = 0;
            x = btnTestValues.Width;

            for (int i = btnTestValues.Width; i < x + 100; i++)
            {
                btnTestValues.Width = i;
                a = i;
            }
        }

        private void Button2_MouseLeave_1(object sender, EventArgs e)
        {
            for (int s = a; s > x; s--)
            {
                btnTestValues.Width = s;
            }
        }

        /// <summary>
        /// Botón del menu para Alta de Docente que llama al método de la opción de archivo
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            AltaDocenteToolStripMenuItem_Click(sender,e);
        }

        /// <summary>
        /// Botón que genera un sonido
        /// </summary>
        private void BtnYapaSound_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Application.StartupPath + @"\sound.wav");
            sound.Play();
        }

        /// <summary>
        /// Cruz que cierra la aplicación
        /// </summary>
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opción del menu que llama al método de carga de datos para testeo
        /// </summary>
        private void Button2_Click(object sender, EventArgs e)
        {
            loadTestValues();
        }

        /// <summary>
        /// Método que genera la carga de datos para testear la app
        /// </summary>
        public void loadTestValues()
        {
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Matias", "Hex", 15454791, false, 402579, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Paula", "Gimenez", 12488791, true, 402580, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Mayonesa", "Oliva", 12459791, false, 402581, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Tostadita", "Crocante", 68558791, true, 402582, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Michael", "Moore", 12454561, false, 402583, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Steve", "Vai", 2245561, false, 402584, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Lucas", "Silva", 11452311, false, 402585, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Barbara", "B", 44458541, true, 402586, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Pablo", "Ruiz", 54458791, false, 402587, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Pablo", "Blanco", 87454791, false, 402588, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Castro", 13458791, false, 402589, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Lajessy", "Torres", 12238791, true, 402590, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Esteban", "Gil", 73124791, false, 402591, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Marta", "Peloloco", 12465491, true, 402592, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Matias", "Matecocido", 71368711, false, 402593, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12467791, false, 402594, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 77256791, false, 402595, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 23458791, false, 402596, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 54458791, false, 402597, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 64458791, false, 402598, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402599, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12457791, false, 402600, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12248791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));
            this.listaAlumnos.Add(new Alumno("Juan", "Suarez", 12458791, false, 402578, 15030, ETurno.Ninguno));

            this.listaDocentes.Add(new Docente("Raul", "Fafita", 30040012, false, new System.DateTime(2020,5,7,8,00,00), new System.DateTime(2020, 5, 7, 12, 00, 00), 150));
            this.listaDocentes.Add(new Docente("Miguel", "Lays", 34108900, false, new System.DateTime(2020, 5, 7, 8, 30, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), 150));
            this.listaDocentes.Add(new Docente("Laura", "Gimenez", 366050780, true, new System.DateTime(2020, 5, 7, 10, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), 150));
            this.listaDocentes.Add(new Docente("Monica", "Fix", 300409878, true, new System.DateTime(2020, 5, 7, 9, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), 150));
            this.listaDocentes.Add(new Docente("Camila", "Strogonoff", 315647800, true, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), 150));

            this.listaNoDocentes.Add(new Administrativo("Carlos", "Pelaez", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Cocina));
            this.listaNoDocentes.Add(new Administrativo("Amira", "JEJEJE", 35487898, true, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Dirección));
            this.listaNoDocentes.Add(new Administrativo("Carlos", "LOA", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Portería));
            this.listaNoDocentes.Add(new Administrativo("Pedro", "FET", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Secretaría));
            this.listaNoDocentes.Add(new Administrativo("Carlos", "FAF", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Tesorería));
            this.listaNoDocentes.Add(new Administrativo("Laura", "DEAXS", 35487898, true, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Tesorería));
            this.listaNoDocentes.Add(new Administrativo("Lorena", "QEQE", 35487898, true, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Secretaría));
            this.listaNoDocentes.Add(new Administrativo("Carlos", "PO", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Cocina));
            this.listaNoDocentes.Add(new Administrativo("Ezequiel", "Abbb", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Cocina));
            this.listaNoDocentes.Add(new Administrativo("Ricardo", "Troeirwoej", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Cocina));

            MessageBox.Show("Se generaron datos de prueba", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AltaNoDocenteToolStripMenuItem_Click(sender,e);
        }


        private void BtnMenuAltaAlumno_MouseHover(object sender, EventArgs e)
        {
            btnMenuAltaAlumno.ForeColor = Color.FromArgb(255, 255, 255);
            btnMenuAltaAlumno.BackColor = Color.FromArgb(255, 71, 87);
            btnMenuAltaAlumno.TextAlign = ContentAlignment.MiddleCenter;
            picAltaAlumno.BackColor = Color.FromArgb(255, 71, 87);

        }

        private void BtnMenuAltaAlumno_MouseLeave(object sender, EventArgs e)
        {
            btnMenuAltaAlumno.BackColor = Color.FromArgb(255, 255, 255);
            btnMenuAltaAlumno.ForeColor = Color.FromArgb(255, 71, 87);
            btnMenuAltaAlumno.TextAlign = ContentAlignment.MiddleLeft;
            picAltaAlumno.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 71, 87);
            button1.ForeColor = Color.FromArgb(255, 255, 255);
            button1.TextAlign = ContentAlignment.MiddleCenter;
            picAltaDocente.BackColor = Color.FromArgb(255, 71, 87);

            /*x = 0;
            a = 0;
            x = button1.Width;

            for (int i = button1.Width; i < x + 100; i++)
            {
                button1.Width = i;
                 a = i;
            }*/
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 255, 255);
            button1.ForeColor = Color.FromArgb(255, 71, 87);
            button1.TextAlign = ContentAlignment.MiddleLeft;
            picAltaDocente.BackColor = Color.FromArgb(255, 255, 255);
            /*for (int s = a; s > x; s--)
            {
                button1.Width = s;
            }*/
        }

        private void BtnMenuAltaNoDocente_MouseHover(object sender, EventArgs e)
        {
            btnMenuAltaNoDocente.ForeColor = Color.FromArgb(255, 255, 255);
            btnMenuAltaNoDocente.BackColor = Color.FromArgb(255, 71, 87);
            btnMenuAltaNoDocente.TextAlign = ContentAlignment.MiddleCenter;
            picAltaNoDocente.BackColor = Color.FromArgb(255, 71, 87);
        }

        private void BtnMenuAltaNoDocente_MouseLeave(object sender, EventArgs e)
        {
            btnMenuAltaNoDocente.BackColor = Color.FromArgb(255, 255, 255);
            btnMenuAltaNoDocente.ForeColor = Color.FromArgb(255, 71, 87);
            btnMenuAltaNoDocente.TextAlign = ContentAlignment.MiddleLeft;
            picAltaNoDocente.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void BtnMenuAltaAula_MouseHover(object sender, EventArgs e)
        {
            btnMenuAltaAula.BackColor = Color.FromArgb(255, 71, 87);
            btnMenuAltaAula.ForeColor = Color.FromArgb(255, 255, 255);
            btnMenuAltaAula.TextAlign = ContentAlignment.MiddleCenter;
            picAltaAula.BackColor = Color.FromArgb(255, 71, 87);
        }

        private void BtnMenuAltaAula_MouseLeave(object sender, EventArgs e)
        {
            btnMenuAltaAula.BackColor = Color.FromArgb(255, 255, 255);
            btnMenuAltaAula.ForeColor = Color.FromArgb(255, 71, 87);
            btnMenuAltaAula.TextAlign = ContentAlignment.MiddleLeft;
            picAltaAula.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnTestValues_MouseHover_1(object sender, EventArgs e)
        {
            btnTestValues.ForeColor = Color.FromArgb(255, 255, 255);
            btnTestValues.BackColor = Color.FromArgb(255, 71, 87);
        }

        private void btnTestValues_MouseLeave_1(object sender, EventArgs e)
        {
            btnTestValues.BackColor = Color.FromArgb(255, 255, 255);
            btnTestValues.ForeColor = Color.FromArgb(255, 71, 87);           
        }

        private void BtnMenuAltaAlumno_Click(object sender, EventArgs e)
        {
            AltaAlumnoToolStripMenuItem_Click(sender, e);
        }

        private void BtnMenuAltaAula_Click(object sender, EventArgs e)
        {
            AltaAulaToolStripMenuItem_Click(sender,e);
        }

        private void BtnBuscadorPorApellido_Click(object sender, EventArgs e)
        {
            BúsquedaPorApellidoToolStripMenuItem_Click(sender, e);
        }

        private void BúsquedaPorApellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscadorPorApellido searchApellido = new BuscadorPorApellido(this.listaAlumnos, this.listaDocentes);
            searchApellido.MdiParent = this.MdiParent;
            searchApellido.ShowDialog();
         
        }

        private void InformaciónPadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionPadres infoPadres = new InformacionPadres(this.listaAlumnos);
            infoPadres.MdiParent = this.MdiParent;
            infoPadres.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SueldoNoDocenteToolStripMenuItem_Click(sender, e);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SueldoDocenteToolStripMenuItem_Click(sender, e);
        }

        private void SueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SueldoDocente docenteSueldo = new SueldoDocente(this.listaDocentes);
            docenteSueldo.MdiParent = this.MdiParent;
            docenteSueldo.ShowDialog();
        }
    }
}
