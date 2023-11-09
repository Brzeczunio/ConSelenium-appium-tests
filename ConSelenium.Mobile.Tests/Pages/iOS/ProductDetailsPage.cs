using ConSelenium.Mobile.Tests.Components;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.iOS;
using ConSelenium.Mobile.Tests.Pages.iOS.Footer;

namespace ConSelenium.Mobile.Tests.Pages.iOS
{
    internal class ProductDetailsPage : IOSBasePage
    {
        public Button AddToCartButton { get; private set; }
        public PageFooter Footer { get; private set; }

        public ProductDetailsPage(IWebDriver driver) : base(driver, string.Empty)
        {
            AddToCartButton = new Button(Driver, MobileBy.AccessibilityId("Add To Cart button"));
            Footer = new PageFooter(Driver);
        }

        public void MoveToProductDetailsPage(int id)
        {
            DeepLink = $"mydemoapprn://product-details/{id}";
            MoveToPageDeepLink();
        }

        public void MoveToAddToCartButton()
        {
            ((IOSDriver<IOSElement>)Driver).ExecuteScript("mobile:scroll", new Dictionary<string, string> { { "direction", "down" } });
        }
    }
}
