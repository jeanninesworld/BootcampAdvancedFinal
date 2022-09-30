using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace BootcampAdvancedFinal
{
    public class SearchPage : BaseTest
    {
        public SearchPage(IWebDriver _driver, IWebDriver fireFox, IWebDriver edgeDriver) : base(_driver, fireFox, edgeDriver) { }

        By searchBox = By.XPath("//input[@name='search_query']");
        By searchBtn = By.XPath("//button[@name='submit_search']");
        By productList = By.XPath("//ul[@class='product_list grid row']");

        public SearchPage SearchBlouseChrome(String text)
        {
            ClickChrome(searchBox, TimeSpan.FromSeconds(30));
            EnterTextChrome(searchBox, text, TimeSpan.FromSeconds(30));
            ClickChrome(searchBtn, TimeSpan.FromSeconds(30));
            return this;
        }
        public SearchPage SearchBlouseFireFox(String text)
        {
            ClickFireFox(searchBox, TimeSpan.FromSeconds(30));
            EnterTextFireFox(searchBox, text, TimeSpan.FromSeconds(30));
            ClickFireFox(searchBtn, TimeSpan.FromSeconds(30));
            return this;
        }
        public SearchPage SearchBlouseEdge(String text)
        {
            ClickEdge(searchBox, TimeSpan.FromSeconds(30));
            EnterTextEdge(searchBox, text, TimeSpan.FromSeconds(30));
            ClickEdge(searchBtn, TimeSpan.FromSeconds(30));
            return this;
        }
        public String VerifySearchReturnedChrome()
        {
            IWebElement page = driver.FindElement(productList);
            return page.Text;
        }
        public String VerifySearchReturnedFireFox()
        {
            IWebElement page = fireFox.FindElement(productList);
            return page.Text;
        }
        public String VerifySearchReturnedEdge()
        {
            IWebElement page = edgeDriver.FindElement(productList);
            return page.Text;
        }
    }
}