using OpenQA.Selenium;

namespace BootcampAdvancedFinal
{
    public class Page
    {
        IWebDriver _driver;
        IWebDriver fireFox;
        IWebDriver edgeDriver;
        HomePage _homePage;

        /* public Page(IWebDriver _driver, IWebDriver fireFox)
        {
            //_driver = driver;

        } */
        public Page(IWebDriver _driver, IWebDriver fireFox, IWebDriver edgeDriver)
        {
            //_driver = _driver;
            //fireFox = fireFox;
            //edgeDriver = edgeDriver
        }
        public void Register()
        {
            _homePage = new HomePage(_driver, fireFox, edgeDriver);
        }
        public HomePage HomePage
        {
            get
            {
                return _homePage;
            }
        }

        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }
        public IWebDriver FireFox
        {
            get
            {
                return fireFox;
            }
            set
            {
                fireFox = value;
            }
        }
        public IWebDriver EdgeDriver
        {
            get
            {
                return edgeDriver;
            }
            set
            {
                edgeDriver = value;
            }
        }
    }
}