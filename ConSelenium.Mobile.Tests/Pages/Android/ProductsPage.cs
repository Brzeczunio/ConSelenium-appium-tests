using ConSelenium.Mobile.Tests.Components;
using ConSelenium.Mobile.Tests.Pages.Android.Header;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace ConSelenium.Mobile.Tests.Pages.Android
{
    internal class ProductsPage : AndroidBasePage
    {
        public Products Products { get; private set; }
        public PageHeader Header { get; private set; }

        public ProductsPage(IWebDriver driver) : base(driver, "mydemoapprn://store-overview")
        {
            Products = new Products(Driver, 
                MobileBy.XPath("(//android.view.ViewGroup[@content-desc=\"store item\"])[*]/android.view.ViewGroup[*]/android.widget.ImageView"));
            Header = new PageHeader(Driver);
        }

        public void MoveToProductsPage() => MoveToPageDeepLink();
    }
}