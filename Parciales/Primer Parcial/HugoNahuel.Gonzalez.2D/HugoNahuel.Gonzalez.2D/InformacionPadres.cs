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
    public partial class InformacionPadres : Form
    {
        #region Atributtes
        private List<Alumno> listaAlumnos;
        #endregion

        #region Constructors
        public InformacionPadres()
        {
            InitializeComponent();
        }
        public InformacionPadres(List<Alumno> listaAlumnos)
        {
            this.listaAlumnos = listaAlumnos;
        }
        #endregion


        private void InformacionPadres_Load(object sender, EventArgs e)
        {
            foreach (Alumno alumno in this.listaAlumnos)
            {
                ListViewItem listViewItem = new ListViewItem(alumno.ColorSala.ToString());
                listViewItem.SubItems.Add(alumno.Responsable.Parentesco.ToString());
                listViewItem.SubItems.Add(alumno.Apellido);
                listViewItem.SubItems.Add(alumno.Nombre);
                listViewItem.SubItems.Add(alumno.Responsable.Telefono);
                listviewInfoPadres.Items.Add(listViewItem);
            }
        }
    }
}
