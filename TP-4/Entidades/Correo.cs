using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Atributtes
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor de la clase por defecto
        /// </summary>
        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }
        #endregion


        #region Proiperties
        /// <summary>
        /// Propiedad para la lista de paquetes
        /// </summary>
        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }
        #endregion


        #region Methods
        /// <summary>
        /// Método que cierra los hilos abiertos
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread hilo in this.mockPaquetes)
            {
                hilo.Abort();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Paquete package in this.paquetes)
            {
                sb.AppendFormat("{0} para {1} {2}\n", package.TrackingID, package.DireccionEntrega, package.Estado.ToString());
            }

            return sb.ToString();
        }
        #endregion


        #region Operators
        /// <summary>
        /// Agrega nuevo paquete con nuevo hilo
        /// </summary>
        /// <param name="c">Lista de paquetes</param>
        /// <param name="p">Paquete a agregar</param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete package in c.paquetes)
            {
                if (package == p)
                {
                    throw new TrackingIdRepetidoException("El paquete ya está cargado en la lista");
                }
            }

            c.paquetes.Add(p);
            Thread hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            hilo.Start();

            return c;
        }
        #endregion

    }
}
