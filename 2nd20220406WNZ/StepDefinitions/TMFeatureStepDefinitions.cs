using _2nd20220406WNZ.Pages;
using _2nd20220406WNZ.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace _2nd20220406WNZ.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"\[I logged into turn up portal successfully]")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);
        }

        [When(@"\[I navigate to Time and Material page]")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoTMPage(driver);
        }

        [When(@"\[I create a new time and material record]")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.CreatTM(driver);
        }

        [Then(@"\[the record should be created successfully]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TM_Page tmpageObj = new TM_Page();

            string newCode = tmpageObj.GetCode(driver);
            string newTypeCode = tmpageObj.GetTypeCode(driver);
            string newDescription = tmpageObj.GetDescription(driver);
            string newPrice = tmpageObj.GetPrice(driver);

            Assert.That(newCode == "2nd@$#@21", "Actual code and expected code do not match!");
            Assert.That(newTypeCode == "M", "Acual Typecode and expected code do not match!");
            Assert.That(newDescription == "2nd@$#@21", "Acual Description and expected code do not match!");
            Assert.That(newPrice == "$2288666.00", "Acual Price and expected code do not match!");
        }

        [When(@"\[I update '([^']*)' on an existing time and material record]")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string p0)
        {
            // TM page object initialization and definition
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.EditTM(driver, p0);
        }

        [Then(@"\[the record should have the updated '([^']*)']")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0)
        {
            TM_Page tmpageObj = new TM_Page();

            string editedDescription = tmpageObj.GetEditedDescription(driver);

            Assert.That(editedDescription == p0, "Acual edited Description and expected code do not match!");
        }
         
    }
}
