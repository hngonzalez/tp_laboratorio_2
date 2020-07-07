using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {

        #region TestUnitarios
        /// <summary>
        /// Valida que se instancie la lista de paquetes
        /// </summary>
        [TestMethod]
        public void TestValidaInstanciaPaquetes()
        {
            Correo c = new Correo();
            Assert.IsNotNull(c.Paquetes);
        }

        /// <summary>
        /// Valida si el Tracking ID es repetido
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestValidaExceptionTrackingRepetido()
        {
            Correo c = new Correo();
            c += new Paquete("bs as", "321456");
            c += new Paquete("chile", "321456");
        }
        #endregion

    }
}
