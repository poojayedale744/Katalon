using OpenQA.Selenium;
using Katalon.Hooks;
using System.Threading;

namespace Katalon.PageObjects
{
    public class KatalonShoppingPage
    {
        public IWebDriver driver;
        public KatalonShoppingPage()
        {
            driver = KatalonShoppingBaseTest.driver;
        }

        private IWebElement _firstCartItem => driver.FindElement(By.XPath("//a[@aria-label='Add “Flying Ninja” to your cart']"));
        private IWebElement _secondCartItem => driver.FindElement(By.CssSelector(".button.product_type_simple.add_to_cart_button.ajax_add_to_cart[href='?add-to-cart=27']"));
        private IWebElement _thirdCartItem => driver.FindElement(By.XPath("//a[@aria-label='Add “Patient Ninja” to your cart']"));
        private IWebElement _fourthCartItem => driver.FindElement(By.XPath("//a[@aria-label='Add “Ship Your Idea” to your cart']"));
        private IWebElement _fourTotalItems => driver.FindElement(By.ClassName("page-title"));
        private IWebElement _searchLowestPrice => driver.FindElement(By.XPath("//*[@id='post-8']/div/div/form/table/tbody/tr[1]/td[2]/a/img"));
        private IWebElement _lowestPricedItem => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/a[1]"));
        private IWebElement _threeItemsInCart => driver.FindElement(By.ClassName("woocommerce-message"));
        private IWebElement _viewCart => driver.FindElement(By.XPath("//a[normalize-space()='Cart']"));


        public void FirstItemAddToCart()
        {
            scrollTo("window.scrollTo(0,350)");
            addItemToCart(_firstCartItem);
        }

        public void SecondItemAddToCart()
        {
            scrollTo("window.scrollTo(0,350)");
            addItemToCart(_secondCartItem);
        }

        public void ThirdItemAddToCart()
        {
            scrollTo("window.scrollTo(0,700)");
            addItemToCart(_thirdCartItem);
        }

        public void FourthItenAddToCart()
        {
            scrollTo("window.scrollTo(0,1000)");
            addItemToCart(_fourthCartItem);
        }

        private void scrollTo(string script)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script);
            Thread.Sleep(3000);
        }

        private void addItemToCart(IWebElement element)
        {
            element.Click();
        }

        public void UserViewOnCartItems()
        {
            scrollTo("window.scrollTo(0,50)");
            _viewCart.Click();
        }

        public bool FourTotalRandomSelectedItems()
        {
            Thread.Sleep(3000);
            return _fourTotalItems.Displayed;
        }

        public bool SearchLowestPriceItem()
        {
           return _searchLowestPrice.Displayed;
        }

        public void DeleteLowestPriceItem()
        {
             _lowestPricedItem.Click();
        }

        public bool VerifyThreeItems()
        {
            return _threeItemsInCart.Displayed;
        }

    }
}
