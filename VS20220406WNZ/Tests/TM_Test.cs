using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using VS20220406WNZ.Pages;

namespace VS20220406WNZ.Tests
{
    internal class TM_Test
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // homepage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage TMPageObj = new TMPage();
            TMPageObj.creatTM(driver);

            // Edit TM
            TMPageObj.EditTM(driver);

            // Delete TM
            TMPageObj.DeleteTM(driver);





            // creat time and mertial record





            // Check if a user is able to edit the time / material record created in the previous test

            // Click on the Edit button
            Thread.Sleep(1000); 
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(1000);

            // Identify the Code textbox and input a new code
            Thread.Sleep(1000);
            IWebElement codeeditTextbox = driver.FindElement(By.Id("Code"));
            codeeditTextbox.Click();
            codeeditTextbox.Clear();
            codeeditTextbox.SendKeys("0412WNZ");

            // Identify the description textbox and input a new description
            IWebElement discriptioneditTextbox = driver.FindElement(By.Id("Description"));
            discriptioneditTextbox.Click();
            discriptioneditTextbox.Clear();
            discriptioneditTextbox.SendKeys("0412WNZ");
            Thread.Sleep(1000);

            // Identify the price textbox and input a new price
            IWebElement aboveeditPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement aboveeditPriceTextbox = driver.FindElement(By.Id("Price"));
            aboveeditPrice.Click();
            aboveeditPriceTextbox.Clear();
            aboveeditPrice.Click();
            aboveeditPriceTextbox.SendKeys("666");
            Thread.Sleep(3000);

            // Click on the save button
            IWebElement saveeditButton = driver.FindElement(By.Id("SaveButton"));
            saveeditButton.Click();
            Thread.Sleep(3000);

            // Click on the go to last page button
            IWebElement aftereditLastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            aftereditLastpagebutton.Click();
            Thread.Sleep(3000);

            // Check if record create is present in the table with expected value
            IWebElement actualCode1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (actualCode1.Text == "0412WNZ")
            {
                Console.WriteLine("Material record created successfully, test passed Once More!");
            }
            else
            {
                Console.WriteLine("Test Failed!");

            
        
            }
        }
    } 
}