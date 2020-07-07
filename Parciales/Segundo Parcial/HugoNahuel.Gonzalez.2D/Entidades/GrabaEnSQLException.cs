using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GrabaEnSQLException : Exception
    {
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public GrabaEnSQLException(string msg)
            : base(msg)
        {

        }
        #endregion
    }
}
