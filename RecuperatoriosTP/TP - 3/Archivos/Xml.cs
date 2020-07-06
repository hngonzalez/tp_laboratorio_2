using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(T));
            XmlTextWriter xmlWri = new XmlTextWriter(archivo, Encoding.UTF8);

            try
            {
                xmlSer.Serialize(xmlWri, datos);
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
            finally
            {
                xmlWri.Close();
            }
            return true;
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(T));
            XmlTextReader xmlRead = new XmlTextReader(archivo);

            try
            {
                datos = (T)
                xmlSer.Deserialize(xmlRead);
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                xmlRead.Close();
            }
            return true;
        }
    }
}
