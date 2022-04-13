using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VS20220406WNZ.Utilities;

namespace VS20220406WNZ.Pages
{
    internal class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // go to the T&M page
            IWebElement adminDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdown.Click();

            Wait.WaitToBeColickable(driver, "xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2); 
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
