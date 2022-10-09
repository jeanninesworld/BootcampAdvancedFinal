using BootcampAdvancedFinal.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace BootcampAdvancedFinal
{
    public class CartPage : BaseTest
    {
        public CartPage(IWebDriver _driver, IWebDriver fireFox, IWebDriver edgeDriver) : base(_driver, fireFox, edgeDriver) { }

        By womenCategory = By.XPath("//a[@title='Women']");
        By dressesCategory = By.XPath("(//a[@title='Dresses'][normalize-space()='Dresses'])[2]");
        By tshirtsCategory = By.XPath("(//a[@title='T-shirts'][normalize-space()='T-shirts'])[2]");
        By womenTops = By.XPath("//div[@class='subcategory-image']//a[@title='Tops']");
        By subCategory = By.XPath("//span[@class='cat-name']");
        By blouseTop = By.XPath("//div[@class='subcategory-image']//a[@title='Blouses']");
        By chifonDress = By.XPath("//div[@class='product-image-container']//a[@title='Printed Chiffon Dress']");
        By chifonDressFF = By.XPath("//h5[@itemprop='name']//a[@title='Printed Chiffon Dress']");
        By fadedTShirt = By.XPath("//div[@class='product-image-container']//a[@title='Faded Short Sleeve T-shirts']");
        By fadedTShirtFF = By.XPath("//h5[@itemprop='name']//a[@title='Faded Short Sleeve T-shirts']");
        By blouseMoreBtn = By.XPath("//*[contains(text(),'More')]");
        By blouseMoreBtnFF = By.XPath("//h5[@itemprop='name']//a[@title='Blouse']");
        By iconPlusBtn = By.XPath("//i[@class='icon-plus']");
        By sizeBtn = By.XPath("//div[@class='attribute_list']//div[@class='selector']");
        By sizeMed = By.XPath("//option[@title='M']");
        By whiteColor = By.XPath("//a[@title='White']");
        By greenColor = By.XPath("//a[@title='Green']");
        By blueColor = By.XPath("//a[@title='Blue']");
        By addToCart = By.XPath("//*[contains(text(),'Add to cart')]");
        By viewLabel1 = By.XPath("//h1");
        By viewLabel2 = By.XPath("//h2");
        By continueShopping = By.XPath("//span[@title='Continue shopping']//child::span");
        By proceedToCheckout = By.XPath("//a[@title='View my shopping cart']");
        By iconPlusBtnChifon = By.XPath("//a[@id='cart_quantity_up_7_38_0_0']");
        By iconMinusBtnTShirt = By.XPath("//a[@id='cart_quantity_down_1_4_0_0']");
        By cartDescriptionChifon = By.XPath("//tr[@id='product_7_38_0_0']//td[@class='cart_description']");
        By cartDescriptionTShirt = By.XPath("//tr[@id='product_1_4_0_0']//td[@class='cart_description']");
        By cartDescriptionBlouse = By.XPath("//tr[@id='product_2_10_0_0']//td[@class='cart_description']");
        By pageId = By.XPath("//body[@id='category']");


        //ChromeMethods
        public CartPage SelectWomensTopsCategoryChrome()
        {
            ClickChrome(womenCategory, TimeSpan.FromSeconds(30));
            ClickChrome(womenTops, TimeSpan.FromSeconds(30));
            Thread.Sleep(5000);
            return this;
        }
        public String VerifyTopsCategoryChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectWomensBlouseTopSizeColorChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, blouseTop, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, blouseMoreBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, whiteColor, TimeSpan.FromSeconds(30)).Click();
            return this;
        }


        //Chrome-SelectDressesCategory

        public CartPage SelectDressesCategoryChrome()
        {            
            WaitUtils.WaitForElementDisplayed(driver, dressesCategory, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyDressesCategoryChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectWomensDressSizeColorChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, chifonDress, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, greenColor, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }

        //Chrome-SelectTShirtCategory

        public CartPage SelectTShirtsCategoryChrome()
        {

            WaitUtils.WaitForElementDisplayed(driver, tshirtsCategory, TimeSpan.FromSeconds(30)).Click();
            //            Thread.Sleep(5000);
            return this;
        }
        public String VerifyTShirtsCategoryChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectTShirtsSizeColorChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, fadedTShirt, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, blueColor, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(driver, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }

        public CartPage AddToCartChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, addToCart, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(5000);
            return this;
        }
        public String VerifySuccessMessageChrome()
        {
            IWebElement page = WaitUtils.WaitForElementDisplayed(driver, viewLabel2, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public CartPage ClickContinueShoppingChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, continueShopping, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public CartPage ClickCartChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, proceedToCheckout, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyShoppingCartChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, viewLabel1, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyBlouseSizeColorDetailsChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, cartDescriptionBlouse, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyChifonSizeColorDetailsChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, cartDescriptionChifon, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyTShirtSizeColorDetailsChrome()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(driver, cartDescriptionTShirt, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public CartPage AddQuantityChifonDressChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, iconPlusBtnChifon, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(5000);
            return this;
        }
        public CartPage MinusQuantityTShirtChrome()
        {
            WaitUtils.WaitForElementDisplayed(driver, iconMinusBtnTShirt, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(3000);
            return this;
        }

        //FirefoxMethods
        public CartPage SelectWomensTopsCategoryFireFox()
        {
            ClickFireFox(womenCategory, TimeSpan.FromSeconds(30));
            ClickFireFox(womenTops, TimeSpan.FromSeconds(30));
            Thread.Sleep(5000);
            return this;
        }
        public String VerifyTopsCategoryFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(fireFox, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectWomensBlouseTopSizeColorFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, blouseTop, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, pageId, TimeSpan.FromSeconds(30)).SendKeys(Keys.PageDown);
            WaitUtils.WaitForElementDisplayed(fireFox, blouseMoreBtnFF, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, whiteColor, TimeSpan.FromSeconds(30)).Click();
            return this;
        }

        //FireFox-SelectDressesCategory

        public CartPage SelectDressesCategoryFireFox()
        {

            WaitUtils.WaitForElementDisplayed(fireFox, dressesCategory, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(5000);
            return this;
        }
        public String VerifyDressesCategoryFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementDisplayed(fireFox, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectWomensDressSizeColorFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, chifonDressFF, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, greenColor, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }

        //FireFox-SelectTShirtCategory

        public CartPage SelectTShirtsCategoryFireFox()
        {

            WaitUtils.WaitForElementDisplayed(fireFox, tshirtsCategory, TimeSpan.FromSeconds(30)).Click();
            //            Thread.Sleep(5000);
            return this;
        }
        public String VerifyTShirtsCategoryFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(fireFox, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectTShirtsSizeColorFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, fadedTShirtFF, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, blueColor, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(fireFox, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }

        public CartPage AddToCartFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, addToCart, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(5000);
            return this;
        }
        public String VerifySuccessMessageFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementDisplayed(fireFox, viewLabel2, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public CartPage ClickContinueShoppingFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, continueShopping, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public CartPage ClickCartFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, proceedToCheckout, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyShoppingCartFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(fireFox, viewLabel1, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyBlouseSizeColorDetailsFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(fireFox, cartDescriptionBlouse, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyChifonSizeColorDetailsFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(fireFox, cartDescriptionChifon, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyTShirtSizeColorDetailsFireFox()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(fireFox, cartDescriptionTShirt, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public CartPage AddQuantityChifonDressFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, iconPlusBtnChifon, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(3000);
            return this;
        }
        public CartPage MinusQuantityTShirtFireFox()
        {
            WaitUtils.WaitForElementDisplayed(fireFox, iconMinusBtnTShirt, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(3000);
            return this;
        }

        //EdgeMethods

        public CartPage SelectWomensTopsCategoryEdge()
        {
            ClickEdge(womenCategory, TimeSpan.FromSeconds(30));
            ClickEdge(womenTops, TimeSpan.FromSeconds(30));
            Thread.Sleep(5000);
            return this;
        }
        public String VerifyTopsCategoryEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectWomensBlouseTopSizeColorEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, blouseTop, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, blouseMoreBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, whiteColor, TimeSpan.FromSeconds(30)).Click();
            return this;
        }


        //Edge-SelectDressesCategory

        public CartPage SelectDressesCategoryEdge()
        {

            WaitUtils.WaitForElementDisplayed(edgeDriver, dressesCategory, TimeSpan.FromSeconds(30)).Click();
            //            Thread.Sleep(5000);
            return this;
        }
        public String VerifyDressesCategoryEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectWomensDressSizeColorEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, chifonDress, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, greenColor, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }

        //Edge-SelectTShirtCategory

        public CartPage SelectTShirtsCategoryEdge()
        {

            WaitUtils.WaitForElementDisplayed(edgeDriver, tshirtsCategory, TimeSpan.FromSeconds(30)).Click();
            //            Thread.Sleep(5000);
            return this;
        }
        public String VerifyTShirtsCategoryEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, subCategory, TimeSpan.FromSeconds(30));
            return page.Text;
        }

        public CartPage SelectTShirtsSizeColorEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, fadedTShirt, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, sizeBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, sizeMed, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, blueColor, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            WaitUtils.WaitForElementDisplayed(edgeDriver, iconPlusBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }

        public CartPage AddToCartEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, addToCart, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(5000);
            return this;
        }
        public String VerifySuccessMessageEdge()
        {
            IWebElement page = WaitUtils.WaitForElementDisplayed(edgeDriver, viewLabel2, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public CartPage ClickContinueShoppingEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, continueShopping, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public CartPage ClickCartEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, proceedToCheckout, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String VerifyShoppingCartEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, viewLabel1, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyBlouseSizeColorDetailsEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, cartDescriptionBlouse, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyChifonSizeColorDetailsEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, cartDescriptionChifon, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public String VerifyTShirtSizeColorDetailsEdge()
        {
            IWebElement page = WaitUtils.WaitForElementPresent(edgeDriver, cartDescriptionTShirt, TimeSpan.FromSeconds(30));
            return page.Text;
        }
        public CartPage AddQuantityChifonDressEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, iconPlusBtnChifon, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(3000);
            return this;
        }
        public CartPage MinusQuantityTShirtEdge()
        {
            WaitUtils.WaitForElementDisplayed(edgeDriver, iconMinusBtnTShirt, TimeSpan.FromSeconds(30)).Click();
            Thread.Sleep(3000);
            return this;
        }


    }
}