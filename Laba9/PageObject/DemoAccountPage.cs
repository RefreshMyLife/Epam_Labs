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
        private readonly By btnContract = By.XPath("//*[@id='purchase_button_top']");
        private readonly By txtSuccessAddMoney = By.XPath("//*[@id='contract_purchase_descr']");
        
        


        public DemoAccountPage EnterAddSumPrice(string price)
        {
            WaitForVisibilityOfElemen(driver, txtPrice).SendKeys(price);
            return this;
        }
        public DemoAccountPage ClearPriceNumber()
        {
            WaitForVisibilityOfElemen(driver, txtPrice).Clear();
            return this;
        }
        public DemoAccountPage ClickBtnBearIndex()
        {
            WaitForVisibilityOfElemen(driver, btnMarkets).Click();
            WaitForVisibilityOfElemen(driver, btnBearMarketIndex).Click();
            return this;
        }

        public DemoAccountPage ClickBtnContract()
        {
            WaitForVisibilityOfElemen(driver, btnContract).Click();
            return this;
        }


        public bool IsVisibilitySuccessAddMoney()
        {
            return WaitForVisibilityOfElemen(driver, txtSuccessAddMoney).Text.Equals("Получите выплату, если Индекс медвежьего рынка будет строго выше, чем входная спот-котировка, через 1 минут(ы) после врем. начала контракта.");
        }

    }
}
