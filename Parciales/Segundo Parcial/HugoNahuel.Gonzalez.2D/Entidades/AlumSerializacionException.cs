using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class AlumSerializacionException : Exception
    {
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public AlumSerializacionException()
            : base()
        {
            TextWriter escribe = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Logs\\log.txt");

            escribe.WriteLine("Se generó la carpeta Logs por no existir");
            escribe.Close();
        }
        #endregion
    }
}
