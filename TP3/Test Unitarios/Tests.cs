using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace Test_Unitarios
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ValidarJugador()
        {
            //Arrange
            Agente con1 = new Controladores("Brimstone", false, true);
            Jugador j1 = new Jugador(30, Localidades.EUROPA.ToString(), Rangos.Diamante.ToString(), con1);

            //Act

            //Assert

            Assert.IsNotNull(j1);
        }


        [TestMethod]
        [ExpectedException(typeof(ArchivosExcepcion))]
        public void ValidarArchivos()
        {
            ArchivoTexto at = new ArchivoTexto();

            at.Leer("Archivo Inexistente.txt");
        }
    }
}
