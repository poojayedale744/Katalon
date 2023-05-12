using NUnit.Framework;
using OpenQA.Selenium;
using Katalon.Hooks;
using Katalon.PageObjects;
using TechTalk.SpecFlow;

namespace Katalon.Features
{
    [Binding]
    public class KatalonShoppingSteps
    {
        public IWebDriver driver = KatalonShoppingBaseTest.driver;
        KatalonShoppingPage _katalonShoppingPage = new KatalonShoppingPage();
        
        [Given(@"I add four random items to my cart\.")]
        public void AddFourItemsToCart()
        {
            _katalonShoppingPage.FirstItemAddToCart();
            _katalonShoppingPage.SecondItemAddToCart();
            _katalonShoppingPage.ThirdItemAddToCart();
            _katalonShoppingPage.FourthItenAddToCart();          
        }

        [When(@"I view my cart\.")]
        public void ViewCart()
        {
            _katalonShoppingPage.UserViewOnCartItems();
        }

        [When(@"I search for the lowest price item\.")]
        public void SearchForLowestPriceItem()
        {
            _katalonShoppingPage.SearchLowestPriceItem();
        }
        
        [When(@"I am able to remove the lowest price item from my cart\.")]
        public void RemoveLowestPriceItem()
        {
            _katalonShoppingPage.DeleteLowestPriceItem();
        }
        
        [Then(@"I find total four items listed in my cart\.")]
        public void FindItemsInCart()
        {
           Assert.That(_katalonShoppingPage.FourTotalRandomSelectedItems());
        }
        
        [Then(@"I am able to verify three items in my cart\.")]
        public void VerifyThreeItemsInCart()
        {
            Assert.IsTrue(_katalonShoppingPage.VerifyThreeItems());
        }
    }
}
