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
    public class TestVotar
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
        public void TheVotarTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Seleccionar.aspx");
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("Encuesta 1");
            driver.FindElement(By.Id("AccEncuesta")).Click();
            driver.FindElement(By.Id("ImageButton3")).Click();
            driver.FindElement(By.Id("Vot")).Click();
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("Encuesta 2");
            driver.FindElement(By.Id("AccEncuesta")).Click();
            driver.FindElement(By.Id("ImageButton3")).Click();
            driver.FindElement(By.Id("Vot")).Click();
            driver.FindElement(By.Id("AccEncuesta")).Click();
            Assert.AreEqual("Seleccione una encuesta", driver.FindElement(By.Id("Errorlab")).Text);
            new SelectElement(driver.FindElement(By.Id("Enc"))).SelectByText("Encuesta 1");
            driver.FindElement(By.Id("AccEncuesta")).Click();
            driver.FindElement(By.Id("ImageButton2")).Click();
            driver.FindElement(By.Id("Vot")).Click();
            Assert.AreEqual("Con una nota tan mala necesitamos saber cuál es la razón para mejorar. Haga un comentario.", driver.FindElement(By.Id("Errorlab")).Text);
            driver.FindElement(By.Id("ImageButton2")).Click();
            driver.FindElement(By.Id("Descripcion")).Clear();
            driver.FindElement(By.Id("Descripcion")).SendKeys("Este es un comentario");
            driver.FindElement(By.Id("Vot")).Click();
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
