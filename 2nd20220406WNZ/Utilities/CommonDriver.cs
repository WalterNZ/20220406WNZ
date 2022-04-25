using _2nd20220406WNZ.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd20220406WNZ.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginFunction()
        {
            // open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
       
            // Login page object initialization and definition
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
