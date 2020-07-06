using EntidadesInstanciadas;
using EntidadesAbstractas;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarioTP3
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void NacionalidadInvalida()
        {
            Alumno alumn = new Alumno(1, "Test", "ApeTest", "753433", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalido()
        {
            Alumno alumn = new Alumno(1, "Test", "ApeTest", "rtetye5rt", Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD);
        }

        [TestMethod]
        public void NonNull()
        {
            Alumno alumn = new Alumno(1, "Test", "ApeTest", "342234", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            Assert.IsNotNull(alumn.Apellido);
        }

        [TestMethod]
        public void NumericValidation()
        {
            Alumno alumn = new Alumno(1, "Test", "4", "123123", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
            Assert.IsInstanceOfType(alumn.DNI, typeof(int));
        }

    }
}
