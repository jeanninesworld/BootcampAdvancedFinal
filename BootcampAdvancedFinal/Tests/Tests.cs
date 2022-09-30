using BootcampAdvancedFinal.Pages;
using FluentAssertions;
using NUnit.Framework;

namespace BootcampAdvancedFinal.Tests
{

    [TestFixture]

    public class LogInAndOutTest : TestSetup

    {
        HomePage homePage;
        SearchPage searchPage;
        ContactUsPage contactUsPage;
        static string chromeUrl = "http://automationpractice.com/index.php";
        static string fireFoxUrl = "http://automationpractice.com/index.php";    
        static string edgeDriverUrl = "http://automationpractice.com/index.php";

        [SetUp]
        public void Init()
        {
            homePage = new HomePage(this.driver, this.fireFox, this.edgeDriver);
            searchPage = new SearchPage(this.driver, this.fireFox, this.edgeDriver);
            contactUsPage = new ContactUsPage(this.driver, this.fireFox, this.edgeDriver);

            driver.Navigate().GoToUrl(chromeUrl);
            fireFox.Navigate().GoToUrl(fireFoxUrl);
            edgeDriver.Navigate().GoToUrl(edgeDriverUrl);

            homePage.GetChromeTitle().Should().Be("My Store");
            homePage.GetFireFoxTitle().Should().Be("My Store");
            homePage.GetEdgeTitle().Should().Be("My Store");

            homePage.ClickAccountLoginChrome();
            homePage.ClickAccountLoginFireFox();
            homePage.ClickAccountLoginEdge();

            homePage.EnterEmailAddressChrome("jeanninesworld9@gmail.com");
            homePage.EnterEmailAddressFireFox("jeanninesworld9@gmail.com");
            homePage.EnterEmailAddressEdge("jeanninesworld9@gmail.com");

            homePage.EnterPasswordChrome("Password");
            homePage.EnterPasswordAddressFireFox("Password");
            homePage.EnterPasswordAddressEdge("Password");

            homePage.ClickSignInBtnChrome();
            homePage.ClickSignInBtnFireFox();
            homePage.ClickSignInBtnEdge();
        }

        [Test(Description = "Login and Logout Verification")]
        [TestCase(TestName = "Validate Login & Logout ")]
        public void LoginAndLogout()
        {
            homePage.GetViewLabelChrome().Should().Be("MY ACCOUNT");
            homePage.GetViewLabelFireFox().Should().Be("MY ACCOUNT");
            homePage.GetViewLabelEdge().Should().Be("MY ACCOUNT");

            homePage.VerifyAccountOptionsChrome().Should().Be("ORDER HISTORY AND DETAILS\r\nMY CREDIT SLIPS\r\nMY ADDRESSES\r\nMY PERSONAL INFORMATION\r\nMY WISHLISTS");
            homePage.VerifyAccountOptionsFireFox().Should().Be("ORDER HISTORY AND DETAILS\r\nMY CREDIT SLIPS\r\nMY ADDRESSES\r\nMY PERSONAL INFORMATION\r\nMY WISHLISTS");
            homePage.VerifyAccountOptionsEdge().Should().Be("ORDER HISTORY AND DETAILS\r\nMY CREDIT SLIPS\r\nMY ADDRESSES\r\nMY PERSONAL INFORMATION\r\nMY WISHLISTS");

            homePage.ClickAccountLogOutChrome();
            homePage.ClickAccountLogOutFireFox();
            homePage.ClickAccountLogOutEdge();

            homePage.VerifyLoggedOutChrome().Should().Be("AUTHENTICATION");
            homePage.VerifyLoggedOutFireFox().Should().Be("AUTHENTICATION");
            homePage.VerifyLoggedOutEdge().Should().Be("AUTHENTICATION");
        }

        [Test(Description = "Search Functionality")]
        [TestCase(TestName = "Validate Search functionality works")]
        public void SearchFunctionality()
        {
            searchPage.SearchBlouseChrome("Blouse");
            searchPage.SearchBlouseFireFox("Blouse");
            searchPage.SearchBlouseEdge("Blouse");

            searchPage.VerifySearchReturnedChrome().Should().Contain("Blouse");
            searchPage.VerifySearchReturnedFireFox().Should().Contain("Blouse");
            searchPage.VerifySearchReturnedEdge().Should().Contain("Blouse");
        }

        [Test(Description = "Validate ability to send message to customer service ")]
        [TestCase(TestName = "Validate message to customer service")]
        public void MessageToCustomerService()
        {
            contactUsPage.ClickContactUsChrome();
            contactUsPage.ClickContactUsFireFox();
            contactUsPage.ClickContactUsEdge();

            contactUsPage.VerifyViewLabelChrome().Should().Be("CUSTOMER SERVICE - CONTACT US");
            contactUsPage.VerifyViewLabelFireFox().Should().Be("CUSTOMER SERVICE - CONTACT US");
            contactUsPage.VerifyViewLabelEdge().Should().Be("CUSTOMER SERVICE - CONTACT US");

            contactUsPage.SelectSubjectChrome();
            contactUsPage.SelectSubjectFireFox();
            contactUsPage.SelectSubjectEdge();

            contactUsPage.EnterMessageChrome("Test Message to customer service");
            contactUsPage.EnterMessageFireFox("Test Message to customer service");
            contactUsPage.EnterMessageEdge("Test Message to customer service");

            contactUsPage.ClickSendChrome();
            contactUsPage.ClickSendFireFox();
            contactUsPage.ClickSendEdge();

            contactUsPage.VerifySuccessMessageChrome().Should().Be("Your message has been successfully sent to our team.");
            contactUsPage.VerifySuccessMessageFireFox().Should().Be("Your message has been successfully sent to our team.");
            contactUsPage.VerifySuccessMessageEdge().Should().Be("Your message has been successfully sent to our team.");
        }

    }
}