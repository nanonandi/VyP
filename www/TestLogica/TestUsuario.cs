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
            Usuario u = new Usuario("cuenta", "cuenta@ubu.es", "pepinillo");
            Assert.AreEqual(u.Cuenta, "cuenta");
            Assert.AreEqual(u.EMail, "cuenta@ubu.es");
            Usuario u2 = new Usuario("cuenta2", "cuenta2@ubu.es", "pepinillo2");
            Assert.AreEqual(u2.Cuenta, "cuenta2");
            Assert.AreEqual(u2.EMail, "cuenta2@ubu.es");
            Usuario u3 = new Usuario("cuenta3", "cuenta3@ubu.es", "pepinillo2");
            Assert.AreEqual(u3.Cuenta, "cuenta3");
            Assert.AreEqual(u3.EMail, "cuenta3@ubu.es");
        }


        [TestMethod]
        public void TestContrasena ()
        {
            Usuario u = new Usuario("cuenta", "cuenta@ubu.es", "pepinillo");
            Assert.IsTrue(u.ComprobarContrasena("pepinillo"));
            u.AsignarContrasena("aceituna");
            Assert.IsTrue(u.ComprobarContrasena("aceituna"));


        }

        [TestMethod]
        public void TestEquals()
        {
            Usuario u = new Usuario("cuenta", "cuenta@ubu.es", "pepinillo");
            Usuario u2 = new Usuario("cuenta", "cuenta@ubu.es", "pepinillo");
            Usuario u3 = new Usuario("cuenta2", "cuenta2@ubu.es", "pepinillo2");
            Assert.IsTrue(u.Equals(u2));
            Assert.IsFalse(u.Equals(u3));
        }


    }
}
