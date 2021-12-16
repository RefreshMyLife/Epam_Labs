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

        private readonly By txtLogin = By.XPath("//*[@id='txtEmail']");
        private readonly By txtPassword = By.XPath("//*[@id='txtPass']");
        private readonly By btnLogin = By.XPath("//*[@id='frmLogin']/div[3]/button");


        public LoginPage EnterLogin(string login)
        {
            WaitForVisibilityOfElemen(driver, txtLogin).SendKeys(login);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            WaitForVisibilityOfElemen(driver, txtPassword).SendKeys(password);
            return this;
        }

        public DemoAccountPage SignIn()
        {
            WaitForVisibilityOfElemen(driver, btnLogin).Click();
            return new DemoAccountPage(driver);
        }
    }
}