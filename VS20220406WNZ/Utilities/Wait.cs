using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS20220406WNZ.Utilities
{
    internal class Wait
    {
        public static void WaitToBeColickable(IWebDriver driver, string locator, string locatorValue, string v, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
        }

        internal static void WaitToBeColickable(IWebDriver driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static void WaitToBeVisible(IWebDriver driver, string locator, string locatorValue, string v, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }
        }
    }
}
