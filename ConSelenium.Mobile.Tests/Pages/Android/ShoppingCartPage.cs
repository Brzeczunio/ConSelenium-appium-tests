using ConSelenium.Mobile.Tests.Components;
using ConSelenium.Mobile.Tests.Pages.Android.Header;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;

namespace ConSelenium.Mobile.Tests.Pages.Android
{
    internal class ShoppingCartPage : AndroidBasePage
    {
        public Button RemoveItemButton { get; private set; }
        public TextField NoItemsField { get; private set; }
        public Header.PageHeader Header { get; private set; }

        public ShoppingCartPage(IWebDriver driver) : base(driver, string.Empty)
        {
            RemoveItemButton = new Button(Driver, MobileBy.XPath("//android.widget.TextView[@text=\"Remove Item\"]"));
            NoItemsField = new TextField(Driver, MobileBy.XPath("//android.widget.TextView[@text=\"No Items\"]"));
            Header = new Header.PageHeader(Driver);
        }
    }
}
