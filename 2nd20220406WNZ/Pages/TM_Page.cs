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
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid]/div[3]/table/tbody/tr[1]/td[1]", 2);
            // Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);

            // Click go to the last page button
            IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageButton.Click();      
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        public string GetTypeCode(IWebDriver driver)
        {
            IWebElement actualTypecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return actualTypecode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
        }


        public void EditTM(IWebDriver driver, String description)
        {
            // Wait for the entire TM page displayed
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // Click on the go to last page button
            IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageButton.Click();

            IWebElement findrecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findrecordCreated.Text == "2nd@$#@21")
            {
                // Click edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click(); 
            }
            else
            {
                Assert.Fail("Record to be edited could not be found, edit failed!");
            }

            // Edit Code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("edited2ndCODE");

            // Edit Description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys(description);

            // Edit Price            
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));

            priceTag.Click();
            priceTextbox.Clear();
            priceTag.Click();
            priceTextbox.SendKeys("666");

            // Click save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);
            // Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid]/div[3]/table/tbody/tr[1]/td[1]", 2);
            // Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // Click on the go to last page button
            IWebElement gotolastpageButtonEDIT = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageButtonEDIT.Click();
            Thread.Sleep(1000);

            // Check if record edited is present in the table with expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualTypecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(actualCode.Text == "edited2ndCODE", "Actual code and expected code do not match!");
            Assert.That(actualTypecode.Text == "M", "Actual typecode and expected code do not match!");
            Assert.That(actualDescription.Text == "edited2ndDESCRIPTION", "Actual Description and expected code do not match!");
            Assert.That(actualPrice.Text == "$666.00", "Actual Price and expected code do not match!");
        }
        
        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement createdDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return createdDescription.Text;
        }


        public void DeleteTM(IWebDriver driver)
        {
            // Wait for the entire TM page displayed
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // Click on the go to last page button
            IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageButton.Click();
            Thread.Sleep(1000);

            IWebElement findrecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findrecordCreated.Text == "edited2ndCODE")
            {
                // Click delete button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(1000);

                driver.SwitchTo().Alert().Accept(); 
            }
            else
            {
                Assert.Fail("Record to be deleted could not be found, delete failed!");
            }

            // Assert that the mertial record just edited has been deleted 
            driver.Navigate().Refresh();
            Thread.Sleep(1000);

            IWebElement gotolastpageButtonDEL = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageButtonDEL.Click();
            Thread.Sleep(1000);

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            //Assertion
            Assert.That(editedCode.Text != "edited2ndCODE", "The edtied code to be deleted could not be found, delete successed!");
            Assert.That(editedDescription.Text != "edited2ndDESCRIPTION", "The edtied Description to be deleted could not be found, delete successed!");
            Assert.That(editedPrice.Text != "$666.00", "The edtied price to be deleted could not be found, delete successed!");
        }
    }
}
