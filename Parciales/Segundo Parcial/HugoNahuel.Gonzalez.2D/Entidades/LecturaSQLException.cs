using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LecturaSQLException : Exception
    {
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public LecturaSQLException(string msg)
            : base(msg)
        {

        }
        #endregion
    }
}
