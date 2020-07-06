using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        #region Constructors
        /// <summary>
        /// Constructor de la clase NacionalidadInvalidaException
        /// </summary>
        public NacionalidadInvalidaException()
            : base()
        {

        }

        /// <summary>
        /// Overload del constructor
        /// </summary>
        /// <param name="message"></param>
        public NacionalidadInvalidaException(string message)
            : base(message)
        {

        }
        #endregion
    }
}
