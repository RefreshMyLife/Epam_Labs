using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9.PageObject
{
    class DemoAccountPage :BasePage
    {
        public DemoAccountPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By txtPrice = By.XPath("//*[@id='amount']");
        private readonly By btnMarkets = By.XPath(" //*[@id='underlying_component']");
        private readonly By btnBearMarketIndex = By.XPath(" //*[@id='RDBEAR']");
        private readonly By txtSuccessAddMoney = By.XPath("//div[@id='contract_purchase_descr']");
        


        public DemoAccountPage EnterAddSumPrice(string price)
        {
            WaitForVisibilityOfElemen(driver, txtPrice).Clear();
            WaitForVisibilityOfElemen(driver, txtPrice).SendKeys(price);
            return this;
        }

        public DemoAccountPage ClickBtnBearIndex()
        {
            WaitForVisibilityOfElemen(driver, btnMarkets).Click();
            WaitForVisibilityOfElemen(driver, btnBearMarketIndex).Click();
            return this;
        }

        public bool IsVisibilitySuccessAddMoney()
        {
            return WaitForVisibilityOfElemen(driver, txtSuccessAddMoney).Text.Contains("Получите выплату");
        }

    }
}
