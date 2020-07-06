using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using HugoNahuel.Gonzalez._2D;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(PersonaSinDNIException))]
        public void PersonaSinDNI()
        { 
            Alumno a1 = new Alumno("Pepe", "Pompim", 2000000, false, 25410, 23132, ETurno.Mañana);
            a1.Dni = 0;
        }
        
        [TestMethod]
        public void PersonaDNIValido()
        {
            Alumno a1 = new Alumno("Pepe", "Pompim", 2000000, false, 25410, 23132, ETurno.Mañana);

            Assert.IsNotNull(a1);
        }

        [TestMethod]
        public void CrearValueTests()
        {
            MenuPrincipal menPrin = new MenuPrincipal();

            menPrin.loadTestValues();
            
            Assert.IsTrue(menPrin.ListaDocentes.Count == 5 && menPrin.ListaAlumnos.Count == 50);
            
            
        }
    }
}
