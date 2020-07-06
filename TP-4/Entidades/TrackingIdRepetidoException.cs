using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class TrackingIdRepetidoException : Exception
    {

        #region Constructors
        /// <summary>
        /// Constructor de la excepcion TrackingRepetido
        /// </summary>
        /// <param name="mensaje"></param>
        public TrackingIdRepetidoException(string mensaje) : base(mensaje)
        {

        }

        /// <summary>
        /// Overload del constructor de la excepcion TrackingRepetido
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public TrackingIdRepetidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
        #endregion

    }
}
