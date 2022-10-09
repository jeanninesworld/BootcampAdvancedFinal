using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace BootcampAdvancedFinal.DriverFactory
{
    public class WebDriverFactory
    {
        private BrowserType _browserType;
        private static IWebDriver driver;
        private static IWebDriver fireFox;
        private static IWebDriver edgeDriver;
        private WebDriverFactory() {}

        private static WebDriverFactory instance = new WebDriverFactory();

        public static WebDriverFactory getInstance()
        {
            return instance;
        }
        public static IWebDriver GetChromeDriver()
        {
            string startupPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).
            Parent.Parent.FullName + @"\source\repos\BootcampAdvancedFinal\BootcampAdvancedFinal\SeleniumGrid";

            ChromeOptions chromeOptions = new ChromeOptions();

            //chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--incognito");
            chromeOptions.AddArgument("--ignore-certificate-errors");

            driver = new RemoteWebDriver(new Uri("http://localhost:4444"), chromeOptions);
            return driver;
        } 
         public static IWebDriver GetFireFox()
        {

            string startupPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).
            Parent.Parent.FullName + @"\source\repos\BootcampAdvancedFinal\BootcampAdvancedFinal\SeleniumGrid";
            
            FirefoxOptions firefoxOptions = new FirefoxOptions();

            firefoxOptions.AddArgument("--headless");
            firefoxOptions.AddArgument("--disable-gpu");
            firefoxOptions.AddArgument("--no-sandbox");
            firefoxOptions.AddArgument("--ignore-certificate-errors");
            firefoxOptions.AddArgument("--disable-dev-shm-usage");
            firefoxOptions.AddArgument("--disable-popup-blocking");
            firefoxOptions.AddArgument("--incognito");

            var capabilities = firefoxOptions.ToCapabilities();
            fireFox = new RemoteWebDriver(new Uri("http://localhost:4444"), capabilities, TimeSpan.FromSeconds(30));
            return fireFox;
        } 

        public static IWebDriver GetEdgeDriver()
        {
            string startupPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).
            Parent.Parent.FullName + @"\source\repos\BootcampAdvancedFinal\BootcampAdvancedFinal\SeleniumGrid";

            EdgeOptions edgeOptions = new EdgeOptions();

            edgeOptions.AddArgument("--headless");
            edgeOptions.AddArgument("--no-sandbox");
            edgeOptions.AddArgument("--disable-gpu");
            edgeOptions.AddArgument("--incognito");
            edgeOptions.AddArgument("--ignore-certificate-errors");

            var capabilities = edgeOptions.ToCapabilities();
            edgeDriver = new RemoteWebDriver(new Uri("http://localhost:4444"), capabilities, TimeSpan.FromSeconds(30));
            return edgeDriver;
        }       
    }
}







