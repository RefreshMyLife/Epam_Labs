using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba9.PageObject
{
    class DemoAccountPage :BasePage
    {
        public DemoAccountPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By txtPrice = By.XPath("//*[@id='amount']");
        private readonly By btnMarkets = By.XPath(" //*[@id='underlying_component']");
        private readonly By btnBearMarketIndex = By.XPath(" //*[@id='RDBEAR']");
        private readonly By btnTopContract = By.XPath("//*[@id='purchase_button_top']");
        private readonly By btnBottomContract = By.XPath("//*[@id='purchase_button_bottom']");
        private readonly By txtSuccessAddMoney = By.XPath("//*[@id='contract_purchase_descr']");
        private readonly By listTraderMenu= By.XPath("//*[@id='menu-top']/li[5]/a");        
        private readonly By listItemWebTrader= By.XPath("//*[@id='menu-top']/li[5]/ul/li[2]/a");
        private readonly By btnCashRegister = By.XPath("//*[@id='topMenuCashier']/a");
        private readonly By btnResetAccount = By.XPath("//*[@id='VRT_topup_link']/span");
        private readonly By txtSuccessResetAccouunt= By.XPath("//*[@id='viewSuccess']/p");
        private readonly By txtContactError= By.XPath("//*[@id='confirmation_error']");
        private readonly By btnDateStart= By.XPath("//*[@id='date_start_row']/div[2]/div[1]/div");
        private readonly By btnSelectDateStart= By.XPath("//*[@id='date_start_row']/div[2]/div[1]/ul/li[4]");
        private readonly By txtDurationTime= By.XPath("//*[@id='duration_amount']");
        private readonly By txtSuccessContract= By.XPath("//*[@id='contract_purchase_heading']");
        private readonly By btnOpenBill= By.XPath("//*[@id='upgrade_btn_trade']");




        public DemoAccountPage ChooseDateStart()
        {
            WaitForVisibilityOfElemen(driver, btnDateStart).Click();
            WaitForVisibilityOfElemen(driver, btnSelectDateStart).Click();
            WaitForVisibilityOfElemen(driver, txtDurationTime).Clear();
            WaitForVisibilityOfElemen(driver, txtDurationTime).SendKeys("10");
            Log.Info("Choose the start date of the contract");
            return this;
        }

        public BillPage ClickOpenBillButton()
        {
            WaitForVisibilityOfElemen(driver, btnOpenBill).Click();
            Log.Info("Click to open bill button");
            return new BillPage(driver);
        }
        public DemoAccountPage EnterAddSumPrice()
        {
            WaitForVisibilityOfElemen(driver, txtPrice).SendKeys("10");
            Log.Info("Enter Price");
            return this;
        }
        public DemoAccountPage ClearPriceNumber()
        {
            WaitForVisibilityOfElemen(driver, txtPrice).SendKeys(Keys.Backspace);
            WaitForVisibilityOfElemen(driver, txtPrice).SendKeys(Keys.Backspace);
            Log.Info("Clear Price");
            return this;
        }

        public DemoAccountPage EnterAddBigNumber()
        {
           
            WaitForVisibilityOfElemen(driver, txtPrice).SendKeys("12000");
            Log.Info("Enter big Number in Price");
            return this;
        }
       


        public DemoAccountPage ClickBtnBearIndex()
        {
            WaitForVisibilityOfElemen(driver, btnMarkets).Click();
            WaitForVisibilityOfElemen(driver, btnBearMarketIndex).Click();
            Log.Info("Click to Bear Index button");
            return this;
        }

        public DemoAccountPage ClickBtnTopContract()
        {
            Thread.Sleep(2000);
            WaitForVisibilityOfElemen(driver, btnTopContract).Click();
            Log.Info("Click to Top Contract Button");
            return this;
        }
        public DemoAccountPage ClickBtnBottomContract()
        {
            WaitForVisibilityOfElemen(driver, btnBottomContract).Click();
            Log.Info("Click to Bottom Contract Button");
            return this;
        }
        public DemoAccountPage ClickTraderMenu()
        {
            WaitForVisibilityOfElemen(driver, listTraderMenu).Click();
            Log.Info("Click to Trade Menu");
            return this;
        }
        public DemoAccountPage ClickCashRegister()
        {
            WaitForVisibilityOfElemen(driver, btnCashRegister).Click();
            Log.Info("Click to Cash Register ");
            return this;
        }
        public DemoAccountPage ClickBtnResetAccount()
        {
            WaitForVisibilityOfElemen(driver, btnResetAccount).Click();
            Log.Info("Click Resset button");
            return this;
        }
       

        public BillPage ClickBtnOpenBill()
        {
            WaitForVisibilityOfElemen(driver, btnOpenBill).Click();
            Log.Info("Click  button to open bill");
            return new BillPage(driver);
        }

        public bool IsVisibilitySuccessAddUpMoney()
        {
            return WaitForVisibilityOfElemen(driver, txtSuccessAddMoney).Text.Equals("Получите выплату, если Индекс медвежьего рынка будет строго выше, чем входная спот-котировка, через 1 минут(ы) после врем. начала контракта.");
        }
        public bool IsVisibilitySuccessAddDownMoney()
        {
            return WaitForVisibilityOfElemen(driver, txtSuccessAddMoney).Text.Equals("Получите выплату, если Индекс медвежьего рынка будет строго ниже, чем входная спот-котировка, через 1 минут(ы) после врем. начала контракта.");
        }
        public bool IsVisibilitySuccessResetAccount()
        {
            return WaitForVisibilityOfElemen(driver, txtSuccessResetAccouunt).Text.Equals("Баланс вашего демо-счета был сброшен.");
        }

        public bool IsVisibilityErrorContract()
        {
            return WaitForVisibilityOfElemen(driver, txtContactError).Text.Contains("Баланс вашего");
        }

        public bool IsVisibilitySuccessDateTimeContract()
        {
            return WaitForVisibilityOfElemen(driver, txtSuccessContract).Text.Equals("Подтверждение контракта");
        }

    }
}
