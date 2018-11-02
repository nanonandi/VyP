using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace TestLogica {
    
    [TestClass]
    public class TestBaseDatos {
        [TestMethod]
        public void TestConstructor()
        {
            BaseDatos b = new BaseDatos();
            Assert.AreEqual(b.NumUsuarios(),2);
            Assert.IsTrue(b.EstaUsuario("cero"));
            Assert.IsTrue(b.EstaUsuario("uno"));
            Assert.AreEqual(b.NumEncuestas(), 2);
            Assert.IsTrue(b.EstaEncuesta("Encuesta 1"));
            Assert.IsTrue(b.EstaEncuesta("Encuesta 2"));
        }

        [TestMethod]
        public void TestGuardarUsuario()
        {
            BaseDatos b = new BaseDatos();
            b.GuardarUsuario(new Usuario("cuenta", "cuenta@ubu.es", "pepinillo"));
            Assert.AreEqual(b.NumUsuarios(), 3);
            Assert.IsTrue(b.EstaUsuario("cuenta"));
        }

        [TestMethod]
        public void TestGuardarEncuesta()
        {
            BaseDatos b = new BaseDatos();
            b.GuardarEncuesta(new Encuesta("encuestaprueba", "esta es una encuesta de prueba", true));
            Assert.AreEqual(b.NumEncuestas(), 3);
            Assert.IsTrue(b.EstaEncuesta("encuestaprueba"));
        }

        [TestMethod]
        public void TestEncuestasActivas()
        {
            BaseDatos b = new BaseDatos();
            b.GuardarEncuesta(new Encuesta("encuestainactiva", "esta es una encuesta no activa", false));
            Assert.AreEqual(b.NumEncuestas(), 3);
            Assert.IsTrue(b.EstaEncuesta("encuestainactiva"));
            Assert.AreEqual(b.NumEncuestasActivas(), 2);
        }
    }
}
