using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {

        #region Methods
        /// <summary>
        /// Método que guarda información en un txt
        /// </summary>
        /// <param name="texto">Información a guardar</param>
        /// <param name="archivo">Nombre del archivo</param>
        /// <returns>True si se pudo</returns>
        public static bool Guardar(this string texto, string archivo)
        {
            string path = String.Format("{0}\\{1}", (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), archivo);

            try
            {
                using (StreamWriter st = new StreamWriter(path, true))
                st.WriteLine(texto);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}
