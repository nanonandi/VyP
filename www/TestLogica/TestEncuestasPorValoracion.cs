using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace TestLogica
{
    /// <summary>
    /// Descripción resumida de TestEncuestasPorValoracion
    /// </summary>
    [TestClass]
    public class TestEncuestasPorValoracion
    {
        BaseDatos b = new BaseDatos();

        [TestMethod]
        public void rankingEncuestasPorValoracion()
        {

            DataTable ret = new DataTable();

            

            foreach (Encuesta encu in b.Encuestas())
            {

            }


        }
    }
}
