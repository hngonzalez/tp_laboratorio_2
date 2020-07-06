using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        private string mensajeBase;

        /// <summary>
        /// Constructor de la excepción DniInvalidoException
        /// </summary>
        public DniInvalidoException()
        {
            this.mensajeBase = "DNI Inválido";
        }

        /// <summary>
        /// Constructor de la excepción DniInvalidoException
        /// </summary>
        public DniInvalidoException(Exception e) : base(e.Message)
        {

        }

        /// <summary>
        /// Constructor de la excepción DniInvalidoException
        /// </summary>
        public DniInvalidoException(string message) : base(message)
        {

        }

        /// <summary>
        /// Constructor de la excepción DniInvalidoException
        /// </summary>
        public DniInvalidoException(string message, Exception e) : base(message, e)
        {

        }
    }
}
