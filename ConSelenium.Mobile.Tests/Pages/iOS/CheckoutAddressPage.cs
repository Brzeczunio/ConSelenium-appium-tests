using ConSelenium.Mobile.Tests.Components;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;

namespace ConSelenium.Mobile.Tests.Pages.iOS
{
    internal class CheckoutAddressPage : IOSBasePage
    {
        public TextField CheckoutText { get; private set; }

        public CheckoutAddressPage(IWebDriver driver) : base(driver, "mydemoapprn://checkout-address")
        {
            CheckoutText = new TextField(Driver, MobileBy.AccessibilityId("Checkout"));
        }

        public void MoveToCheckoutAddressPage() => MoveToPageDeepLink();
    }
}
