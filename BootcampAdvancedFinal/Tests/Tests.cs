using BootcampAdvancedFinal.Pages;
using FluentAssertions;
using NUnit.Framework;

namespace BootcampAdvancedFinal.Tests
{

    [TestFixture]

    public class Tests : TestSetup

    {
        HomePage homePage;
        SearchPage searchPage;
        ContactUsPage contactUsPage;
        CartPage cartPage;
        AddToWishlist addToWishlist;

        static string chromeUrl = "http://automationpractice.com/index.php";
        static string fireFoxUrl = "http://automationpractice.com/index.php";    
        static string edgeDriverUrl = "http://automationpractice.com/index.php";

        [SetUp]
        public void Init()
        {
            homePage = new HomePage(this.driver, this.fireFox, this.edgeDriver);
            searchPage = new SearchPage(this.driver, this.fireFox, this.edgeDriver);
            contactUsPage = new ContactUsPage(this.driver, this.fireFox, this.edgeDriver);
            cartPage = new CartPage(this.driver, this.fireFox, this.edgeDriver);
            addToWishlist = new AddToWishlist(this.driver, this.fireFox, this.edgeDriver);

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
        [TestCase(TestName = "ValidateLogin&Logout ")]
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
        [TestCase(TestName = "ValidateSearch")]
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
        [TestCase(TestName = "ValidateCustomerServiceMessage")]
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

        [Test(Description = "Add different quantities of products to the cart from each category ")]
        [TestCase(TestName = "ValidateAdd/EditCart")]
        public void AddEditCartVerification()
        {

            //Chrome
            cartPage.SelectWomensTopsCategoryChrome();
            cartPage.VerifyTopsCategoryChrome().Contains("Tops");
            cartPage.SelectWomensBlouseTopSizeColorChrome();
            cartPage.AddToCartChrome();
            cartPage.VerifySuccessMessageChrome().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingChrome();

            cartPage.SelectDressesCategoryChrome();
            cartPage.VerifyDressesCategoryChrome().Contains("Dresses");
            cartPage.SelectWomensDressSizeColorChrome();
            cartPage.AddToCartChrome();
            cartPage.VerifySuccessMessageChrome().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingChrome();

            cartPage.SelectTShirtsCategoryChrome();
            cartPage.VerifyTShirtsCategoryChrome().Contains("Dresses");
            cartPage.SelectTShirtsSizeColorChrome();
            cartPage.AddToCartChrome();
            cartPage.VerifySuccessMessageChrome().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingChrome();

            cartPage.ClickCartChrome();
            cartPage.VerifyShoppingCartChrome().Should().Contain("Your shopping cart contains: 7 Products");

            cartPage.VerifyChifonSizeColorDetailsChrome().Should().Be("Printed Chiffon Dress\r\nSKU : demo_7\r\nColor : Green, Size : M");
            cartPage.VerifyTShirtSizeColorDetailsChrome().Should().Be("Faded Short Sleeve T-shirts\r\nSKU : demo_1\r\nColor : Blue, Size : M");
            cartPage.VerifyBlouseSizeColorDetailsChrome().Should().Be("Blouse\r\nSKU : demo_2\r\nColor : White, Size : M");

            cartPage.AddQuantityChifonDressChrome();
            cartPage.VerifyShoppingCartChrome().Should().Contain("Your shopping cart contains: 8 Products");

            cartPage.MinusQuantityTShirtChrome();
            cartPage.VerifyShoppingCartChrome().Should().Contain("Your shopping cart contains: 7 Products");

            //firefox
            cartPage.SelectWomensTopsCategoryFireFox();
            cartPage.VerifyTopsCategoryFireFox().Contains("Tops");
    
            cartPage.SelectWomensBlouseTopSizeColorFireFox();
            cartPage.AddToCartFireFox();
            cartPage.VerifySuccessMessageFireFox().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingFireFox();

            cartPage.SelectDressesCategoryFireFox();
            cartPage.VerifyDressesCategoryFireFox().Contains("Dresses");
            cartPage.SelectWomensDressSizeColorFireFox();
            cartPage.AddToCartFireFox();
            cartPage.VerifySuccessMessageFireFox().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingFireFox();

            cartPage.SelectTShirtsCategoryFireFox();
            cartPage.VerifyTShirtsCategoryFireFox().Contains("Dresses");
            cartPage.SelectTShirtsSizeColorFireFox();
            cartPage.AddToCartFireFox();
            cartPage.VerifySuccessMessageFireFox().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingFireFox();

            cartPage.ClickCartFireFox();
            cartPage.VerifyShoppingCartFireFox().Should().Contain("Your shopping cart contains: 7 Products");

            cartPage.VerifyChifonSizeColorDetailsFireFox().Should().Be("Printed Chiffon Dress\r\nSKU : demo_7\r\nColor : Green, Size : M");
            cartPage.VerifyTShirtSizeColorDetailsFireFox().Should().Be("Faded Short Sleeve T-shirts\r\nSKU : demo_1\r\nColor : Blue, Size : M");
            cartPage.VerifyBlouseSizeColorDetailsFireFox().Should().Be("Blouse\r\nSKU : demo_2\r\nColor : White, Size : M");

            cartPage.AddQuantityChifonDressFireFox();
            cartPage.VerifyShoppingCartFireFox().Should().Contain("Your shopping cart contains: 8 Products");

            cartPage.MinusQuantityTShirtFireFox();
            cartPage.VerifyShoppingCartFireFox().Should().Contain("Your shopping cart contains: 7 Products");

            //Edge
            cartPage.SelectWomensTopsCategoryEdge();
            cartPage.VerifyTopsCategoryEdge().Contains("Tops");
            cartPage.SelectWomensBlouseTopSizeColorEdge();
            cartPage.AddToCartEdge();
            cartPage.VerifySuccessMessageEdge().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingEdge();

            cartPage.SelectDressesCategoryEdge();
            cartPage.VerifyDressesCategoryEdge().Contains("Dresses");
            cartPage.SelectWomensDressSizeColorEdge();
            cartPage.AddToCartEdge();
            cartPage.VerifySuccessMessageEdge().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingEdge();

            cartPage.SelectTShirtsCategoryEdge();
            cartPage.VerifyTShirtsCategoryEdge().Contains("Dresses");
            cartPage.SelectTShirtsSizeColorEdge();
            cartPage.AddToCartEdge();
            cartPage.VerifySuccessMessageEdge().Should().Be("Product successfully added to your shopping cart");
            cartPage.ClickContinueShoppingEdge();

            cartPage.ClickCartEdge();
            cartPage.VerifyShoppingCartEdge().Should().Contain("Your shopping cart contains: 7 Products");

            cartPage.VerifyChifonSizeColorDetailsEdge().Should().Be("Printed Chiffon Dress\r\nSKU : demo_7\r\nColor : Green, Size : M");
            cartPage.VerifyTShirtSizeColorDetailsEdge().Should().Be("Faded Short Sleeve T-shirts\r\nSKU : demo_1\r\nColor : Blue, Size : M");
            cartPage.VerifyBlouseSizeColorDetailsEdge().Should().Be("Blouse\r\nSKU : demo_2\r\nColor : White, Size : M");

            cartPage.AddQuantityChifonDressEdge();
            cartPage.VerifyShoppingCartEdge().Should().Contain("Your shopping cart contains: 8 Products");

            cartPage.MinusQuantityTShirtEdge();
            cartPage.VerifyShoppingCartEdge().Should().Contain("Your shopping cart contains: 7 Products");
        }

        [Test(Description = "Add to Wishlist Verification")]
        [TestCase(TestName = "ValidateAddToWishList")]
        public void WishListVerification()
        {
            LoginToMyAccount();

            //chrome
            addToWishlist.SelectDressesCategoryChrome();
            addToWishlist.SelectWomensChifonDressChrome();
            addToWishlist.SelectAddToWishlistChrome();
            addToWishlist.VerifyFancyErrorChrome().Should().Be("Added to your wishlist.");
            addToWishlist.CloseFancyErrorChrome();
            addToWishlist.SelectViewMyAccountChrome();
            addToWishlist.SelectMyWishlistChrome();
            addToWishlist.SelectViewMyWishlistChrome();
            addToWishlist.VerifyWishlistDetailsChrome().Should().Contain("Printed Chiffon Dress\r\nS, Yellow");
           
            //FireFox
            addToWishlist.SelectDressesCategoryFireFox();
            addToWishlist.SelectWomensChifonDressFireFox();
            addToWishlist.SelectAddToWishlistFireFox();
            addToWishlist.VerifyFancyErrorFireFox().Should().Be("Added to your wishlist.");
            addToWishlist.CloseFancyErrorFireFox();
            addToWishlist.SelectViewMyAccountFireFox();
            addToWishlist.SelectMyWishlistFireFox();
            addToWishlist.SelectViewMyWishlistFireFox();
            addToWishlist.VerifyWishlistDetailsFireFox().Should().Contain("Printed Chiffon Dress");

            //Edge
            addToWishlist.SelectDressesCategoryEdge();
            addToWishlist.SelectWomensChifonDressEdge();
            addToWishlist.SelectAddToWishlistEdge();
            addToWishlist.VerifyFancyErrorEdge().Should().Be("Added to your wishlist.");
            addToWishlist.CloseFancyErrorEdge();
            addToWishlist.SelectViewMyAccountEdge();
            addToWishlist.SelectMyWishlistEdge();
            addToWishlist.SelectViewMyWishlistEdge();
            addToWishlist.VerifyWishlistDetailsEdge().Should().Contain("Printed Chiffon Dress");
        }

    }
}