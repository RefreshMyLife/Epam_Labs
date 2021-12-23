using AvatradeTests.Model;
using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9.PageObject
{
    class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver) { }
        private static readonly string HOMEPAGE_URL = "https://www.binary.com";
        private readonly By txtLogin = By.XPath("//*[@id='txtEmail']");
        private readonly By txtPassword = By.XPath("//*[@id='txtPass']");
        private readonly By btnLogin = By.XPath("//*[@id='frmLogin']/div[3]/button");

        public LoginPage OpenPage()
        {
            driver.Navigate().GoToUrl(HOMEPAGE_URL);
            Log.Info("Open home Page");
            return this;
        }
        public LoginPage EnterLoginAndPassword(User user)
        {
            WaitForVisibilityOfElemen(driver, txtLogin).SendKeys(user.TradingAccount);
            WaitForVisibilityOfElemen(driver, txtPassword).SendKeys(user.Password);
            Log.Info("Enter Password and login");
            return this;
        }
        public DemoAccountPage SignIn()
        {
            WaitForVisibilityOfElemen(driver, btnLogin).Click();
            Log.Info("Click button SingIn");
            return new DemoAccountPage(driver);
        }
    }
}