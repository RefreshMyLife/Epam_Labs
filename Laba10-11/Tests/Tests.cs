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

        //[Test]
        //public void AddFundsToYourAccountTest()
        //{
        //    demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddSumPrice().ClickBtnTopContract();
        //    Assert.IsTrue(demoAccountPage.IsVisibilitySuccessAddUpMoney());

        //}
        ////[Test]
        ////public void CreateContractUsingWebTraderTest()
        ////{
        ////    demoAccountPage.ClickTraderMenu().ClickWebTraderListItem().ClickBtnSetupWebTrader().ChooseTouchCondition().ClickBtnBuy();

        ////    Assert.IsTrue(webTraderPage.IsVisibilitySuccessWebTraderContract());
        ////}


        [Test]
        public void CreateNewBillTest()
        {
            demoAccountPage.ClickBtnOpenBill().ChooseCurrencyForBill().EnterDateAboutUser();

            //Assert.IsTrue(webTraderPage.IsVisibilitySuccessWebTraderContract());
        }


        //[Test]
        //public void AddFundsToYourAccountTest()
        //{
        //    demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddSumPrice().ClickBtnBottomContract();
        //    Assert.IsTrue(demoAccountPage.IsVisibilitySuccessAddDownMoney());
        //}




        //[Test]
        //public void ResetAccountTest()
        //{
        //    demoAccountPage.ClickCashRegister().ClickBtnResetAccount();
        //    Assert.IsTrue(demoAccountPage.IsVisibilitySuccessResetAccount());
        //}

        //[Test]
        //public void ExceedingBalanceTest()
        //{
        //    demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddBigNumber().ClickBtnTopContract();
        //    Assert.IsTrue(demoAccountPage.IsVisibilityErrorContract());

        //}


        //[Test]
        //public void DelayedContracTest()
        //{
        //    demoAccountPage.ClickBtnBearIndex().ClearPriceNumber().EnterAddSumPrice().ChooseDateStart().ClickBtnTopContract();
        //    Assert.IsTrue(demoAccountPage.IsVisibilitySuccessDateTimeContract());

        //}






        //[Test]
        //public void ChangePasswordTest()
        //{
        //    personalInformation = selectAccountPage.OpenPersonalInformationPage();
        //    personalInformation.OpenPanelChangePassword()
        //        .InputSimilarMyPassword(CreatorUser.WithCredentialsFromProperty().Password)
        //        .ClickChangePassword();
        //    Assert.IsTrue(personalInformation.IsTrueChangePassword());
        //}

        //[Test]
        //public void ChangeTypeInvoseTest()
        //{
        //    personalInformation = selectAccountPage.OpenPersonalInformationPage();
        //    personalInformation
        //        .OpenChangeTypeAccount()
        //        .ClickNewTypeAccount()
        //        .ClickStandartTypeAccount()
        //        .SaveStandartTypeAccount();
        //    Assert.IsTrue(personalInformation.IsChangeCurrentType());
        //}

        //[Test]
        //public void AddInvoiceThathasAlreadyBeenAddedTest()
        //{
        //    accountManagementPage = selectAccountPage.ClickSettingInvoice().OpenAccountManagementPage();
        //    accountManagementPage.EnterInvoiceAndPassword(CreatorUser.JoiningMyAccountFromProperty());
        //    accountManagementPage.AddNewInvoice();
        //    Assert.IsTrue(accountManagementPage.IsVisibilityAddMyInvoice());
        //}

        //[Test]
        //public void SelectShoulderTest()
        //{
        //    personalInformation = selectAccountPage.OpenPersonalInformationPage();
        //    personalInformation
        //        .OpenChangeShoulder()
        //        .ClickNewShoulder()
        //        .SelectShoulder()
        //        .SaveSelectShoulder();
        //    Assert.IsTrue(personalInformation.IsChangeSelectShoulder());
        //}

        //[Test]
        //public void AddFundsToYourAccountTest()
        //{
        //    replenishmentDemoAccountPage = selectAccountPage.OpenReplenishmentDemoAccountPage();
        //    string price = "1111";
        //    replenishmentDemoAccountPage.EnterAddSumPrice(price)
        //        .ClickBtnEnroll();
        //    Assert.IsTrue(replenishmentDemoAccountPage.IsVisibilitySuccessAddMoney());
        //}

        //[Test]
        //public void SellTest()
        //{
        //    tradingPage = selectAccountPage.OpenTradingPage();
        //    tradingPage.ClickPlusStopLoss().ClickPlusStopLoss().ClickPlusStopLoss()
        //        .ClickPlusStopLoss().ClickPlusStopLoss().ClickPlusStopLoss()
        //        .ClickPlusStopLoss().ClickPlusStopLoss().ClickPlusStopLoss()
        //        .ClickPlusStopLoss().ClickPlusStopLoss()
        //        .ClickSell();
        //    Assert.AreEqual(tradingPage.GetCreatedDealToString(), tradingPage.OpenCurrentTransactionsPage().GetLastDealToString());
        //}

        //[Test]
        //public void ChangePasswordTestInvestor()
        //{
        //    personalInformation = selectAccountPage.OpenPersonalInformationPage();
        //    personalInformation.OpenPanelChangePasswordInvestor()
        //        .InputSimilarMyPasswordInvestor(CreatorUser.WithCredentialsFromProperty().Password, CreatorUser.WithCredentialsFromProperty().PasswordInvestor)
        //        .ClickChangePasswordInvestor();
        //    Assert.IsTrue(personalInformation.IsTrueChangePasswordInvestor());
        //}
    }
}