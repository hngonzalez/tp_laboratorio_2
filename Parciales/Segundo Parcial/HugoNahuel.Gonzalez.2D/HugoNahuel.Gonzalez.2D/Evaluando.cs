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
        private Random random;
        private Evaluaciones eval;
        public Evaluando()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Evaluando_Load(object sender, EventArgs e)
        {

        }

        public void mostrarMensajePrincipal(Alumno alumno, List<Docente> docentesLista, List<Aula> aulaLista)
        {
            if (txtEvaluando.InvokeRequired)
            {
                txtEvaluando.BeginInvoke((MethodInvoker)delegate
                {
                    txtEvaluando.Text = alumno.Apellido;
                });
            }
            else
            {
                txtEvaluando.Text = alumno.Apellido;
            }

            int index = random.Next(aulaLista.Count);

            //eval.Evaluar(alumno, aulaLista[index].IdAula);

        }
    }
}
