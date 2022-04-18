using _2nd20220406WNZ.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _2nd20220406WNZ.Tests
{
    internal class TM_Test
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);

            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoTMPage(driver);

            // TM page object initialization and definition
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.CreatTM(driver);

            // Edit TM
            tmpageObj.EditTM(driver);

            // Delete TM
            tmpageObj.DeleteTM(driver);
        }
    }
}
