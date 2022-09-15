using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampAdvancedFinal.Pages
{
    [TestFixture]
    public class TestSetup
    {
        protected IWebDriver driver
        {
            get; private set;
        }

        [SetUp]
        public void Setup()
        {
            this.driver = DriverFactory.WebDriverFactory.GetChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
