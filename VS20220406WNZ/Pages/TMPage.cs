using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VS20220406WNZ.Utilities;

namespace VS20220406WNZ.Pages
{
    internal class TMPage
    {
        public void CreatTM(IWebDriver driver)
        {
            // click on the create new button
            IWebElement creatnewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            creatnewButton.Click();

            // select Material from Typecode dropdown
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropdown.Click();
            Thread.Sleep(1000);

            IWebElement mOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            mOption.Click();

            // Identify the code textbox and input a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("20200406WNZ");

            // Identify the description textbox and input a description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("20200406WNZ");

            // Identify the price textbox and input a price
            IWebElement abovePrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            abovePrice.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("20200406");

            // Click on the Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeColickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);

            // Click on the go to last page button
            IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageButton.Click();
            Thread.Sleep(1000);

            // Check if record create is present in the table with expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualCode.Text == "20200406WNZ")
            {
                Console.WriteLine("Material record created successfully, test passed again!");
            }
            else
            {
                Console.WriteLine("Test Failed!");
            }
        }

        internal void creatTM(IWebDriver driver)
        {
            throw new NotImplementedException();
        }

        public void EditTM(IWebDriver driver)
        { 
         
        }

        public void DeleteTM(IWebDriver driver)
        { 
            
        }
    }
}
