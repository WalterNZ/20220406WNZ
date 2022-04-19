using _2nd20220406WNZ.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2nd20220406WNZ.Pages
{
    internal class TM_Page
    {
        public void CreatTM(IWebDriver driver)
        {
            // Click on the createnew button
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnewButton.Click();

            // Select material from Typecode dropdown
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropdown.Click();
            Thread.Sleep(1000);

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialOption.Click();
            Thread.Sleep(1000);

            // Identify the codetextbox and input a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("2nd@$#@21");

            // Identify the descriptiontextbox and input description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("2nd@$#@21");

            // Identify the pricetextbox and input a price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("2288666");

            // Click save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);
            // Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid]/div[3]/table/tbody/tr[1]/td[1]", 2);

            // Click go to the last page button
            IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageButton.Click();

            // Check if record created is present in the table with expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            // Option 1
            Assert.That(actualCode.Text == "2nd@$#@21", "Actual code and expected code do not match!");

            // Option 2
            // if (actualCode.Text == "2nd@$#@21")
            // {
            // Console.WriteLine("Material record created successfully, test passed.");
            // }
            // else
            // {
            // Console.WriteLine("Record Creation failed, test failed.");
            // }
        }

        public void EditTM(IWebDriver driver)
        { 
        
        }

        public void DeleteTM(IWebDriver driver)
        { 
        
        }
    }
}
