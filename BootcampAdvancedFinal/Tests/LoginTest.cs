using BootcampAdvancedFinal.Pages;
using FluentAssertions;
using NUnit.Framework;

namespace BootcampAdvancedFinal.Tests
{

    [TestFixture]

    public class LogInAndOutTest : TestSetup

    {
        HomePage homePage;
        static string chromeUrl = "http://automationpractice.com/index.php";
        static string fireFoxUrl = "http://automationpractice.com/index.php";    
        static string edgeDriverUrl = "http://automationpractice.com/index.php";

        [SetUp]
        public void Init()
        {
            homePage = new HomePage(this.driver, this.fireFox, this.edgeDriver);            
        }

        [Test(Description = "Login and Logout Verification")]
        [TestCase(TestName = "Validate Login & Logout ")]
        public void LoginAndLogout()
        {
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

    }
}