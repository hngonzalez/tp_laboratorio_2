using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GrabaXMLSQLException : Exception
    {
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public GrabaXMLSQLException(string msg)
            : base(msg)
        {

        }
        #endregion
    }
}
