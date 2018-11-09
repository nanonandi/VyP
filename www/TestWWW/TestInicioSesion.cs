using System;
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
    public class TestInicioSesion
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
        public void TheInicioSesionTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Menu.aspx");
            Assert.AreEqual("Seleccione la encuesta que quiera votar.", driver.FindElement(By.Id("Princpal")).Text);
            driver.FindElement(By.Id("Iniciar")).Click();
            driver.FindElement(By.Id("user")).Clear();
            driver.FindElement(By.Id("user")).SendKeys("incorrecto");
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("hola");
            driver.FindElement(By.Id("iniciar")).Click();
            Assert.AreEqual("El usuario no existe o las contraseñas no coinciden.", driver.FindElement(By.Id("Errorlab")).Text);
            driver.FindElement(By.Id("Volver")).Click();
            driver.FindElement(By.Id("Iniciar")).Click();
            driver.FindElement(By.Id("user")).Clear();
            driver.FindElement(By.Id("user")).SendKeys("cero");
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("incorrecto");
            driver.FindElement(By.Id("iniciar")).Click();
            Assert.AreEqual("El usuario no existe o las contraseñas no coinciden.", driver.FindElement(By.Id("Errorlab")).Text);
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("hola");
            driver.FindElement(By.Id("iniciar")).Click();
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
