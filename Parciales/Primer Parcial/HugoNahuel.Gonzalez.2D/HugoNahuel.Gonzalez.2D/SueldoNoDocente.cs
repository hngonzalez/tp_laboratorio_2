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
    public partial class SueldoNoDocente : Form
    {
        public SueldoNoDocente()
        {
            InitializeComponent();
        }

        private void SueldoNoDocente_Load(object sender, EventArgs e)
        {
            Administrativo cocina = new Administrativo("Carlos", "Pelaez", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Cocina);
            Administrativo tesoreria = new Administrativo("Carlos", "Pelaez", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Tesorería);
            Administrativo direccion = new Administrativo("Carlos", "Pelaez", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Dirección);
            Administrativo secretaria = new Administrativo("Carlos", "Pelaez", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Secretaría);
            Administrativo porteriaa = new Administrativo("Carlos", "Pelaez", 35487898, false, new System.DateTime(2020, 5, 7, 8, 00, 00), new System.DateTime(2020, 5, 7, 12, 00, 00), ECargo.Portería);

            lblSueldoCocina.Text = cocina.Salario.ToString();
            lblSueldoTesoreria.Text = tesoreria.Salario.ToString();
            lblSueldoDireccion.Text = direccion.Salario.ToString();
            lblSueldoSecretaria.Text = secretaria.Salario.ToString();
            lblSueldoPorteria.Text = porteriaa.Salario.ToString();
        }

        private void BtnSueldoNoDocenteCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

