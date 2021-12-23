using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9.PageObject
{
    class WebTraderPage : BasePage
    {
        public WebTraderPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By listValueCondition = By.XPath("//*[@id='ui - id - 19 - button']/span[1]");
        private readonly By touchCondition  = By.XPath("//*[@id='ui - id - 260']");
        private readonly By btnBuy  = By.XPath("//*[@id='windows - dialog - 2']/div/ul[16]/li[2]/button");
        private readonly By txtSuccessContract  = By.XPath("//*[@id='windows - dialog - 2']/div[2]/ul[1]/li/span");
        private readonly By btnSetupWebTrader  = By.XPath("//*[@id='content']/div/div[1]/button");

        public WebTraderPage ChooseTouchCondition()
        {
            WaitForVisibilityOfElemen(driver, listValueCondition).Click();
            WaitForVisibilityOfElemen(driver, touchCondition).Click();
            return this;
        }
        public WebTraderPage ClickBtnBuy()
        {
            WaitForVisibilityOfElemen(driver, btnBuy).Click();
            return this;
        }
        public WebTraderPage ClickBtnSetupWebTrader()
        {
            WaitForVisibilityOfElemen(driver, btnSetupWebTrader).Click();
            return this;
        }
        public bool IsVisibilitySuccessWebTraderContract()
        {
            return WaitForVisibilityOfElemen(driver, txtSuccessContract).Text.Equals("Подтверждение контракта");
        }

    }
}           
