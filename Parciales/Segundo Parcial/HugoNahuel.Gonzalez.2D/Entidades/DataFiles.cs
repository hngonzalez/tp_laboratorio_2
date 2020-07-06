using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Entidades
{
    public static class DataFiles
    {
        #region Atributtes
        private static XmlDocument documentoXML = new XmlDocument();
        private static XmlNode unDocente;
        private static Docente auxDocente;
        private static List<Docente> auxListDocentes = new List<Docente>();
        private static XmlReader xmlReader;
        #endregion


        #region Methods
        /// <summary>
        /// Método que realiza la lectura de archivos
        /// </summary>
        /// <returns></returns>
        public static void LeerDocentesXML()
        {
            try
            {

                documentoXML.Load(@"C:\Users\Nahue\MisDocumentos\SegundoParcialUtn\JardinUtn\Docentes\Docentes.xml");

                XmlNodeList listaDocentes = documentoXML.SelectNodes("ArrayOfDocente/Docente");

                for (int i = 0; i < listaDocentes.Count; i++)
                {
                    unDocente = listaDocentes.Item(i);

                    auxListDocentes.Add(new Docente(unDocente.SelectSingleNode("Nombre").InnerText,
                                                    unDocente.SelectSingleNode("Apellido").InnerText,
                                                    Docente.ValidateStringToInt(unDocente.SelectSingleNode("Edad").InnerText),
                                                    Docente.ValidateStringToInt(unDocente.SelectSingleNode("Dni").InnerText),
                                                    unDocente.SelectSingleNode("Direccion").InnerText,
                                                    Docente.ValidateStringToInt(unDocente.SelectSingleNode("Id").InnerText),
                                                    unDocente.SelectSingleNode("Sexo").InnerText,
                                                    unDocente.SelectSingleNode("Email").InnerText));

                    
                }

                DataSQL.GrabaXMLaSQL(auxListDocentes);
            }
            catch (LecturaException)
            {
                throw new LecturaException("Error al leer archivo");
            }

        }
        #endregion
    }
}
