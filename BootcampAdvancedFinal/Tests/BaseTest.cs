using BootcampAdvancedFinal.DriverFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BootcampAdvancedFinal
{
    public class BaseTest
    {
        IWebDriver _driver;
        Page _pages;

        [SetUp]
        public void Test_Setup()
        {
            //Precondition:  This method will perform setup and will be run prior to executing any one test
            WebDriverFactory driverFactory = new WebDriverFactory();
            DriverContext = driverFactory.OpenBrowser();
            DriverContext.Manage().Window.Maximize();
            _pages = new Page(DriverContext);
            _pages.Register();
            DriverContext.Url = "http://automationpractice.com/index.php";

        }

        [TearDown]
        public void Test_Tear_Down()
        {
            //PostCondition:  This method will perform tearing down the test and will run after any one test
            DriverContext.Quit();
        }

        protected IWebDriver DriverContext
        {
            get { return _driver; }
            set { _driver = value; }
        }

        protected Page PageContext
        {
            get { return _pages; }
        }
        protected Page PagesContext
        {
            get
            {
                return _pages;
            }
        }
    }
}
