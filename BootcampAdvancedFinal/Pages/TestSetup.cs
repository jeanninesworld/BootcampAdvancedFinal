using NUnit.Framework;
using OpenQA.Selenium;
namespace BootcampAdvancedFinal.Pages
{
    [TestFixture]
    public class TestSetup
    {
        protected IWebDriver driver
        {
            get; private set;
        }
        protected IWebDriver fireFox
        {
            get; private set;
        } 
        protected IWebDriver edgeDriver
        {
            get; private set;
        }

        [SetUp]
        public void Setup()
        {
            this.driver = DriverFactory.WebDriverFactory.GetChromeDriver();
            this.fireFox = DriverFactory.WebDriverFactory.GetFireFox();
            this.edgeDriver = DriverFactory.WebDriverFactory.GetEdgeDriver();
        }

    [TearDown]
        public void TearDown()
        {
            driver.Close();
            fireFox.Close();
            edgeDriver.Close();
            driver.Quit();
            fireFox.Quit();
            edgeDriver.Quit();
        }
    }
}
