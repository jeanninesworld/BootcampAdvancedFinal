using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace BootcampAdvancedFinal
{
    public class HomePage : BaseTest
    {
        public HomePage(IWebDriver _driver, IWebDriver fireFox, IWebDriver edgeDriver) : base(_driver, fireFox, edgeDriver) { }

        By myAccountLabel = By.XPath("//h1[@class='page-heading']");
        By signIn = By.XPath("//a[@class='login']");
        By signOut = By.XPath("//a[@class='logout']");
        By emailAddress = By.XPath("//input[@id='email']");
        By password = By.XPath("//input[@id='passwd']");
        By signInBtn = By.XPath("//button[@id='SubmitLogin']");
        By accountOptions = By.XPath("//div[@class='row addresses-lists']");
        By authenticationScreen = By.XPath("//h1[@class='page-heading']");


        public String GetViewLabelChrome()
        {
            IWebElement page = driver.FindElement(myAccountLabel);
            return page.Text;
        }
        public String GetViewLabelFireFox()
        {
            IWebElement page = fireFox.FindElement(myAccountLabel);
            return page.Text;
        }
        public String GetViewLabelEdge()
        {
            IWebElement page = edgeDriver.FindElement(myAccountLabel);
            return page.Text;
        }
        public HomePage ClickAccountLoginChrome()
        {
            ClickChrome(signIn, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage ClickAccountLoginFireFox()
        {
            ClickFireFox(signIn, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage ClickAccountLoginEdge()
        {
            ClickEdge(signIn, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage EnterEmailAddressChrome(String text)
        {
            ClickChrome(emailAddress, TimeSpan.FromSeconds(60));
            EnterTextChrome(emailAddress, text, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage EnterEmailAddressFireFox(String text)
        {
            ClickFireFox(emailAddress, TimeSpan.FromSeconds(60));
            EnterTextFireFox(emailAddress, text, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage EnterEmailAddressEdge(String text)
        {
            ClickEdge(emailAddress, TimeSpan.FromSeconds(60));
            EnterTextEdge(emailAddress, text, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage EnterPasswordChrome(String text)
        {
            ClickChrome(password, TimeSpan.FromSeconds(60));
            EnterTextChrome(password, text, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage EnterPasswordAddressFireFox(String text)
        {
            ClickFireFox(password, TimeSpan.FromSeconds(60));
            EnterTextFireFox(password, text, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage EnterPasswordAddressEdge(String text)
        {
            ClickEdge(password, TimeSpan.FromSeconds(60));
            EnterTextEdge(password, text, TimeSpan.FromSeconds(60));
            return this;
        }


        public HomePage ClickSignInBtnChrome()
        {
            ClickChrome(signInBtn, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage ClickSignInBtnFireFox()
        {
            ClickFireFox(signInBtn, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage ClickSignInBtnEdge()
        {
            ClickEdge(signInBtn, TimeSpan.FromSeconds(60));
            return this;
        }

        public String VerifyAccountOptionsChrome()
        {
            IWebElement page = driver.FindElement(accountOptions);
            return page.Text;
        }
        public String VerifyAccountOptionsFireFox()
        {
            IWebElement page = fireFox.FindElement(accountOptions);
            return page.Text;
        }
        public String VerifyAccountOptionsEdge()
        {
            IWebElement page = edgeDriver.FindElement(accountOptions);
            return page.Text;
        }
        public HomePage ClickAccountLogOutChrome()
        {
            ClickChrome(signOut, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage ClickAccountLogOutFireFox()
        {
            ClickFireFox(signOut, TimeSpan.FromSeconds(60));
            return this;
        }
        public HomePage ClickAccountLogOutEdge()
        {
            ClickEdge(signOut, TimeSpan.FromSeconds(60));
            return this;
        }
        public String VerifyLoggedOutChrome()
        {
            IWebElement page = driver.FindElement(authenticationScreen);
            return page.Text;
        }
        public String VerifyLoggedOutFireFox()
        {
            IWebElement page = fireFox.FindElement(authenticationScreen);
            return page.Text;
        }
        public String VerifyLoggedOutEdge()
        {
            IWebElement page = edgeDriver.FindElement(authenticationScreen);
            return page.Text;
        }
    }
}