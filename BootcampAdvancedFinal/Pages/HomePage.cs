using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace BootcampAdvancedFinal
{
    public class HomePage : BaseTest
    {
        public HomePage(IWebDriver _driver) : base(_driver) { }

        By MyStore = By.XPath("//*[@alt='My Store']");
        By acctLoginBtn = By.Id("navbarLoginButton");
        By emailAddress = By.Name("email");
        By password = By.Name("password");
        By loginBtn = By.Id("loginButton");
        By yourBasketBtn = By.XPath("//*[@aria-label='Show the shopping cart']");
        By viewLabel = By.XPath("//h1");
        By invalidEmail = By.XPath("//*[@class='error ng-star-inserted']");
        By notACustomer = By.Id("newCustomerLink");
        By regEmail = By.Id("emailControl");
        public HomePage ClickAccountLogin()
        {
            WaitUtils.WaitForElementPresent(driver, acctLoginBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
       
       public String GetViewLabel()
        {
            return FindVisibleElement(viewLabel, TimeSpan.FromSeconds(8)).Text;
        }
    }
}