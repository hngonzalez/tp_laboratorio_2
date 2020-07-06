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

namespace FrmPpal
{
    public partial class FrmPpal : Form
    {
        private Entidades.Correo correo;   

        /// <summary>
        /// Constructor de la clase FrmPpal
        /// </summary>
        public FrmPpal()
        {
            InitializeComponent();
            correo = new Entidades.Correo();
        }


        /// <summary>
        /// Cerrando el formulario se cierran todos los hilos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }


        private void FrmPpal_Load(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// Botón que agrega un nuevo paquete al correo, es decir, a la lista de paquetes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Paquete newPackage = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);

            try
            {
                correo += newPackage;
                newPackage.InformaEstado += new Paquete.DelegadoEstado(paq_InformaEstado);
                PaqueteDAO.ExceptionDAO += new DelegadoException(ErrorDAO);
            }
            catch (TrackingIdRepetidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        /// <summary>
        /// Muestra información de todos los paquetes en cuestión y los graba, obtiene exception si no puede hacerlo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
            {
                rtbMostrar.Text = elemento.MostrarDatos(elemento);

                try
                {
                    rtbMostrar.Text.Guardar("salida.txt");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error al guardar en el archivo");
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }


        /// <summary>
        /// Actualiza los paquetes
        /// </summary>
        private void ActualizarEstados()
        {
            lstEstadoEntregado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoIngresado.Items.Clear();

            foreach (Paquete package in correo.Paquetes)
            {
                switch (package.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(package);
                        break;
                    case Paquete.EEstado.Enviaje:
                        lstEstadoEnViaje.Items.Add(package);
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(package);
                        break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(this.paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
           
        }


        /// <summary>
        /// Muestra la lista de paquetes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void MtxtTrackingID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LstEstadoEntregado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
