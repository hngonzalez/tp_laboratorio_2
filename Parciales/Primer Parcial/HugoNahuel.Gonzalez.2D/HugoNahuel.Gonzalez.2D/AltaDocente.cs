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
    public partial class AltaDocente : Form
    {
        #region Atributtes
        private Docente docen;
        #endregion

        #region Constructors
        public AltaDocente()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public Docente Docen
        {
            get
            {
                return this.docen;
            }
        }
        #endregion

        #region Methods
        private void AltaDocente_Load(object sender, EventArgs e)
        {
            cmbAltaDocenteFemenino.Items.Add("Si");
            cmbAltaDocenteFemenino.Items.Add("No");

            dtpAltaDocenteEntrada.ShowUpDown = true;
            dtpAltaDocenteEntrada.CustomFormat = "hh:mm tt";
            dtpAltaDocenteEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            dtpAltaDocenteSalida.ShowUpDown = true;
            dtpAltaDocenteSalida.CustomFormat = "hh:mm tt";
            dtpAltaDocenteSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        private void btnAltaDocenteCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnAltaDocenteGuardar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidateEmptyData(txtDocenteNombre.Text, txtDocenteApellido.Text, txtDocenteDNI.Text))
             {
                this.docen = new Docente(txtDocenteNombre.Text, txtDocenteApellido.Text, Validaciones.ValidateStringToInt(txtDocenteDNI.Text),
                                         Validaciones.ValidateStringToBool(cmbAltaDocenteFemenino.Text), dtpAltaDocenteEntrada.Value,
                                         dtpAltaDocenteSalida.Value, Validaciones.ValidateStringToDouble(txtAltaDocenteValorHora.Text));
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}
