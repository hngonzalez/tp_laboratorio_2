using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Constructor de la Excepcion NacionalidadInvalidaException
        /// </summary>
        public NacionalidadInvalidaException()
        {

        }

        /// <summary>
        /// Overload del constructor de la Excepcion NacionalidadInvalidaException
        /// </summary>
        /// <param name="message"></param>
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }
    }
}
