using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using System.Diagnostics;

namespace Laba8
{
    public class Tests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private const string Loign = "andreuzakharoy777@gmail.com";
        private const string TestPassword = "yrv}ib6W2n^U";

        private const string ExpectedDeal = "Получите выплату, если Индекс медвежьего рынка после 5 тиков будет строго выше, чем входная спот-котировка.";

        [SetUp]
        public void StartPageSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.binary.com");
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='btn_login']/span"))).Click();
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='txtEmail']"))).SendKeys(Loign);
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='txtPass']"))).SendKeys(TestPassword);
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmLogin']/div[3]/button"))).Click();
          

        }

        [Test]
        public void AddingFundsToYourAccountTest()
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(" //*[@id='underlying_component']"))).Click();
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(" //*[@id='RDBEAR']"))).Click();
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(" //*[@id='tab_graph']"))).Click();
            _driver.FindElement(By.XPath("//*[@id='amount']")).Clear();
            _driver.FindElement(By.XPath("//*[@id='amount']")).SendKeys("10");
            Thread.Sleep(3000);
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(" //*[@id='purchase_button_top']"))).Click();
            Thread.Sleep(3000);
            var actualDeal = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='contract_purchase_descr']"))).Text;
            Trace.WriteLine(actualDeal);
            Assert.AreEqual(ExpectedDeal, actualDeal);


        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}