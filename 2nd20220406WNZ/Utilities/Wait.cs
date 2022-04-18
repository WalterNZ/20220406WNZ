using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd20220406WNZ.Utilities
{
    internal class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string Locator, string LocatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (Locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LocatorValue)));
            }
            if (Locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(LocatorValue)));
            }
            if (Locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(LocatorValue)));
            }
        }

        public static void WaitToBevisible(IWebDriver driver, string Locator, string LocatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (Locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(LocatorValue)));
            }
            if (Locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(LocatorValue)));
            }
            if (Locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(LocatorValue)));
            }
        }
    }
}
