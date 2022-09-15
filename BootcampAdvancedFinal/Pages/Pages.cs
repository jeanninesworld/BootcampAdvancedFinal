using OpenQA.Selenium;

namespace BootcampAdvancedFinal
{
    public class Page
    {
        IWebDriver _driver;
        HomePage _homePage;

        public Page(IWebDriver _driver)
        {
            //_driver = driver;
        }
        public void Register()
        {
            _homePage = new HomePage(_driver);
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
    }
}