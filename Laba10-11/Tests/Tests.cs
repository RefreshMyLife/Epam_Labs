using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using AvatradeTests.Driver;
using AvatradeTests.Model;
using AvatradeTests.Service;
using AvatradeTests.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests.Tests
{
    class Tests : CommonConditions
    {


        [Test]
        public void CreateNewBillTest()
        {
            billPage = demoAccountPage.ClickBtnOpenBill();
            billPage.ChooseCurrencyForBill().EnterDateAboutUser().EnterAdressDate();
            Assert.IsTrue(billPage.IsVisibilitySuccessBillOperation());
        }


        [Test]
        public void ExceedingBalanceTest()
        {
            demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddBigNumber().ClickBtnTopContract();
            Assert.IsTrue(demoAccountPage.IsVisibilityErrorContract());

        }
        [Test]
        public void AddFundsToYourAccountTest()
        {
            demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddSumPrice().ClickBtnTopContract();
            Assert.IsTrue(demoAccountPage.IsVisibilitySuccessAddUpMoney());

        }



        [Test]
        public void AddContractToYourAccountTest()
        {
            demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddSumPrice().ClickBtnBottomContract();
            Assert.IsTrue(demoAccountPage.IsVisibilitySuccessAddDownMoney());
        }




        [Test]
        public void ResetAccountTest()
        {
            demoAccountPage.ClickCashRegister().ClickBtnResetAccount();
            Assert.IsTrue(demoAccountPage.IsVisibilitySuccessResetAccount());
        }



        [Test]
        public void DelayedContracTest()
        {
            demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddSumPrice().ChooseDateStart().ClickBtnTopContract();
            Assert.IsTrue(demoAccountPage.IsVisibilitySuccessDateTimeContract());

        }


    }
}