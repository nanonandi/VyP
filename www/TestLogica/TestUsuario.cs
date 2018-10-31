using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace TestLogica
{
    [TestClass]
    public class TestUsuario
    {
        [TestMethod]
        public void TestConstructorSetyGet()
        {
            Usuario u = new Usuario(1, "cuenta", "cuenta@ubu.es", "pepinillo");

            Assert.AreEqual(u.IdUsuario, 1);
            Assert.AreEqual(u.Cuenta, "cuenta");
            Assert.AreEqual(u.EMail, "cuenta@ubu.es");
        }

        [TestMethod]
        public void TestContrasena ()
        {
            Usuario u = new Usuario(1, "cuenta", "cuenta@ubu.es", "pepinillo");
            Assert.IsTrue(u.ComprobarContrasena("pepinillo"));
            u.AsignarContrasena("aceituna");
            Assert.IsTrue(u.ComprobarContrasena("aceituna"));


        }
    }
}
