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
    #region Delegates
    public delegate void Atender(object o);
    public delegate void CargarAlumno(Alumno alumno, List<Docente> docentes, List<Aula> aulas);
    #endregion

    public partial class JardinMain : Form
    {
        #region Atributtes
        private Queue<Alumno> alumnosCola;
        private List<Aula> aulasLista;
        private List<Docente> docentesLista;
        private Thread hiloLecturaXML;
        private Thread hiloEvaluarAlumno;
        private Thread hiloRecreo;
        public event CargarAlumno EvaluoAlumno;
        int segs = 0;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la clase, instancia listas y obtiene datos de la db
        /// </summary>
        public JardinMain()
        {
            InitializeComponent();
            alumnosCola = new Queue<Alumno>();
            alumnosCola = DataSQL.LeerAlumnosSQL();
            aulasLista = new List<Aula>();
            aulasLista = DataSQL.LeerAulasSQL();
            docentesLista = new List<Docente>();
            DataFiles.LeerDocentesXML();
            LlenarCola(alumnosCola);
            /*docentesLista.Add(new Docente("Alfredo", "ibanez", 45, 20000, "asdasdasd", 2, "masculino", "a@a.com"));
            docentesLista.Add(new Docente("B", "ibanez", 45, 20001, "asdasdasd", 3, "masculino", "a@a.com"));
            docentesLista.Add(new Docente("C", "dada", 45, 20002, "asdasdasd", 4, "masculino", "a@a.com"));
            docentesLista.Add(new Docente("D", "ibansdsdez", 45, 20003, "asdasdasd", 5, "masculino", "a@a.com"));
            docentesLista.Add(new Docente("F", "ibanerweez", 45, 20004, "asdasdasd", 6, "masculino", "a@a.com"));*/
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
            this.EvaluoAlumno += frmEvaluando.mostrarAlumno;
            docentesLista = DataSQL.LeerDocentesSQL();
            frmEvaluando.Top = this.Top;
            frmEvaluando.Show();
        }

        /// <summary>
        /// Método del botón evaluar, creará un hilo para realizar la evaluación del alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            tmrEvaluando.Enabled = true;
            hiloEvaluarAlumno = new Thread(new ParameterizedThreadStart(proxAlumno));
            hiloRecreo = new Thread(new ParameterizedThreadStart(MensajeRecreo));

            if (!hiloEvaluarAlumno.IsAlive)
            {
                hiloEvaluarAlumno.Start(aulasLista);
                hiloRecreo.Start(lblRecreo);
            }
        }

        /// <summary>
        /// Método que llama a próximo alumno y actualiza la lista del primer hilo
        /// </summary>
        /// <param name="aulaLista"></param>
        private void proxAlumno(object aulaLista)
        {
            while (alumnosCola.Count > 0)
            {   
                Atender(alumnosCola.Dequeue(), (List<Docente>)docentesLista, (List<Aula>)aulaLista);
                if (lstbAlumnos.InvokeRequired)
                {
                    lstbAlumnos.BeginInvoke((MethodInvoker)delegate
                    {
                        lstbAlumnos.Items.Clear();
                        LlenarCola(alumnosCola);
                    });
                }
                else
                {
                    lstbAlumnos.Items.Clear();
                    LlenarCola(alumnosCola);
                }
            }
            tmrEvaluando.Enabled = false;
            MessageBox.Show("La evaluación de los alumnos duró: " + lblTimer.Text + " segundos");
            hiloEvaluarAlumno.Abort();
        }

        /// <summary>
        /// Método para el hilo de mostrar mensaje
        /// </summary>
        /// <param name="aulaLista"></param>
        private void MensajeRecreo(object o)
        {
            Label recreoMsg = (Label)o;

            while (true)
            {
                Thread.Sleep(20000);
                hiloEvaluarAlumno.Suspend();
                if (recreoMsg.InvokeRequired)
                {
                    recreoMsg.BeginInvoke((MethodInvoker)delegate
                    {
                        recreoMsg.Text = "RECREO";

                    });
                }
                Thread.Sleep(5000);
                hiloEvaluarAlumno.Resume();
                if (recreoMsg.InvokeRequired)
                {
                    recreoMsg.BeginInvoke((MethodInvoker)delegate
                    {
                        recreoMsg.Text = "";
                    });
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="docentesLista"></param>
        /// <param name="aulaLista"></param>
        private void Atender(Alumno alumno, List<Docente> docentesLista, List<Aula> aulaLista)
        {
            if (EvaluoAlumno.GetInvocationList().Count() > 0){
                EvaluoAlumno.Invoke(alumno, docentesLista, aulaLista);
            }            
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            segs++;
            lblTimer.Text = segs.ToString();
        }

        private void LblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
