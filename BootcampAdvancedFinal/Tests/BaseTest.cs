using BootcampAdvancedFinal.DriverFactory;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TestContext = NUnit.Framework.TestContext;

namespace BootcampAdvancedFinal
{
    [TestFixture]
    public class BaseTest :BasePage
    {
        public BaseTest(IWebDriver driver) : base(driver) { }
        protected BrowserType _type;

        protected WebDriverFactory _driverFactoryInstance;
        protected Page _pages;


       

        //[SetUp]
        //public void Setup()
        //{
            
        //    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
        //    driver.Manage().Window.Maximize();          
            
        //}
        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Close();
        //    driver.Quit();
        //}
        //[OneTimeSetUp]
        //public void BeforeAllTests()
        //{

        //}
        //[OneTimeTearDown]
        //public void AfterAllTests()
        //{
            
        //    System.Diagnostics.ProcessStartInfo p;
           
        //    switch (BrowserTypeContext)
        //    {
        //        default:
        //            p = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + "taskkill /f /im chromedriver.exe");
        //            break;
        //        case BrowserType.FireFox:
        //            p = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + "taskkill /f /im geckodriver.exe");
        //            break;
        //        /*case BrowserType.Edge:
        //            p = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + "taskkill /f /im internetexplorerdriver.exe");
        //            break; */
        //    }
        //    System.Diagnostics.Process proc = new System.Diagnostics.Process();
        //    proc.StartInfo = p;
        //    proc.Start();
        //    proc.WaitForExit();
        //    proc.Close();
        //}
        //public void Dispose()
        //{
        //    TearDown();
        //}
        //protected IWebDriver Driver
        //{
        //    get
        //    {
        //        return driver;
        //    }
        //    set
        //    {
        //        driver = value;
        //    }
        //}
        //protected WebDriverFactory DriverFactoryInstance
        //{
        //    get
        //    {
        //        return _driverFactoryInstance;
        //    }
        //    set
        //    {
        //        _driverFactoryInstance = value;
        //    }
        //}

        //protected TestContext CurrentTestContext
        //{
        //    get
        //    {
        //        return TestContext.CurrentContext;
        //    }
        //}
        //protected BrowserType BrowserTypeContext
        //{
        //    get
        //    {
        //        return _type;
        //    }
        //    set
        //    {
        //        _type = value;
        //    }
        //}
        //protected Page PagesContext
        //{
        //    get
        //    {
        //        return _pages;
        //    }
        //}
    }
}