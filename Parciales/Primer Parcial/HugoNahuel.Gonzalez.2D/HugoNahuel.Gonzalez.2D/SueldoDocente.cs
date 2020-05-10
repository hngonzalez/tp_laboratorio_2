using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace HugoNahuel.Gonzalez._2D
{
    public partial class SueldoDocente : Form
    {
        private List<Docente> listaDocentes;
        public SueldoDocente()
        {
            InitializeComponent();
        }

        public SueldoDocente(List<Docente> listaDocentes) 
            : this()
        {
            this.listaDocentes = listaDocentes;
        }

        private void SueldoDocente_Load(object sender, EventArgs e)
        {
            foreach (Docente docente in this.listaDocentes)
            {
                ListViewItem listViewItem = new ListViewItem(docente.Apellido);
                listViewItem.SubItems.Add(docente.Nombre);
                listViewItem.SubItems.Add(docente.HorasMensuales.ToString());
                listviewSueldoDocente.Items.Add(listViewItem);
            }
        }

        private void BtnSueldoNoDocenteCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
