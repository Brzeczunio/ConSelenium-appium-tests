using ConSelenium.Mobile.Tests.Components;
using ConSelenium.Mobile.Tests.Pages.Android.Header;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace ConSelenium.Mobile.Tests.Pages.Android
{
    internal class ProductDetailsPage : AndroidBasePage
    {
        public Button AddToCartButton { get; private set; }
        public PageHeader Header { get; private set; }

        public ProductDetailsPage(IWebDriver driver) : base(driver, string.Empty)
        {
            AddToCartButton = new Button(Driver, MobileBy.AccessibilityId("Add To Cart button"));
            Header = new PageHeader(Driver);
        }

        public void MoveToProductDetailsPage(int id)
        {
            DeepLink = $"mydemoapprn://product-details/{id}";
            MoveToPageDeepLink();
        }

        public void MoveToAddToCartButton()
        {
            ((AndroidDriver<AndroidElement>)Driver).ExecuteScript("mobile:scroll", new Dictionary<string, string> { { "strategy", "accessibility id" }, { "selector", "Add To Cart button" } });
        }
    }
}
