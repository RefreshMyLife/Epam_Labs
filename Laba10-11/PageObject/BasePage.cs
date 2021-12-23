using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;



namespace Laba9.PageObject
{
    class BasePage
    {
        protected static IWebDriver driver;

        protected BasePage(IWebDriver WebDriver)
        {
            driver = WebDriver;
        }

        protected static IWebElement WaitForVisibilityOfElemen(IWebDriver driver, By webElement)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(50)).Until(ExpectedConditions.ElementIsVisible(webElement));
        }

        protected static IWebElement FindElement(By webElement)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(25)).Until(ExpectedConditions.ElementIsVisible(webElement));
        }
    }
}
