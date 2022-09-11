using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace BootcampAdvancedFinal
{
    public class BasePage
    {
        IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void EnterText(By locator, TimeSpan timeToWait, string textToEnter)
        {
            GetElement(locator, timeToWait).SendKeys(textToEnter);
        }
        public void Click(By locator, TimeSpan timeToWait)
        {
            GetElement(locator, timeToWait).Click();
        }

        public IWebElement GetElement(By locator, TimeSpan timeToWait)
        {
            return WaitHelper.WaitForElementPresent(Driver, locator, timeToWait);
        }

        public IReadOnlyCollection<IWebElement> GetElements(By locator, TimeSpan timeToWait)
        {
            return WaitHelper.WaitForElementsPresent(Driver, locator, timeToWait);

        }
        public IWebElement FindVisibleElement(By locator, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitHelper.WaitForElementPresent(Driver, locator, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitHelper.WaitForElementPresent(Driver, locator, timeout);
            }
            return elem;
        }

        public string GetTitle()
        {
            return Driver.Title;
        }

        protected IWebDriver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
    }
}