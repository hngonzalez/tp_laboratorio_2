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
    public partial class Evaluando : Form
    {
        #region Atributtes
        private Random random;
        private Evaluaciones eval;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Evaluando()
        {
            InitializeComponent();
            random = new Random();
            eval = new Evaluaciones();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método load de la clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Evaluando_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="docentesLista"></param>
        /// <param name="aulaLista"></param>
        public void mostrarAlumno(Alumno alumno, List<Docente> docentesLista, List<Aula> aulaLista)
        {
            float auxNotaFinal = 0;

            if (txtEvaluando.InvokeRequired)
            {
                txtEvaluando.BeginInvoke((MethodInvoker)delegate
                {
                    txtEvaluando.Text = alumno.Apellido + " " + alumno.Nombre;
                });
            }
            else
            {
                txtEvaluando.Text = alumno.Apellido;
            }

            int indexAula = random.Next(aulaLista.Count);
            int indexDocente = random.Next(docentesLista.Count);

            auxNotaFinal = eval.Evaluar(alumno, docentesLista[indexDocente], aulaLista[indexAula]); 
            if (txtNotaFinal.InvokeRequired)
            {
                txtNotaFinal.BeginInvoke((MethodInvoker)delegate
                {
                    txtNotaFinal.Text = auxNotaFinal.ToString();
                });
            }
            else
            {
                txtNotaFinal.Text = auxNotaFinal.ToString();
            }

            Thread.Sleep(1500);

            if (txtNotaFinal.InvokeRequired)
            {
                txtNotaFinal.BeginInvoke((MethodInvoker)delegate
                {
                    txtNotaFinal.Text = "";
                });
            }
            else
            {
                txtNotaFinal.Text = "";
            }
            
        }
        #endregion
    }
}
