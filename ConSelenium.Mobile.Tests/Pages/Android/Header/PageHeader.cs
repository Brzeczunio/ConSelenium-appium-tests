using ConSelenium.Mobile.Tests.Components;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;

namespace ConSelenium.Mobile.Tests.Pages.Android.Header
{
    internal class PageHeader
    {
        private IWebDriver _driver;
        public Button ShoppingCartButton { get; private set; }
        public Button SortButton { get; private set; }
        public TextField ShoppingCartCount { get; private set; }

        public PageHeader(IWebDriver driver)
        {
            _driver = driver;
            ShoppingCartCount = new TextField(_driver, MobileBy.XPath("(//android.widget.TextView)[1]"));
            SortButton = new Button(_driver, MobileBy.XPath("//android.view.ViewGroup[@content-desc=\"sort button\"]/android.widget.ImageView"));
            ShoppingCartButton = new Button(_driver, MobileBy.AccessibilityId("cart badge"));
        }
    }
}
