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
        private readonly By nextStepButton = By.XPath("//button[@class='button next_step_button']");
        private readonly By txtUserName= By.XPath("//*[@id='first_name']");
        private readonly By txtUserLastName= By.XPath("//*[@id='last_name']");
        private readonly By btnUserDateOfBirthDay= By.XPath("//*[@id='date_of_birth']");
        private readonly By btnSelectDateOfBirthDay= By.XPath("//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[5]/a");
        private readonly By txtIUserPhoneNumber= By.XPath("//*[@id='phone']");
        private readonly By nextBtnAddress= By.XPath("//button[@class='button margin-v-10 next_step_button']");
        private readonly By txtAddressStreet= By.XPath("//*[@id='address_line_1']");
        private readonly By txtAddressCity= By.XPath("//*[@id='address_city']");
        private readonly By btnNextAction= By.XPath("/html/body/div[2]/div[2]/div[3]/div[7]/div[2]/div[2]/div[1]/div[4]/form/div[3]/button");
        private readonly By checkBoxButtonConfirmWithInformation= By.XPath("///*[@id=pep_declaration_row']/div[2]/label"); 
        private readonly By checkBoxButtonConfirmWithAllRulls= By.XPath("//*[@id=tnc_row']/div/label");
        private readonly By btnNewAccountSubmit= By.XPath("//*[@id='new_account_submit']");
        private readonly By txtSuccessOperation= By.XPath("//*[@id='jurisdiction_row']/div");



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
            WaitForVisibilityOfElemen(driver, nextBtnAddress).Click();
            Log.Info("Enter information about user");
            return this;

        }

        public BillPage EnterAdressDate()
        {
            WaitForVisibilityOfElemen(driver, txtAddressStreet).SendKeys("Бобруйская");
            WaitForVisibilityOfElemen(driver, txtAddressCity).SendKeys("Минск");
            WaitForVisibilityOfElemen(driver, btnNextAction).Click();
            Log.Info("Enter information about user");
            return this;

        }

        public BillPage ConfirmConntract()
        {
            WaitForVisibilityOfElemen(driver, checkBoxButtonConfirmWithInformation).Click();
            WaitForVisibilityOfElemen(driver, checkBoxButtonConfirmWithAllRulls).Click();
            WaitForVisibilityOfElemen(driver, btnNewAccountSubmit).Click();
            Log.Info("Confirm with conditions");
            return this;

        }
        public bool IsVisibilitySuccessBillOperation()
        {
            return WaitForVisibilityOfElemen(driver, txtSuccessOperation).Text.Trim().Contains("Ваш счет будет открыт в компании");
        }
    }
}
