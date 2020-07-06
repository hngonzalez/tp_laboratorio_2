using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaSinDNIException : Exception
    {
        public PersonaSinDNIException(string msg, Exception innerException) 
            : base(msg, innerException)
        {

        }

        public PersonaSinDNIException(string msg) 
            : base(msg)
        {

        }


    }
}
