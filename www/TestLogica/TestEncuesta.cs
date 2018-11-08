using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace TestLogica {
    /// <summary>
    /// Descripción resumida de TestEncuesta
    /// </summary>
    [TestClass]
    public class TestEncuesta {

        [TestMethod]
        public void TestConstructor()
        {
            Encuesta e = new Encuesta("Encuesta1", "Primera encuesta", true);
            Assert.AreEqual(e.Nombre, "Encuesta1");
            Assert.AreEqual(e.Descripcion, "Primera encuesta");
            Assert.AreEqual(e.Activo(), true);
        }

        [TestMethod]
        public void TestPuntuarEncuesta()
        {
            Encuesta e = new Encuesta("Encuesta1", "Primera encuesta", true);
            e.Puntuar(5);
            e.Puntuar(3);
            e.Puntuar(2);
            Assert.AreEqual(e.NumeroVotos(), 3);
            Assert.AreEqual(e.Puntuacion, (5+3+2)/3);
        }

        [TestMethod]
        public void TestModificarEncuesta()
        {
            Encuesta e = new Encuesta("Encuesta1", "Primera encuesta", true);
            Assert.AreEqual(e.Nombre, "Encuesta1");
            Assert.AreEqual(e.Descripcion, "Primera encuesta");
            e.ModificarEncuesta("Encuesta2", "Encuesta modificada");
            Assert.AreEqual(e.Nombre, "Encuesta2");
            Assert.AreEqual(e.Descripcion, "Encuesta modificada");
        }

        [TestMethod]
        public void TestActivarDesactivarEncuesta()
        {
            Encuesta e = new Encuesta("Encuesta1", "Primera encuesta", true);
            Assert.AreEqual(e.Activo(), true);
            e.ActivarDesactivarEncuesta();
            Assert.AreEqual(e.Activo(), false);
            e.ActivarDesactivarEncuesta();
            Assert.AreEqual(e.Activo(), true);

        }

        [TestMethod]
        public void TestEquals()
        {
            Encuesta e = new Encuesta("Encuesta1", "Primera encuesta", true);
            Encuesta e2 = new Encuesta("Encuesta1", "Encuesta igual", true);
            Encuesta e3 = new Encuesta("Encuesta3", "Otra encuesta", true);
            Assert.IsTrue(e.Equals(e2));
            Assert.IsFalse(e.Equals(e3));
        }

        [TestMethod]
        public void TestComentar()
        {
            Encuesta e = new Encuesta("Encuesta1", "Primera encuesta", true);
            e.Comentar("Comentario");
            Assert.AreEqual(e.Comentarios[0], "Comentario");
        }
    }
}
