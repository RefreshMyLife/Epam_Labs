using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvatradeTests.Utils;

namespace Laba9.PageObject
{
    class BillPage : BasePage
    {
        public BillPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By toogleBtnСurrency = By.XPath("//*[@id='USD']");
        private readonly By nextStepButton = By.XPath("//*[@id='submit_section']/button[@class='button next_step_button']");
        private readonly By txtUserName= By.XPath("//*[@id='first_name']");
        private readonly By txtUserLastName= By.XPath("//*[@id='last_name']");
        private readonly By btnUserDateOfBirthDay= By.XPath("//*[@id='date_of_birth']");
        private readonly By btnSelectDateOfBirthDay= By.XPath("//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[5]/a");
        private readonly By txtIUserPhoneNumber= By.XPath("//*[@id='phone']");



        public BillPage ChooseCurrencyForBill()
        {
            WaitForVisibilityOfElemen(driver, toogleBtnСurrency).Click();
            WaitForVisibilityOfElemen(driver, nextStepButton).Click();
            Log.Info("Choose currence for bill");
            return this;

        }

        public BillPage EnterDateAboutUser()
        {
            WaitForVisibilityOfElemen(driver, txtUserName).SendKeys("Андрей");
            WaitForVisibilityOfElemen(driver, txtUserLastName).SendKeys("Захаров");
            WaitForVisibilityOfElemen(driver, btnUserDateOfBirthDay).Click();
            WaitForVisibilityOfElemen(driver, btnSelectDateOfBirthDay).Click();
            WaitForVisibilityOfElemen(driver, txtIUserPhoneNumber).SendKeys("292395791");
            WaitForVisibilityOfElemen(driver, nextStepButton).Click();
            Log.Info("Enter information about user");
            return this;

        }
    }
}
