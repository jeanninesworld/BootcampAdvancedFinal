using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace BootcampAdvancedFinal
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }
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
            WaitHelper.WaitForElementPresent(Driver, acctLoginBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public HomePage EnterEmail(String text)
        {
            GetElement(emailAddress, TimeSpan.FromSeconds(8)).SendKeys(text);
            return this;
        }
        public HomePage EnterPassword(String text)
        {
            GetElement(password, TimeSpan.FromSeconds(8)).SendKeys(text);
            return this;
        }
        public HomePage ClickLogin()
        {
            Thread.Sleep(6000);
            WaitHelper.WaitForElementPresent(Driver, loginBtn, TimeSpan.FromSeconds(30)).Click();
            if (WaitHelper.WaitForElementPresent(Driver, invalidEmail, TimeSpan.FromSeconds(8)).Displayed == true)
                WaitHelper.WaitForElementPresent(Driver, notACustomer, TimeSpan.FromSeconds(30)).Click();
            else
                return this;
            return this;
        }
        public HomePage ClickYourBasket()
        {
            WaitHelper.WaitForElementPresent(Driver, yourBasketBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String GetViewLabel()
        {
            return FindVisibleElement(viewLabel, TimeSpan.FromSeconds(8)).Text;
        }
    }
}