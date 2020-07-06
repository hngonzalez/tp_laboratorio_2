using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LecturaException : Exception
    {

        #region Constructors
        /// <summary>
        /// Constructor para la excepción de lectura de archivo XML
        /// </summary>
        /// <param name="msg"></param>
        public LecturaException(string msg) 
            : base(msg)
        {

        }
        #endregion
    }
}
