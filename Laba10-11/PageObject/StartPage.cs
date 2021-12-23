using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Laba9.PageObject
{
    class StartPage:BasePage
    {
        public StartPage(IWebDriver webDriver) : base(webDriver) { }

        private static readonly string HOMEPAGE_URL = "https://www.binary.com";
        private readonly By btnInLogin = By.XPath("//*[@id='btn_login']/span");

        public StartPage OpenPage()
        {
            driver.Navigate().GoToUrl(HOMEPAGE_URL);
            return this;
        }

        public LoginPage ClickInLogin()
        {
            WaitForVisibilityOfElemen(driver, btnInLogin).Click();
            return new LoginPage (driver);
        }

    }
}
