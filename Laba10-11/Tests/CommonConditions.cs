using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using AvatradeTests.Driver;
using AvatradeTests.Model;
using AvatradeTests.Service;
using AvatradeTests.Utils;
using Laba9.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests.Tests
{
    class CommonConditions
    {
        protected IWebDriver driver;
        protected DemoAccountPage demoAccountPage;
        protected StartPage startPage;
        protected WebTraderPage webTraderPage;
        protected BillPage billPage;
        [SetUp]
        public void StartPageSetup()
        {
            User testUser = CreatorUser.WithCredentialsFromProperty();
            driver = DriverManager.GetWebDriver();
            demoAccountPage = new StartPage(driver).OpenPage().ClickInLogin().EnterLoginAndPassword(testUser).SignIn();
        }

        [TearDown]
        public void CloseBrowser()
        {
            Log.Info($"Close test: {TestContext.CurrentContext.Test.MethodName}");
           // DriverManager.CloseWebDriver();
        }
    }
}
