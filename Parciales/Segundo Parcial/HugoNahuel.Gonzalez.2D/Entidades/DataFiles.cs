using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    public static class DataFiles
    {
        #region Atributtes
        private static XmlDocument documentoXML = new XmlDocument();
        private static XmlNode unDocente;
        private static List<Docente> auxListDocentes = new List<Docente>();
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
                
                documentoXML.Load(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Docentes\\Docentes.xml");

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

        /// <summary>
        /// Método que realiza la lectura de archivos XML
        /// </summary>
        /// <returns></returns>
        public static Alumno LeerAlumnoXML(string path)
        {
            try
            {

                documentoXML.Load(path);

                XmlNode nodeAlumno = documentoXML.SelectSingleNode("Alumno");

                Alumno a = new Alumno(Docente.ValidateStringToInt(nodeAlumno.SelectSingleNode("IdAlumno").InnerText),
                                      nodeAlumno.SelectSingleNode("Nombre").InnerText,
                                      nodeAlumno.SelectSingleNode("Apellido").InnerText,
                                      Docente.ValidateStringToInt(nodeAlumno.SelectSingleNode("Edad").InnerText),
                                      Docente.ValidateStringToInt(nodeAlumno.SelectSingleNode("Dni").InnerText),
                                      nodeAlumno.SelectSingleNode("Direccion").InnerText);
                return a;
            }
            catch (LecturaException)
            {
                throw new LecturaException("Error al leer archivo");
            }

        }

        /// <summary>
        /// Método que realiza la serialización del alumno
        /// </summary>
        /// <param name="alumno"></param>
        public static void SerializarAlumno(Alumno alumno, string aprobado)
        {
            XmlSerializer formateador = new XmlSerializer(typeof(Alumno));
            string path = String.Empty;

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Logs\\"))
            {
                DirectoryInfo di = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Logs\\");
                if (aprobado == "APROBADO")
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Aprobados\\" + alumno.Apellido + "_" + alumno.Nombre + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".xml";
                }
                else
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Desaprobados\\" + alumno.Apellido + "_" + alumno.Nombre + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "'_'" + DateTime.Now.Year + ".xml";
                }

                Stream miStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);

                formateador.Serialize(miStream, alumno);

                miStream.Close();

                throw new AlumSerializacionException();
            }
            else
            {
                if (aprobado == "APROBADO")
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Aprobados\\" + alumno.Apellido + "_" + alumno.Nombre + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".xml";
                }
                else
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Desaprobados\\" + alumno.Apellido + "_" + alumno.Nombre + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".xml";
                }

                Stream miStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);

                formateador.Serialize(miStream, alumno);

                miStream.Close();
            }
        }

        /// <summary>
        /// Método que realiza la serialización del alumno
        /// </summary>
        /// <param name="alumno"></param>
        public static void SerializarAlumnoBinario(Alumno alumno, string aprobado)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Aprobados\\" + alumno.Apellido + "_" + alumno.Nombre + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".aut";
            Stream miStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            formateador.Serialize(miStream, alumno);
            miStream.Close();
        }


        /// <summary>
        /// Método que realiza la lectura de archivos XML
        /// </summary>
        /// <returns></returns>
        public static Alumno LeerAlumnoBinario(string path)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);

            Alumno a = (Alumno)formateador.Deserialize(miStream);
            return a;
        }
        #endregion
    }
}
