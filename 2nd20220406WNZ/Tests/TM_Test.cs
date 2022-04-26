using _2nd20220406WNZ.Pages;
using _2nd20220406WNZ.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _2nd20220406WNZ.Tests
{
    [TestFixture]
    [Parallelizable]
    internal class TM_Test : CommonDriver
    {
        [Test, Order (1)]
        public void CreateTM_Test()
        {
            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoTMPage(driver);

            // TM page object initialization and definition
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.CreatTM(driver);
        }

        [Test, Order (2)]
        public void EditTM_Test()
        {
            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoTMPage(driver);

            // Edit TM
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.EditTM(driver,"dummy", "dummy1", "dummy2");
        }
        [Test, Order (3)]
        public void DeleteTM_Test()
        {
            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoTMPage(driver);
            
            // Delete TM
            TM_Page tmpageObj = new TM_Page();
            tmpageObj.DeleteTM(driver);
        }
    }
}
