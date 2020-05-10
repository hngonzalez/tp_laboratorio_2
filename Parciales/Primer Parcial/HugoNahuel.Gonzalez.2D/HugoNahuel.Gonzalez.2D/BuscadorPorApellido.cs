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
    public partial class BuscadorPorApellido : Form
    {
        private List<Alumno> listaAlumnos;
        private List<Docente> listaDocentes;
        public BuscadorPorApellido()
        {
            InitializeComponent();
        }

        public BuscadorPorApellido(List<Alumno> listAlumnos, List<Docente> listDocente) : this()
        {
            this.listaAlumnos = listAlumnos;
            this.listaDocentes = listDocente;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            bool hayDocente = false;
            bool hayAlumno = false;
            listviewBusquedaApellido.Items.Clear();

            foreach (Docente docen in this.listaDocentes)
            {
                if (txtBusquedaApellido.Text == docen.Apellido)
                {
                    ListViewItem listViewItem = new ListViewItem(docen.Apellido);
                    listViewItem.SubItems.Add(docen.Nombre);
                    listViewItem.SubItems.Add("Docente");
                    listviewBusquedaApellido.Items.Add(listViewItem);
                    hayDocente = true;
                }
            }

            foreach (Alumno alum in this.listaAlumnos)
            {
                if (txtBusquedaApellido.Text == alum.Apellido)
                {
                    ListViewItem listViewItem = new ListViewItem(alum.Apellido);
                    listViewItem.SubItems.Add(alum.Nombre);
                    listViewItem.SubItems.Add("Alumno");
                    listviewBusquedaApellido.Items.Add(listViewItem);
                    hayAlumno = true;
                }
            }
            if (hayDocente == false && hayAlumno == false)
            {
                MessageBox.Show("No hay resultados para ese Apellido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAltaDocenteCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscadorPorApellido_Load(object sender, EventArgs e)
        {

        }

        private void ListviewBusquedaApellido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
