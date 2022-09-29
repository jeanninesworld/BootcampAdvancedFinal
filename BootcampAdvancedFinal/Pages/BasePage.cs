using BootcampAdvancedFinal.DriverFactory;
using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BootcampAdvancedFinal
{
    public class BasePage
    {
        public IWebDriver driver;
        public IWebDriver fireFox;
        public IWebDriver edgeDriver;

        public BasePage(IWebDriver driver, IWebDriver fireFox, IWebDriver edgeDriver)
        {
            this.driver = driver;
            this.fireFox = fireFox;
            this.edgeDriver = edgeDriver;
        }

        public string GetChromeTitle()
        {
            string title = driver.Title;
            return driver.Title;
        }
        public string GetFireFoxTitle()
        {
            string title = fireFox.Title;
            return fireFox.Title;
        }
        public string GetEdgeTitle()
        {
            string title = edgeDriver.Title;
            return edgeDriver.Title;
        }
        public IWebElement FindVisibleElement(By locator, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
            }

            return elem;
        }
        public IWebElement FindElement(By locator, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementPresent(driver, locator, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementPresent(driver, locator, timeout);
            }

            return elem;
        }
        public void EnterTextChrome(By locator, String text, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                elem.Clear();
                elem.SendKeys(text);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                elem.Clear();
                elem.SendKeys(text);
            }

        }
        public void EnterTextFireFox(By locator, String text, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(fireFox, locator, timeout);
                elem.Clear();
                elem.SendKeys(text);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(fireFox, locator, timeout);
                elem.Clear();
                elem.SendKeys(text);
            }

        }
        public void EnterTextEdge(By locator, String text, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(edgeDriver, locator, timeout);
                elem.Clear();
                elem.SendKeys(text);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(edgeDriver, locator, timeout);
                elem.Clear();
                elem.SendKeys(text);
            }

        }
        public void ClickChrome(By locator, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                elem.Click();
            }
            catch (ElementNotInteractableException)
            {
                JavaScriptClick(locator, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                elem.Click();
            }

        }
        public void ClickFireFox(By locator, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(fireFox, locator, timeout);
                elem.Click();
            }
            catch (ElementNotInteractableException)
            {
                JavaScriptClick(locator, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(fireFox, locator, timeout);
                elem.Click();
            }

        }
        public void ClickEdge(By locator, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(edgeDriver, locator, timeout);
                elem.Click();
            }
            catch (ElementNotInteractableException)
            {
                JavaScriptClick(locator, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(edgeDriver, locator, timeout);
                elem.Click();
            }

        }
        public void SelectDropDown(By locator, String optionText, TimeSpan timeout)
        {
            SelectElement oSelect = null;
            try
            {
                oSelect = WaitUtils.WaitForDropDownPopulated(driver, locator, timeout);
                oSelect.SelectByText(optionText);
            }
            catch (StaleElementReferenceException)
            {
                oSelect = WaitUtils.WaitForDropDownPopulated(driver, locator, timeout);
                oSelect.SelectByText(optionText);
            }
            
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator, TimeSpan timeout)
        {
            ReadOnlyCollection<IWebElement> elems = null;
            try
            {
                elems = WaitUtils.WaitForElementsPresent(driver, locator, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elems = WaitUtils.WaitForElementsPresent(driver, locator, timeout);
            }
            
            return elems;
        }
        public ReadOnlyCollection<IWebElement> FindVisibleElements(By locator, TimeSpan timeout)
        {
            ReadOnlyCollection<IWebElement> elems = null;
            try
            {
                elems = WaitUtils.WaitForElementsVisible(driver, locator, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elems = WaitUtils.WaitForElementsVisible(driver, locator, timeout);
            }
            
            return elems;
        }
  
        
        public void ClickAndWaitForElementDisplayed(By locator, By targetedLocator, int numOfAttempts, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                for (int i = 0; i <= numOfAttempts; i++)
                {
                    elem.Click();
                    if (WaitUtils.IsElementVisible(driver, targetedLocator, timeout) == true)
                        break;
                }
            }
            catch (ElementNotInteractableException)
            {
                JavaScriptClickForElementDisplayed(locator, targetedLocator, numOfAttempts, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                for (int i = 0; i <= numOfAttempts; i++)
                {
                    elem.Click();
                    if (WaitUtils.IsElementVisible(driver, targetedLocator, timeout) == true)
                        break;
                }
            }

        }
        public void ClickAndWaitForElementPresent(By locator, By targetedLocator, int numOfAttempts, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                for (int i = 0; i <= numOfAttempts; i++)
                {
                    elem.Click();
                    if (WaitUtils.IsElementPresent(driver, targetedLocator, timeout) == true)
                        break;
                }
            }
            catch (ElementNotInteractableException)
            {
                JavaScriptClickForElementPresent(locator, targetedLocator, numOfAttempts, timeout);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                for (int i = 0; i <= numOfAttempts; i++)
                {
                    elem.Click();
                    if (WaitUtils.IsElementPresent(driver, targetedLocator, timeout) == true)
                        break;
                }
            }

        }
        public void JavaScriptClick(By locator, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("arguments[0].click()", elem);
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("arguments[0].click()", elem);
            }

        }
        public void JavaScriptClickForElementDisplayed(By locator, By targetedLocator, int numOfAttempts, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                for (int i = 0; i <= numOfAttempts; i++)
                {
                    IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                    jsExecutor.ExecuteScript("arguments[0].click()", elem);
                    if (WaitUtils.IsElementVisible(driver, targetedLocator, timeout) == true)
                        break;
                }
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                for (int i = 0; i <= numOfAttempts; i++)
                {
                    IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                    jsExecutor.ExecuteScript("arguments[0].click()", elem);
                    if (WaitUtils.IsElementVisible(driver, targetedLocator, timeout) == true)
                        break;
                }
            }

        }
        public void JavaScriptClickForElementPresent(By locator, By targetedLocator, int numOfAttempts, TimeSpan timeout)
        {
            IWebElement elem = null;
            try
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                for (int i = 0; i <= numOfAttempts; i++)
                {
                    IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                    jsExecutor.ExecuteScript("arguments[0].click()", elem);
                    if (WaitUtils.IsElementPresent(driver, targetedLocator, timeout) == true)
                        break;
                }
            }
            catch (StaleElementReferenceException)
            {
                elem = WaitUtils.WaitForElementDisplayed(driver, locator, timeout);
                for (int i = 0; i <= numOfAttempts; i++)
                {
                    IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                    jsExecutor.ExecuteScript("arguments[0].click()", elem);
                    if (WaitUtils.IsElementPresent(driver, targetedLocator, timeout) == true)
                        break;
                }
            }
        }
    }
}