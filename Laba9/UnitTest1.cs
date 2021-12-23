using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;
using System.IO;
using Laba9.PageObject;

namespace Laba9
{
    public class Tests
    {
        private IWebDriver driver;
        private StartPage startPage;
        private LoginPage loginPage;
        private DemoAccountPage demoAccountPage;

        private const string login = "andreuzakharoy777@gmail.com";
        private const string password = "yrv}ib6W2n^U";
        private const string price = "10";
       

        [SetUp]
        public void StartPageSetup()
        {
            var chromeOptions = new ChromeOptions();
            driver = new ChromeDriver(Directory.GetCurrentDirectory(), chromeOptions);
            loginPage = new StartPage(driver).OpenPage().ClickInLogin();
            demoAccountPage = loginPage.EnterLogin(login).EnterPassword(password).SignIn();

        }


        [Test]
        public void AddFundsToYourAccountTest()
        {
            demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddSumPrice(price).ClickBtnContract();
            Assert.IsTrue(demoAccountPage.IsVisibilitySuccessAddMoney());
            
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}