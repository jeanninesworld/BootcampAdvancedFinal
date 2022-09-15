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
        //private static ChromeDriver chromeDriver;

        private WebDriverFactory()
        {
            //Do-nothing..Do not allow to initialize this class from outside
        }
        private static WebDriverFactory instance = new WebDriverFactory();


        //protected static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public static WebDriverFactory getInstance()
        {
            return instance;
        }
        public static IWebDriver GetChromeDriver()
        {
            //string startupPath = Path.Combine(@"\..\BootcampAdancedFinal\SeleniumGrid\"); startupPath = "\..\BootcampAdancedFinal\SeleniumGrid\"
            //ChromeDriver chromeDriver = new ChromeDriver();
            ChromeOptions chromeOptions = new ChromeOptions();
            
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--incognito");
            //chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--ignore-certificate-errors");

            driver = new RemoteWebDriver(new Uri("http://localhost:4444"), chromeOptions);
            return driver;
        }
        //public static ThreadLocal<IWebDriver> GetIE()
        //{
        //    ThreadLocal<IWebDriver> IEThread = new ThreadLocal<IWebDriver>(() =>
        //    {
        //        new DriverManager().SetUpDriver(new InternetExplorerConfig());
        //        return new InternetExplorerDriver();
        //    });
        //    return IEThread;
        //}

        //public static IWebDriver GetChrome()
        //{
        //    ThreadLocal<IWebDriver> ChromeThread = new ThreadLocal<IWebDriver>(() =>
        //    {
        //        ChromeOptions option = new ChromeOptions();
        //        option.AddArgument("--chrome");
        //        option.AddArgument("--Windows10");
        //        option.AddArgument("--no-sandbox");
        //        option.AddArgument("--disable-gpu");
        //        option.AddArguments("--incognito");


        //        new RemoteWebDriver(new Uri("http://192.168.101.117:4444"), option);
        //        new DriverManager().SetUpDriver(new ChromeConfig());
        //        return new ChromeDriver(option);
        //    });

        //        return ChromeThread;
        //}

        /*public static ThreadLocal<IWebDriver> GetFireFox()
        {
            ThreadLocal<IWebDriver> FireFoxThread = new ThreadLocal<IWebDriver>(() =>
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                return new FirefoxDriver();
            });
            return FireFoxThread;
        }
        public static ThreadLocal<IWebDriver> GetEdge()
        {
            ThreadLocal<IWebDriver> EdgeThread = new ThreadLocal<IWebDriver>(() =>
            {
                string startupPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).
                Parent.Parent.FullName + @"\..\Framework\SeleniumGrid\";
                var service = EdgeDriverService.CreateDefaultService(startupPath, "msedgedriver.exe");
                service.UseVerboseLogging = true;
                //service.UseSpecCompliantProtocol = true;
                service.Start();
                var options = new EdgeOptions();
                return new IWebDriver(service.ServiceUrl, options);
            });
            return EdgeThread;
        } */
        //public void setDriver(BrowserType type)
        //{
        //    TypeBrowser = type;
        //    switch (type)
        //    {
        //            default: // BrowserType.Chrome:
        //            driver.Value = GetChrome().Value;
        //            break;
        //        /*case BrowserType.FireFox:
        //            driver.Value = GetFireFox().Value;
        //            break;
        //        default:
        //            driver.Value = GetEdge().Value;
        //            break; */
        //    }
        //}
        //public IWebDriver getDriver() // call this method to get the driver object and launch the browser
        //{
        //    return driver.Value;
        //}
        //public void removeDriver() // Quits the driver and closes the browser
        //{
        //    if (getInstance().getDriver() != null)
        //    {
        //        getInstance().getDriver().Close();
        //    }
        //}
        private BrowserType TypeBrowser
        {
            get
            {
                return _browserType;
            }
            set
            {
                _browserType = value;
            }

        }
    }
}



/* public class WebDriverFactory

{

    private static IWebDriver _driver;
    private static ChromeOptions chromeOptions;
    private static string chrome;
    private static string Windows10;
    private static string _myUrl = "http://automationpractice.com/index.php";

    public static IWebDriver OpenBrowser()

    {

        _driver = new ChromeDriver();
        chromeOptions = new ChromeOptions();


        // var headless = Utils.GetConfigValueAsString("headlessMode");
        // Use this if you have a larger or smaller screen and tests failing.  chromeOptions.AddArgument("--window-size=1920,1080");

        //chromeOptions.AddArgument("--headless");

        chrome = chromeOptions.BrowserName;
        Windows10 = chromeOptions.PlatformName;
        chromeOptions.AddArgument("--disable-gpu");
        chromeOptions.AddArgument("--no-sandbox");
        chromeOptions.AddArgument("--ignore-certificate-errors");
        chromeOptions.AddArgument("--disable-dev-shm-usage");
        //chromeOptions.AddArgument("--disable-popup-blocking");
        chromeOptions.AddArgument("--incognito");

        _driver = new IWebDriver(new Uri("http://192.168.101.117:4444"),chromeOptions);
        _myUrl = _driver.Url;


        return _driver;

    }
}     */



