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
    public partial class AltaAlumno : Form
    {
        #region Atributtes
        /// <summary>
        /// Atributos de la clase AltaAlumno
        /// </summary>
        private Alumno alum;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la clase AltaAlumno
        /// </summary>
        public AltaAlumno()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad para el objeto Alumno
        /// </summary>
        public Alumno Alum
        {
            get
            {
                return this.alum;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método que se ejecuta al abrirse la ventana load para cargar datos
        /// </summary>
        private void AltaAlumno_Load(object sender, EventArgs e)
        {
            //cmbAlumnoColorSala.DataSource = Enum.GetValues(typeof(EColores));
            cmbAlumnoParentesco.DataSource = Enum.GetValues(typeof(EParentesco));
            cmbAlumnoFemenino.Items.Add("Si");
            cmbAlumnoFemenino.Items.Add("No");
        }

        /// <summary>
        /// Botón de guardado de Alumno
        /// </summary>
        private void btnAltaAlumnoGuardar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidateEmptyData(txtAlumnoNombre.Text, txtAlumnoApellido.Text, txtAlumnoDNI.Text))
            {
                this.alum = new Alumno(txtAlumnoNombre.Text, txtAlumnoApellido.Text, Validaciones.ValidateStringToInt(txtAlumnoDNI.Text),
                                       Validaciones.ValidateStringToBool(cmbAlumnoFemenino.Text), Validaciones.ValidateStringToInt(txtAlumnoLegajo.Text),
                                       Validaciones.ValidateStringToFloat(txtAlumnoPrecioCuota.Text), ETurno.Ninguno);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        /// <summary>
        /// Botón para cerrar la ventana de Alta Alumno
        /// </summary>
        private void btnAltaAlumnoCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
