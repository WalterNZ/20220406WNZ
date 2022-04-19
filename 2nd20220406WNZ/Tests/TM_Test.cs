using _2nd20220406WNZ.Pages;
using _2nd20220406WNZ.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _2nd20220406WNZ.Tests
{
    [TestFixture]
    internal class TM_Test : CommonDriver
    {
        [SetUp]
        public void LoginFunction()
        {
            // open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);

            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoTMPage(driver);
        }

        [Test]
        public void CreateTM_Test()
        {
            // TM page object initialization and definition
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.CreatTM(driver);
        }

        [Test]
        public void EditTM_Test()
        {
            // Edit TM
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.EditTM(driver);
        }
        [Test]
        public void DeleteTM_Test()
        {
            // Delete TM
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}
