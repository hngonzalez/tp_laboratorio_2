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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOperar.Enabled = false;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Desea cerrar la aplicación?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            
        }

        private void LblResultado_Click(object sender, EventArgs e)
        {

        }

        private void CmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "0";
            btnOperar.Enabled = false;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            Numero number1 = new Numero(txtNumero1.Text);
            Numero number2 = new Numero(txtNumero2.Text);
            double resultado = 0;

            resultado = Calculadora.Operar(number1, number2, cmbOperador.Text);

            lblResultado.Text = resultado.ToString();
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            btnOperar.Enabled = true;
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numAConvertir = new Numero();
            double dNumero = 0;

            if (double.TryParse(lblResultado.Text, out dNumero))
            {
                lblResultado.Text = numAConvertir.DecimalBinario(dNumero);
            }

            
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numAConvertir = new Numero();
            string strNumero = string.Empty;

            lblResultado.Text = numAConvertir.BinarioDecimal(lblResultado.Text);
            
        }
    }
}
