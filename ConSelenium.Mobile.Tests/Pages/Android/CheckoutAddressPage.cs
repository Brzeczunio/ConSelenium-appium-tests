using ConSelenium.Mobile.Tests.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace ConSelenium.Mobile.Tests.Pages.Android
{
    internal class CheckoutAddressPage : AndroidBasePage
    {
        public TextField CheckoutText { get; private set;}

        public CheckoutAddressPage(IWebDriver driver) : base(driver, "mydemoapprn://checkout-address")
        {
            CheckoutText = new TextField(Driver, MobileBy.XPath("//android.widget.TextView[@text=\"Checkout\"]"));
        }

        public void MoveToCheckoutAddressPage() => MoveToPageDeepLink();
    }
}
