using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoNahuel.Gonzalez._2D
{
    public partial class AltaNoDocente : Form
    {
        #region Atributtes
        private AltaNoDocente noDocente;
        #endregion

        #region Constructors
        public AltaNoDocente()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /*public Alumno Alum
        {
            get
            {
                return this.alum;
            }
        }*/
        #endregion

        private void BtnAltaNoDocenteCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaNoDocente_Load(object sender, EventArgs e)
        {

        }
    }
}
