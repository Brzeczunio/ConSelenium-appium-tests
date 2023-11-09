using ConSelenium.Mobile.Tests.Components;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;

namespace ConSelenium.Mobile.Tests.Pages.Android
{
    internal class SortingProductPage : AndroidBasePage
    {
        public Button DescendingButton { get; private set; }

        public SortingProductPage(IWebDriver driver) : base(driver, "mydemoapprn://checkout-address")
        {
            DescendingButton = new Button(Driver, MobileBy.XPath("//android.widget.TextView[@text=\"Name - Descending\"]"));
        }
    }
}