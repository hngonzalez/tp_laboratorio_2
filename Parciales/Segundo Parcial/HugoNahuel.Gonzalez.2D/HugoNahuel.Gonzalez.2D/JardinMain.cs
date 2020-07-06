using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace HugoNahuel.Gonzalez._2D
{    
    public delegate void Atender(object o);
    public delegate void CargarAlumno(Alumno alumno, List<Docente> docentes, List<Aula> aulas);

    public partial class JardinMain : Form
    {
        private Queue<Alumno> alumnosCola;
        private List<Aula> aulasLista;
        private List<Docente> docentesLista;

        private Thread hiloLecturaXML;
        private Thread hiloEvaluarAlumno;
        public event CargarAlumno EvaluoAlumno;

        #region Constructors
        /// <summary>
        /// Constructor de la clase, instancia listas y obtiene datos de la db
        /// </summary>
        public JardinMain()
        {
            InitializeComponent();
            alumnosCola = new Queue<Alumno>();
            alumnosCola = DataSQL.LeerAlumnosSQL();
            aulasLista = DataSQL.LeerAulasSQL();
            docentesLista = new List<Docente>();
            //docentesLista = DataSQL.LeerDocentesSQL();
            LlenarCola(alumnosCola);
        }
        #endregion

        /// <summary>
        /// Load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Evaluando frmEvaluando = new Evaluando();
            this.EvaluoAlumno += frmEvaluando.mostrarMensajePrincipal;
            frmEvaluando.Show();
            /*hiloLecturaXML = new Thread(DataFiles.LeerDocentesXML);
            hiloLecturaXML.Start();*/   
        }

        /// <summary>
        /// Método del botón evaluar, creará un hilo para realizar la evaluación del alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            hiloEvaluarAlumno = new Thread(new ParameterizedThreadStart(proxAlumno));

            if (!hiloEvaluarAlumno.IsAlive)
            {
                hiloEvaluarAlumno = new Thread(new ParameterizedThreadStart(proxAlumno));
                hiloEvaluarAlumno.Start(aulasLista);
            }
        }

        private void proxAlumno(object aulaLista)
        {
            if (alumnosCola.Count > 0)
            { 
                Atender(alumnosCola.Dequeue(), (List<Docente>) docentesLista, (List<Aula>) aulaLista);
            }
        }

        private void Atender(Alumno alumno, List<Docente> docentesLista, List<Aula> aulaLista)
        {
            EvaluoAlumno.Invoke(alumno, docentesLista, aulaLista);
        }

        private void mostrarMensajePrincipal(string palabra)
        {

        }

        /// <summary>
        /// Método que carga alumnos en el listbox
        /// </summary>
        /// <param name="alumnosCola">Elementos a cargar</param>
        private void LlenarCola(Queue<Alumno> alumnosCola)
        {
            foreach (Alumno alumno in alumnosCola)
            {
                lstbAlumnos.Items.Add(alumno.Apellido + ", " + alumno.Nombre);
            }
        }
    }
}
