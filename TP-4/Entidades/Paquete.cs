using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region Delegates
        public delegate void DelegadoEstado(object sender, EventArgs e);
        #endregion


        #region Events
        /// <summary>
        /// Eventos
        /// </summary>
        public event DelegadoEstado InformaEstado;
        #endregion


        #region Enumerators
        /// <summary>
        /// Enumerador de tipo EEstado
        /// </summary>
        public enum EEstado
        {
            Ingresado,
            Enviaje,
            Entregado
        }
        #endregion


        #region Atributtes
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion


        #region Properties
        /// <summary>
        /// Propiedad Dirección de Entrega
        /// </summary>
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        /// <summary>
        /// Propiedad para el estado
        /// </summary>
        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        /// <summary>
        /// Propiedad TrackingID
        /// </summary>
        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor de la clase Paquete 
        /// </summary>
        /// <param name="direccionEntrega">Dirección del paquete</param>
        /// <param name="trackingID">ID del paquete</param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Guarda y modifica estados de los paquetes
        /// </summary>
        public void MockCicloDeVida()
        {
            for (int i = 0; i < 3; i++)
            {
                Estado = (EEstado)i;
                InformaEstado(this, new EventArgs());
                Thread.Sleep(4000);
            }
        }

        /// <summary>
        /// Método que mostrará
        /// </summary>
        /// <param name="elemento">Obj del que se mostrará los datos</param>
        /// <returns>String con los datos</returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", this.trackingID, this.direccionEntrega);
        }

        /// <summary>
        /// Overload del método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        #endregion


        #region Operators
        /// <summary>
        /// Operador que muestra si 2 paquetes son iguales según su trackingID
        /// </summary>
        /// <param name="p1">Paquete a comparar</param>
        /// <param name="p2">Paquete a comparar</param>
        /// <returns>True si son iguales</returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (p1.trackingID == p2.trackingID)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Operador que muestra si 2 paquetes son distintos según su trackingID
        /// </summary>
        /// <param name="p1">Paquete a comparar</param>
        /// <param name="p2">PAquete a comparar</param>
        /// <returns>True si son distintos (contrario del =)</returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        #endregion

    }
}
