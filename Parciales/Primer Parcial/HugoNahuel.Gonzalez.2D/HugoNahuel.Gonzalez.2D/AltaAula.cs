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
using System.Media;

namespace HugoNahuel.Gonzalez._2D
{
    public partial class AltaAula : Form
    {
        #region Atributtes
        private Aula aula;
        private List<Aula> listAulas;
        private List<Alumno> listAlumnos;
        private List<Docente> listDocentes;
        static int legajo;
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor de AltaAula
        /// </summary>
        public AltaAula()
        {
            InitializeComponent();

            cmbAulaColores.DataSource = Enum.GetValues(typeof(EColores));
            cmbTurnos.DataSource = Enum.GetValues(typeof(ETurno));
        }

        /// <summary>
        /// Overload del constructor para poder recibir la lista de aulas
        /// </summary>
        /// <param name="listaAulas"> Lista de aulas que necesito leer para validar
        public AltaAula(List<Aula> listaAulas) : this()
        {
            this.listAulas = listaAulas;
        }
        #endregion

        
        #region Properties
        /// <summary>
        /// Propiedad de la lista de alumnos
        /// </summary>
        public List<Alumno> ListAlumnos
        {
            get
            {
                return this.listAlumnos;
            }
            set
            {
                this.listAlumnos = value;
            }
        }

        /// <summary>
        /// Propiedad de la lista de docentes
        /// </summary>
        public List<Docente> ListDocentes
        {
            get
            {
                return this.listDocentes;
            }
            set
            {
                this.listDocentes = value;
            }
        }

        /// <summary>
        /// Propiedad de aula
        /// </summary>
        public Aula Aula
        {
            get
            {
                return this.aula;
            }
        }

        /// <summary>
        /// Propiedad de la lista de aulas
        /// </summary>
        public List<Aula> ListAulas
        {
            get
            {
                return this.listAulas;
            }
        }
        #endregion


        /// <summary>
        /// Método load que se inica luego de inicializar los componentes, en este caso me ayuda bloquear botones y cargar el listado de alumnos sin aula.
        /// </summary>
        private void AltaAula_Load(object sender, EventArgs e)
        {
            int cantAlumNinguno = 0;
            int cantAlumNaranja = 0;
            int cantAlumRojo = 0;
            int cantAlumVerde = 0;
            int cantAlumAmarillo = 0;
            listviewSinAula.View = View.Details; 
            listviewSinAula.FullRowSelect = true;
            cmbAulaDocentes.Enabled = false;
            cmbTurnos.Enabled = false;
            btnCrearAula.Enabled = false;
            btnCrearAula.BackColor = Color.FromArgb(164, 176, 190);

            foreach (Alumno alum in this.listAlumnos) //---> Listo alumnos que no tengan sala asignada
            {
                if (alum.ColorSala == EColores.Ninguno)
                {
                    ListViewItem listViewItem = new ListViewItem(alum.Apellido);
                    listViewItem.SubItems.Add(alum.Nombre);
                    listViewItem.SubItems.Add(Validaciones.ValidateIntToString(alum.Legajo));
                    listviewSinAula.Items.Add(listViewItem);
                }   
            }

            foreach (Alumno alum in this.listAlumnos) //---> Cuento la cantidad de alumnos en las aulas para utilizarlo luego y ver si la sala no está llena
            {
                switch (alum.ColorSala)
                {
                    case EColores.Ninguno:
                        cantAlumNinguno++;
                        break;
                    case EColores.Naranja:
                        cantAlumNaranja++;
                        break;
                    case EColores.Rojo:
                        cantAlumRojo++;
                        break;
                    case EColores.Amarillo:
                        cantAlumAmarillo++;
                        break;
                    case EColores.Verde:
                        cantAlumVerde++;
                        break;
                    default:
                        break;
                }
            }

                foreach (Aula aula in this.listAulas)
            {
                ListViewItem listViewItem = new ListViewItem(aula.ColorSala.ToString());
                listViewItem.SubItems.Add(aula.Turno.ToString());
                listViewItem.SubItems.Add(aula.Docente.ToString());
                switch (aula.ColorSala)
                {
                    case EColores.Ninguno:
                        listViewItem.SubItems.Add(cantAlumNinguno.ToString());
                        break;
                    case EColores.Naranja:
                        listViewItem.SubItems.Add(cantAlumNaranja.ToString());
                        break;
                    case EColores.Rojo:
                        listViewItem.SubItems.Add(cantAlumRojo.ToString());
                        break;
                    case EColores.Amarillo:
                        cantAlumAmarillo++;
                        listViewItem.SubItems.Add(cantAlumAmarillo.ToString());
                        break;
                    case EColores.Verde:
                        listViewItem.SubItems.Add(cantAlumVerde.ToString());
                        break;
                    default:
                        break;
                }
                listViewAulasActuales.Items.Add(listViewItem);
            }
        }

        private void RtxtAlumnosSinAula_TextChanged(object sender, EventArgs e)
        {
        }

        private void ListviewSinAula_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Cambia el fondo de la ventana dependiendo el item que seleccioné en el combo de colores
        /// Desbloquea y bloquea el botón de creado de sala si no tengo un color seleccionado
        /// </summary>
        private void cmbAulaColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurnos.Enabled = true;
            listViewConAula.Items.Clear();

            if ((EColores)cmbAulaColores.SelectedItem != EColores.Ninguno)
            {
                btnCrearAula.Enabled = true;
                btnCrearAula.BackColor = Color.FromArgb(255, 71, 87);
                ComboBox1_SelectedIndexChanged(sender, e);
            }
            else
            {
                btnCrearAula.Enabled = false;
                btnCrearAula.BackColor = Color.FromArgb(164, 176, 190);
            }

            switch (cmbAulaColores.SelectedItem)
            {
                case EColores.Verde:
                    this.BackColor = Color.FromArgb(46, 213, 115);
                    break;
                case EColores.Naranja:
                    this.BackColor = Color.FromArgb(255, 127, 80);
                    break;
                case EColores.Rojo:
                    this.BackColor = Color.FromArgb(214, 48, 49);
                    break;
                case EColores.Amarillo:
                    this.BackColor = Color.FromArgb(255, 165, 2);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Cierra el form actual
        /// </summary>
        private void btnAltAulaCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Botón para guardar Alumno en la clase
        /// </summary>
        private void BtnAltAulaGuardar_Click(object sender, EventArgs e)
        {
            int cantAlumNinguno = 0;
            int cantAlumNaranja = 0;
            int cantAlumRojo = 0;
            int cantAlumVerde = 0;
            int cantAlumAmarillo = 0;
            bool existeAulaIndicada = false;

            // Si la lista de aulas está en 0, muestro mensaje de aviso y, si no, verifico que
            // exista el aula que seleccioné en el combo de colores. Si existe, lo cargo, si no, 
            // muestro mensaje de aviso de que no existe el aula.
            if (this.ListAulas.Count() == 0)
            {
                MessageBox.Show("No existen aulas al momento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                foreach (Alumno alum in this.listAlumnos) //---> Cuento la cantidad de alumnos en las aulas para utilizarlo luego y ver si la sala no está llena
                {
                    switch (alum.ColorSala)
                    {
                        case EColores.Ninguno:
                            cantAlumNinguno++;
                            break;
                        case EColores.Naranja:
                            cantAlumNaranja++;
                            break;
                        case EColores.Rojo:
                            cantAlumRojo++;
                            break;
                        case EColores.Amarillo:
                            cantAlumAmarillo++;
                            break;
                        case EColores.Verde:
                            cantAlumVerde++;
                            break;
                        default:
                            break;
                    }
                }

                foreach (Aula aula in this.ListAulas)
                {
                    if (aula.ColorSala == (EColores)cmbAulaColores.SelectedItem && aula.Turno == (ETurno)cmbTurnos.SelectedItem)
                    {
                        existeAulaIndicada = true;
                    }
                }
                if (existeAulaIndicada == false)
                {
                    MessageBox.Show("No existe el aula seleccionada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else {
                    foreach (Alumno alum in this.listAlumnos)
                    {
                        if (alum.Legajo == legajo)
                        {
                            switch ((EColores)cmbAulaColores.SelectedItem)
                            {
                                case EColores.Ninguno:
                                    break;
                                case EColores.Naranja:
                                    if (cantAlumNaranja <= 30)
                                    {
                                        alum.ColorSala = (EColores)cmbAulaColores.SelectedItem;
                                        alum.Turno = (ETurno)cmbTurnos.SelectedItem;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Esta sala ya contiene 30 alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case EColores.Rojo:
                                    if (cantAlumRojo <= 30)
                                    {
                                        alum.ColorSala = (EColores)cmbAulaColores.SelectedItem;
                                        alum.Turno = (ETurno)cmbTurnos.SelectedItem;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Esta sala ya contiene 30 alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case EColores.Amarillo:
                                    if (cantAlumAmarillo <= 30)
                                    {
                                        alum.ColorSala = (EColores)cmbAulaColores.SelectedItem;
                                        alum.Turno = (ETurno)cmbTurnos.SelectedItem;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Esta sala ya contiene 30 alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case EColores.Verde:
                                    if (cantAlumVerde <= 30)
                                    {
                                        alum.ColorSala = (EColores)cmbAulaColores.SelectedItem;
                                        alum.Turno = (ETurno)cmbTurnos.SelectedItem;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Esta sala ya contiene 30 alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                default:
                                    break;
                            }

                            break;
                        }
                    }
                }
                this.Close();
            }
        }

        private void ListViewConAula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewConAula_MouseClick(object sender, MouseEventArgs e)
        {
            string nombre = listViewConAula.SelectedItems[0].SubItems[0].Text;

        }

        private void ListviewSinAula_MouseClick(object sender, MouseEventArgs e)
        {
            legajo = Validaciones.ValidateStringToInt(listviewSinAula.SelectedItems[0].SubItems[2].Text);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAulaDocentes.Enabled = true;
            cmbAulaDocentes.Items.Clear();


            if ((EColores)cmbAulaColores.SelectedItem != EColores.Ninguno && (ETurno)cmbTurnos.SelectedItem != ETurno.Ninguno)
            {
                foreach (Aula aula in this.listAulas)
                {
                    if (aula.ColorSala == (EColores)cmbAulaColores.SelectedItem && (aula.Turno == (ETurno)cmbTurnos.SelectedItem))
                    {
                        foreach (Alumno alum in this.listAlumnos)
                        {
                            if (alum.ColorSala == aula.ColorSala && aula.Turno == (ETurno)cmbTurnos.SelectedItem)
                            {
                                ListViewItem listViewItem = new ListViewItem(alum.Apellido);
                                listViewItem.SubItems.Add(alum.Nombre);
                                //listViewItem.SubItems.Add(Validaciones.ValidateIntToString(alum.Legajo));
                                listViewItem.SubItems.Add(alum.Turno.ToString());
                                listViewItem.SubItems.Add(alum.ColorSala.ToString());
                                listViewItem.SubItems.Add(aula.Docente.Apellido);
                                listViewConAula.Items.Add(listViewItem);
                            }                            
                        }
                    }
                    else
                    {
                        listViewConAula.Items.Clear();
                    }
                }
            }
            else
            {
                listViewConAula.Items.Clear();
            }

            switch ((ETurno)cmbTurnos.SelectedItem)
            {
                case ETurno.Mañana:
                    if (this.ListAulas.Count() != 0) //Listo docentes solamente si la lista no está vacía
                    {
                        foreach (Aula aula in this.listAulas)
                        {
                            foreach (Docente docen in this.listDocentes)
                            {
                                if ((aula.Docente.Dni != docen.Dni))
                                {
                                    //cmbAulaDocentes.Items.Add(new { Text = (docen.Apellido+", "+docen.Nombre), Value = docen.Dni });
                                    cmbAulaDocentes.Items.Add(docen.Apellido);
                                }
                                else
                                {
                                    if (aula.Turno != (ETurno)cmbTurnos.SelectedItem)
                                    {
                                        cmbAulaDocentes.Items.Add(docen.Apellido);
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        foreach (Docente docen in this.listDocentes)
                        {
                            cmbAulaDocentes.Items.Add(docen.Apellido);
                        }
                    }
                    break;
                case ETurno.Tarde:
                    if (this.ListAulas.Count() != 0) //Listo docentes solamente si la lista no está vacía
                    {
                        foreach (Aula aula in this.listAulas)
                        {
                            foreach (Docente docen in this.listDocentes)
                            {
                                if ((aula.Docente.Dni != docen.Dni) && (aula.Turno == (ETurno)cmbTurnos.SelectedItem))
                                {
                                    //cmbAulaDocentes.Items.Add(new { Text = (docen.Apellido+", "+docen.Nombre), Value = docen.Dni });
                                    cmbAulaDocentes.Items.Add(docen.Apellido);
                                }
                                else
                                {
                                    if (aula.Turno != (ETurno)cmbTurnos.SelectedItem)
                                    {
                                        cmbAulaDocentes.Items.Add(docen.Apellido);
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        foreach (Docente docen in this.listDocentes)
                        {
                            cmbAulaDocentes.Items.Add(docen.Apellido);
                        }
                    }
                    break;
                default:
                    cmbAulaDocentes.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// Botón para la creación del aula
        /// </summary>
        private void BtnCrearAula_Click(object sender, EventArgs e)
        {
            bool existAula = false;

            if ((ETurno)cmbTurnos.SelectedItem != ETurno.Ninguno && cmbAulaColores.SelectedItem != null) //Verifico que tenga seleccionado un profesor y una sala
            {
                if (cmbAulaDocentes.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un Profesor para crear el aula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    foreach (Aula aula in this.listAulas) //Checkeo en la lista si el aula seleccionada ya fue creada
                    {
                        if ((aula.ColorSala == (EColores)cmbAulaColores.SelectedItem))
                        {
                            if (aula.Turno == (ETurno)cmbTurnos.SelectedItem)
                            {
                                existAula = true;
                                break;
                            }
                        }
                        else
                        {

                        }
                    }

                    if (!(existAula)) //Si existe muestro aviso y, si no, la creo
                    {
                        string x = cmbAulaDocentes.SelectedItem.ToString();

                        foreach (Docente docen in this.listDocentes)
                        {
                            if (docen.Apellido == x)
                            {
                                Aula newAula = new Aula((EColores)cmbAulaColores.SelectedItem, (ETurno)cmbTurnos.SelectedItem, docen);
                                this.aula = newAula;
                                this.DialogResult = DialogResult.OK;
                                SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\aplauso.wav");
                                sonido.Play();
                                MessageBox.Show("Aula creada exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                sonido.Stop();
                                this.Close();
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta aula ya fue creada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un profesor y un color para crear un Aula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CmbAulaDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
