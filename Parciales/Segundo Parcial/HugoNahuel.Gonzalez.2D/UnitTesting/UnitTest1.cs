using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.IO;
using System.Xml;
using System.Xml.Serialization; 

namespace UnitTesting
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlumnoXML()
        {
            Alumno al = new Alumno();
            Alumno alum = new Alumno(7,"Matias","Suarez",32,454547,"acalavuelta 2");

            DataFiles.SerializarAlumno(alum, "APROBADO");

            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Aprobados");

            foreach (var fi in di.GetFiles("Suarez_Matias*.xml"))
            {
                al = DataFiles.LeerAlumnoXML(fi.FullName); 
            }

            Assert.IsNotNull(al);
        }

        [TestMethod]
        public void AlumnoBinario()
        {
            Alumno al = new Alumno();
            Alumno alum = new Alumno(7, "Matias", "Suarez", 32, 454547, "acalavuelta 2");

            DataFiles.SerializarAlumnoBinario(alum, "APROBADO");

            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Aprobados");

            foreach (var fi in di.GetFiles("Suarez_Matias*.aut"))
            {
                al = DataFiles.LeerAlumnoBinario(fi.FullName);
            }

            Assert.IsNotNull(al);
        }
    }
}
