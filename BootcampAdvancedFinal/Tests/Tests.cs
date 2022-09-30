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
        }

        public void LoginToMyAccount()
        {
            //chrome
            homePage.GetChromeTitle().Should().Be("My Store");
            homePage.ClickAccountLoginChrome();
            homePage.EnterEmailAddressChrome("jeanninesworld9@gmail.com");
            homePage.EnterPasswordChrome("Password");
            homePage.ClickSignInBtnChrome();

            //firefox
            homePage.GetFireFoxTitle().Should().Be("My Store");
            homePage.ClickAccountLoginFireFox();
            homePage.EnterEmailAddressFireFox("jeanninesworld9@gmail.com");
            homePage.EnterPasswordAddressFireFox("Password");
            homePage.ClickSignInBtnFireFox();

            //edge
            homePage.GetEdgeTitle().Should().Be("My Store");          
            homePage.ClickAccountLoginEdge();          
            homePage.EnterEmailAddressEdge("jeanninesworld9@gmail.com");           
            homePage.EnterPasswordAddressEdge("Password");
            homePage.ClickSignInBtnEdge();
        }

        [Test(Description = "Login and Logout Verification")]
        [TestCase(TestName = "Validate Login & Logout ")]
        public void LoginAndLogoutTests()
        {
            LoginToMyAccount();

            //chrome
            homePage.GetViewLabelChrome().Should().Be("MY ACCOUNT");
            homePage.VerifyAccountOptionsChrome().Should().Be("ORDER HISTORY AND DETAILS\r\nMY CREDIT SLIPS\r\nMY ADDRESSES\r\nMY PERSONAL INFORMATION\r\nMY WISHLISTS");
            homePage.ClickAccountLogOutChrome();
            homePage.VerifyLoggedOutChrome().Should().Be("AUTHENTICATION");

            //firefox
            homePage.GetViewLabelFireFox().Should().Be("MY ACCOUNT");
            homePage.VerifyAccountOptionsFireFox().Should().Be("ORDER HISTORY AND DETAILS\r\nMY CREDIT SLIPS\r\nMY ADDRESSES\r\nMY PERSONAL INFORMATION\r\nMY WISHLISTS");
            homePage.ClickAccountLogOutFireFox();
            homePage.VerifyLoggedOutFireFox().Should().Be("AUTHENTICATION");

            //edge
            homePage.GetViewLabelEdge().Should().Be("MY ACCOUNT");
            homePage.VerifyAccountOptionsEdge().Should().Be("ORDER HISTORY AND DETAILS\r\nMY CREDIT SLIPS\r\nMY ADDRESSES\r\nMY PERSONAL INFORMATION\r\nMY WISHLISTS");
            homePage.ClickAccountLogOutEdge();
            homePage.VerifyLoggedOutEdge().Should().Be("AUTHENTICATION");
        }

        [Test(Description = "Search Functionality")]
        [TestCase(TestName = "Validate Search functionality works")]
        public void SearchFunctionality()
        {
            //chrome
            searchPage.SearchBlouseChrome("Blouse");         
            searchPage.VerifySearchReturnedChrome().Should().Contain("Blouse");

            //firefox
            searchPage.SearchBlouseFireFox("Blouse");
            searchPage.VerifySearchReturnedFireFox().Should().Contain("Blouse");

            //edge
            searchPage.SearchBlouseEdge("Blouse");            
            searchPage.VerifySearchReturnedEdge().Should().Contain("Blouse");
        }

        [Test(Description = "Validate ability to send message to customer service ")]
        [TestCase(TestName = "Validate message to customer service")]
        public void MessageToCustomerService()
        {
            LoginToMyAccount();

            //Chrome
            contactUsPage.ClickContactUsChrome();
            contactUsPage.VerifyViewLabelChrome().Should().Be("CUSTOMER SERVICE - CONTACT US");
            contactUsPage.SelectSubjectChrome();
            contactUsPage.EnterMessageChrome("Test Message to customer service");
            contactUsPage.ClickSendChrome();
            contactUsPage.VerifySuccessMessageChrome().Should().Be("Your message has been successfully sent to our team.");
        
            //firefox
            contactUsPage.ClickContactUsFireFox();
            contactUsPage.VerifyViewLabelFireFox().Should().Be("CUSTOMER SERVICE - CONTACT US");
            contactUsPage.SelectSubjectFireFox();
            contactUsPage.EnterMessageFireFox("Test Message to customer service");
            contactUsPage.ClickSendFireFox();
            contactUsPage.VerifySuccessMessageFireFox().Should().Be("Your message has been successfully sent to our team.");

            //edge
            contactUsPage.ClickContactUsEdge();
            contactUsPage.VerifyViewLabelEdge().Should().Be("CUSTOMER SERVICE - CONTACT US");
            contactUsPage.SelectSubjectEdge();
            contactUsPage.EnterMessageEdge("Test Message to customer service");
            contactUsPage.ClickSendEdge();
            contactUsPage.VerifySuccessMessageEdge().Should().Be("Your message has been successfully sent to our team.");
        }

    }
}