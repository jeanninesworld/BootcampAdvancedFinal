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
        public BaseTest(IWebDriver driver, IWebDriver fireFox, IWebDriver edgeDriver) : base(driver, fireFox, edgeDriver) { }

        protected BrowserType _type;

        protected WebDriverFactory _driverFactoryInstance;
        protected Page _pages;

    }
}