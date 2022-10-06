using OpenQA.Selenium;

namespace BootcampAdvancedFinal
{
    public class Page
    {
        IWebDriver _driver;
        IWebDriver fireFox;
        IWebDriver edgeDriver;
        HomePage _homePage;
        SearchPage searchPage;
        ContactUsPage contactUsPage;
        CartPage cartPage;

        public Page(IWebDriver _driver, IWebDriver fireFox, IWebDriver edgeDriver)
        {
        }
        public void Register()
        {
            _homePage = new HomePage(_driver, fireFox, edgeDriver);
            searchPage = new SearchPage(_driver, fireFox, edgeDriver);
            contactUsPage = new ContactUsPage(_driver, fireFox, edgeDriver);
            cartPage = new CartPage(_driver, fireFox, edgeDriver);
        }
        public HomePage HomePage
        {
            get
            {
                return _homePage;
            }
        }
        public SearchPage SearchPage
        {
            get
            {
                return searchPage;
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