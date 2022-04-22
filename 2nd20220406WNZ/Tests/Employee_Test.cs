using _2nd20220406WNZ.Pages;
using _2nd20220406WNZ.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd20220406WNZ.Tests
{
    [TestFixture]
    [Parallelizable]
    internal class Employee_Test : CommonDriver
    {
        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoEmployeepage(driver);

            // Employee page object initialization and definition
            EmployeePage employeepageObj = new EmployeePage();
            employeepageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]
        public void EditEmployee_Test()
        {
            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoEmployeepage(driver);

            // Edit Employee
            EmployeePage employeepageObj = new EmployeePage();
            employeepageObj.EditEmployee(driver);
        }
        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            // home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GotoEmployeepage(driver);

            // Delete Employee
            EmployeePage employeepageObj = new EmployeePage();
            employeepageObj.DeleteEmployee(driver);
        }
    }
}
