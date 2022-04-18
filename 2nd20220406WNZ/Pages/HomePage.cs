﻿using _2nd20220406WNZ.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd20220406WNZ.Pages
{
    internal class Homepage
    {
        public void GotoTMPage(IWebDriver driver)
        {
            // Go to TM page
            IWebElement adminDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdown.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
