using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Test_Unitarios
{
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Test que validara si la instancia de jugador es correcta
        /// </summary>
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

        /// <summary>
        /// Test que espera una excepcion 
        /// Esta se trata de leer un archivo que no existe
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivosExcepcion))]
        public void ValidarArchivos()
        {
            //Arrange

            ArchivoTexto at = new ArchivoTexto();

            //Act

            at.Leer("Archivo Inexistente.txt");

            //Assert
        }

        /// <summary>
        /// Test que leera archivos XML y al agregarlos a la lista 
        /// verificara si estan correctamente cargados
        /// </summary>
        [TestMethod]
        public void LeerArchivosXML()
        {
            //Arange

            List<Jugador> jugadoresLeidosXML = new List<Jugador>();
            Serializador<Jugador> serializadorXML = new Serializador<Jugador>(IArchivo<Jugador>.ETipoArchivo.XML);
            string path = Directory.GetCurrentDirectory() + @"\Archivos\JugadoresGuardados";

            //Act

            jugadoresLeidosXML = Jugador.LeerArchivos(path, serializadorXML);

            //Assert

            foreach (Jugador item in jugadoresLeidosXML)
            {
                Assert.IsNotNull(item);
            }
        }

        /// <summary>
        /// Test que se conectara a la Base de datos y agregara jugadores a la lista 
        /// verificara si estan correctamente cargados
        /// </summary>
        [TestMethod]
        public void ConectarBaseDeDatos()
        {
            //Arange

            List<Jugador> jugadoresLeidosSQL = new List<Jugador>();

            //Act

            jugadoresLeidosSQL = Jugador.GetListaSQL();

            //Assert

            foreach (Jugador item in jugadoresLeidosSQL)
            {
                Assert.IsNotNull(item);
            }
        }
    }
}
