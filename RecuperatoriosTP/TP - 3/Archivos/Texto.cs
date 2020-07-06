using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region 
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter sw = new StreamWriter(archivo);

            try
            {
                sw.Write(datos);
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
            finally
            {
                sw.Close();
            }
            return true;
        }

        public bool Leer(string archivo, out string datos)
        {
            StreamReader sw = new StreamReader(archivo);

            try
            {
                datos = sw.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                sw.Close();
            }
            return true;
        }
        #endregion
    }
}
