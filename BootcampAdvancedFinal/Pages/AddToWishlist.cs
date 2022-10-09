using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampAdvancedFinal
{
    public class AddToWishlist : BaseTest
    {
        public AddToWishlist(IWebDriver _driver, IWebDriver fireFox, IWebDriver edgeDriver) : base(_driver, fireFox, edgeDriver) { }

        By printedDress = By.XPath("//a[@class='product-name'][@xpath='1']//parent::h5");
        By addToWishlistBtn = By.XPath("//a[@id='wishlist_button']");
        By myStore = By.XPath("//a[@title='My Store']");
        By fancyError = By.XPath("//p[@class='fancybox-error']");
        By fancyErrorClose = By.XPath("//a[@class='fancybox-item fancybox-close']");
        By myAccount = By.XPath("//a[@title='View my customer account']");
        By myWishList = By.XPath("//span[text()='My wishlists']");
        By dressesCategory = By.XPath("(//a[@title='Dresses'][normalize-space()='Dresses'])[2]");
        By chifonDress = By.XPath("//div[@class='product-image-container']//a[@title='Printed Chiffon Dress']");
        By chifonDressFF = By.XPath("//h5[@itemprop='name']//a[@title='Printed Chiffon Dress']");
        By viewMyWishlist = By.XPath("//a[normalize-space()='View']");
        By wishlistDetails = By.XPath("//div[@class='product_infos']");

        //Chrome Methods
        public AddToWishlist SelectDressesCategoryChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, dressesCategory, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectWomensChifonDressChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, chifonDress, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectAddToWishlistChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, addToWishlistBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectMyStoreChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, myStore, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyFancyErrorChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, fancyError, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public AddToWishlist CloseFancyErrorChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, fancyErrorClose, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectViewMyAccountChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, myAccount, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectMyWishlistChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, myWishList, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectViewMyWishlistChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, viewMyWishlist, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyWishlistDetailsChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, wishlistDetails, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        //FireFox Methods
        public AddToWishlist SelectDressesCategoryFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, dressesCategory, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectWomensChifonDressFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, chifonDressFF, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectAddToWishlistFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, addToWishlistBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectMyStoreFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, myStore, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyFancyErrorFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(fireFox, fancyError, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public AddToWishlist CloseFancyErrorFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, fancyErrorClose, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectViewMyAccountFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, myAccount, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectMyWishlistFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, myWishList, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectViewMyWishlistFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, viewMyWishlist, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyWishlistDetailsFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(fireFox, wishlistDetails, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        //Edge Methods
        public AddToWishlist SelectDressesCategoryEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, dressesCategory, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectWomensChifonDressEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, chifonDress, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectAddToWishlistEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, addToWishlistBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectMyStoreEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, myStore, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyFancyErrorEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, fancyError, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public AddToWishlist CloseFancyErrorEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, fancyErrorClose, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectViewMyAccountEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, myAccount, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectMyWishlistEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, myWishList, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public AddToWishlist SelectViewMyWishlistEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, viewMyWishlist, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyWishlistDetailsEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, wishlistDetails, TimeSpan.FromSeconds(30));
            return page.Text;
        }
    }
}