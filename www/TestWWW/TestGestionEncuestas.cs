using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class TestGestionEncuestas
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [TestInitialize]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost:50554/";
            verificationErrors = new StringBuilder();
        }
        
        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [TestMethod]
        public void TheGestionEncuestasTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Seleccionar.aspx");
            driver.FindElement(By.Id("Iniciar")).Click();
            driver.FindElement(By.Id("user")).Clear();
            driver.FindElement(By.Id("user")).SendKeys("cero");
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("hola");
            driver.FindElement(By.Id("iniciar")).Click();
            driver.FindElement(By.Id("Anadir")).Click();
            driver.FindElement(By.Id("Aceptar")).Click();
            Assert.AreEqual("Selecciona activa o desactiva", driver.FindElement(By.Id("Errorlab")).Text);
            driver.FindElement(By.Id("Nombre")).Clear();
            driver.FindElement(By.Id("Nombre")).SendKeys("Encuestaprueba");
            driver.FindElement(By.Id("Aceptar")).Click();
            Assert.AreEqual("Selecciona activa o desactiva", driver.FindElement(By.Id("Errorlab")).Text);
            driver.FindElement(By.Id("Nombre")).Clear();
            driver.FindElement(By.Id("Nombre")).SendKeys("");
            driver.FindElement(By.Id("Radio_0")).Click();
            driver.FindElement(By.Id("Aceptar")).Click();
            Assert.AreEqual("Ponle un nombre a la encuesta", driver.FindElement(By.Id("Errorlab")).Text);
            driver.FindElement(By.Id("Nombre")).Clear();
            driver.FindElement(By.Id("Nombre")).SendKeys("Encuestaprueba");
            driver.FindElement(By.Id("Descripcion")).Clear();
            driver.FindElement(By.Id("Descripcion")).SendKeys("Encuesta inactiva");
            driver.FindElement(By.Id("Radio_1")).Click();
            driver.FindElement(By.Id("Aceptar")).Click();
            driver.FindElement(By.Id("ActDes")).Click();
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("Encuestaprueba");
            Assert.AreEqual("Inactiva", driver.FindElement(By.Id("Estado")).Text);
            driver.FindElement(By.Id("Volver")).Click();
            driver.FindElement(By.Id("Volver")).Click();
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("Encuesta 1");
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("Encuesta 2");
            driver.FindElement(By.Id("Iniciar")).Click();
            driver.FindElement(By.Id("Modificar")).Click();
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("Encuesta 2");
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("Encuestaprueba");
            driver.FindElement(By.Id("Nombre")).Clear();
            driver.FindElement(By.Id("Nombre")).SendKeys("CambioNombre");
            driver.FindElement(By.Id("Descripcion")).Clear();
            driver.FindElement(By.Id("Descripcion")).SendKeys("Encuesta activa");
            driver.FindElement(By.Id("Aceptar")).Click();
            driver.FindElement(By.Id("ActDes")).Click();
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("CambioNombre");
            driver.FindElement(By.Id("Aceptar")).Click();
            driver.FindElement(By.Id("Volver")).Click();
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("CambioNombre");
            driver.FindElement(By.Id("AccEncuesta")).Click();
            driver.FindElement(By.Id("ImageButton4")).Click();
            driver.FindElement(By.Id("Vot")).Click();
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("CambioNombre");
            driver.FindElement(By.Id("AccEncuesta")).Click();
            driver.FindElement(By.Id("ImageButton2")).Click();
            driver.FindElement(By.Id("Descripcion")).Clear();
            driver.FindElement(By.Id("Descripcion")).SendKeys("Comentario");
            driver.FindElement(By.Id("Vot")).Click();
            driver.FindElement(By.Id("Iniciar")).Click();
            driver.FindElement(By.Id("Result")).Click();
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("CambioNombre");
            string a = driver.FindElement(By.Id("ResultadosList")).Text;
            string[] b = a.Split('\n');
            Assert.AreEqual('4', b[0][0]);
            Assert.AreEqual("2", b[1]);
            Assert.AreEqual("Comentario", driver.FindElement(By.Id("ComentariosList")).Text);
            Assert.AreEqual("3", driver.FindElement(By.Id("result")).Text);
            string d = driver.FindElement(By.Id("Enc")).Text;
            string[] e = d.Split('\n');
            Assert.AreEqual('V', e[0][1]);
            Assert.AreEqual('E', e[1][1]);
            Assert.AreEqual('E', e[2][1]);
            Assert.AreEqual('C', e[3][1]);
            driver.FindElement(By.Id("Volver")).Click();
            driver.FindElement(By.Id("end")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
