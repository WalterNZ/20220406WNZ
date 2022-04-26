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
        // Page objective initialization
        LoginPage loginpageObj = new LoginPage();
        Homepage homepageObj = new Homepage();
        TM_Page tmpageObj = new TM_Page();

        [Given(@"\[I logged into turn up portal successfully]")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition

            loginpageObj.LoginSteps(driver);
        }

        [When(@"\[I navigate to Time and Material page]")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // home page object initialization and definition

            homepageObj.GotoTMPage(driver);
        }

        [When(@"\[I create a new time and material record]")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            // TM page object initialization and definition

            tmpageObj.CreatTM(driver);
        }


        [Then(@"\[the record should be created successfully]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmpageObj.GetCode(driver);
            string newTypeCode = tmpageObj.GetTypeCode(driver);
            string newDescription = tmpageObj.GetDescription(driver);
            string newPrice = tmpageObj.GetPrice(driver);

            Assert.That(newCode == "2nd@$#@21", "Actual code and expected code do not match!");
            Assert.That(newTypeCode == "M", "Acual Typecode and expected code do not match!");
            Assert.That(newDescription == "2nd@$#@21", "Acual Description and expected code do not match!");
            Assert.That(newPrice == "$2288666.00", "Acual Price and expected code do not match!");
        }

        [When(@"\[I update '([^']*)', '([^']*)' and '([^']*)' on an existing time and material record]")]
        public void WhenIUpdateWalterOnAnExistingTimeAndMaterialRecord(string p0, string p1, string p2)
        {
            tmpageObj.EditTM(driver, p0, p1, p2);
        }

        [Then(@"\[the record should have the updated '([^']*)','([^']*)'and'([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string p0, string p1, string p2)
        {
            string editedDescription = tmpageObj.GetEditedDescription(driver);
            string editedCode = tmpageObj.GetEditedCode(driver);
            string editPrice = tmpageObj.GetEditedCode(driver);

            Assert.That(editedDescription == p0, "Actual description and expected description do not matech!");
            Assert.That(editedCode == p1, "Actual code and expected code do not matech!");
            Assert.That(editPrice == p2, "Actual price and expected price do not matech!");
        }
    }
}
