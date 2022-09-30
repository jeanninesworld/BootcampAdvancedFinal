using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace BootcampAdvancedFinal
{
    public class ContactUsPage : BaseTest
    {
        public ContactUsPage(IWebDriver _driver, IWebDriver fireFox, IWebDriver edgeDriver) : base(_driver, fireFox, edgeDriver) { }

        By contactUsBtn = By.XPath("//div[@id='contact-link']");
        By viewLabel = By.XPath("//h1");
        By subjectHeading = By.XPath("//div[@id='uniform-id_contact']");
        By customerService = By.XPath("//option[@value='2']");
        By messageBody = By.XPath("//textarea[@id='message']");
        By sendBtn = By.XPath("//button[@id='submitMessage']");
        By confirmationMessage = By.XPath("//p[@class='alert alert-success']");

        public ContactUsPage ClickContactUsChrome()
        {
            ClickChrome(contactUsBtn, TimeSpan.FromSeconds(30));            
            return this;
        }
        public ContactUsPage ClickContactUsFireFox()
        {
            ClickFireFox(contactUsBtn, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage ClickContactUsEdge()
        {
            ClickEdge(contactUsBtn, TimeSpan.FromSeconds(30));
            return this;
        }
        public String VerifyViewLabelChrome()
        {
            IWebElement page = driver.FindElement(viewLabel);
            return page.Text;
        }
        public String VerifyViewLabelFireFox()
        {
            IWebElement page = fireFox.FindElement(viewLabel);
            return page.Text;
        }
        public String VerifyViewLabelEdge()
        {
            IWebElement page = edgeDriver.FindElement(viewLabel);
            return page.Text;
        }
        public ContactUsPage SelectSubjectChrome()
        {
            ClickChrome(subjectHeading, TimeSpan.FromSeconds(30));
            ClickChrome(customerService, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage SelectSubjectFireFox()
        {
            ClickFireFox(subjectHeading, TimeSpan.FromSeconds(30));
            ClickFireFox(customerService, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage SelectSubjectEdge()
        {
            ClickEdge(subjectHeading, TimeSpan.FromSeconds(30));
            ClickEdge(customerService, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage EnterMessageChrome(String text)
        {
            ClickChrome(messageBody, TimeSpan.FromSeconds(30));
            EnterTextChrome(messageBody, text, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage EnterMessageFireFox(String text)
        {
            ClickFireFox(messageBody, TimeSpan.FromSeconds(30));
            EnterTextFireFox(messageBody, text, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage EnterMessageEdge(String text)
        {
            ClickEdge(messageBody, TimeSpan.FromSeconds(30));
            EnterTextEdge(messageBody, text, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage ClickSendChrome()
        {
            ClickChrome(sendBtn, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage ClickSendFireFox()
        {
            ClickFireFox(sendBtn, TimeSpan.FromSeconds(30));
            return this;
        }
        public ContactUsPage ClickSendEdge()
        {
            ClickEdge(sendBtn, TimeSpan.FromSeconds(30));
            return this;
        }

        public String VerifySuccessMessageChrome()
        {
            IWebElement page = driver.FindElement(confirmationMessage);
            return page.Text;
        }
        public String VerifySuccessMessageFireFox()
        {
            IWebElement page = fireFox.FindElement(confirmationMessage);
            return page.Text;
        }
        public String VerifySuccessMessageEdge()
        {
            IWebElement page = edgeDriver.FindElement(confirmationMessage);
            return page.Text;
        }
    }
}