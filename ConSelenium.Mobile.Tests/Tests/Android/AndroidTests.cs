using ConSelenium.Mobile.Tests.Extensions;
using ConSelenium.Mobile.Tests.Pages.Android;
using FluentAssertions;

namespace ConSelenium.Mobile.Tests.Tests.Android
{
    [Parallelizable(ParallelScope.All)]
    public class AndroidTests : AndroidTestBase
    {
        [Test]
        public void WhenUserLogIn_ShouldLogin()
        {
            Driver = SauceLabs.CreateAndroidConnection(AppVersion, HubUrl, TestContext.CurrentContext.Test.Name);

            var loginPage = new LoginPage(Driver);
            loginPage.MoveToLoginPage();
            loginPage.LoginInput.SendKeys("bob@example.com");
            loginPage.PasswordInput.SendKeys("10203040");
            loginPage.LogInButton.Click();

            var checkoutAddressPage = new CheckoutAddressPage(Driver);

            checkoutAddressPage.CheckoutText.IsDiplayed().Should().BeTrue();
        }

        [Test]
        public void WhenUserAddsProduct_ShouldBeAdded()
        {
            Driver = SauceLabs.CreateAndroidConnection(AppVersion, HubUrl, TestContext.CurrentContext.Test.Name);

            var productPage = new ProductsPage(Driver);
            productPage.Products.Click(0);

            var productDetailsPage = new ProductDetailsPage(Driver);
            productDetailsPage.MoveToAddToCartButton();
            productDetailsPage.AddToCartButton.Click();
            productDetailsPage.Header.ShoppingCartCount.GetText().Should().Be("1");
        }

        [Test]
        public void WhenUserRemovesProduct_ShouldBeRemoved()
        {
            Driver = SauceLabs.CreateAndroidConnection(AppVersion, HubUrl, TestContext.CurrentContext.Test.Name);

            var productPage = new ProductsPage(Driver);
            productPage.Products.Click(0);

            var productDetailsPage = new ProductDetailsPage(Driver);
            productDetailsPage.MoveToAddToCartButton();
            productDetailsPage.AddToCartButton.Click();
            productDetailsPage.Header.ShoppingCartButton.Click();

            var shoppingCartPage = new ShoppingCartPage(Driver);
            shoppingCartPage.RemoveItemButton.Click();
            shoppingCartPage.NoItemsField.IsDiplayed().Should().BeTrue();
        }

        [Test]
        public void WhenUserSortsProductsInDescendingOrder_ShouldBeInDescendingOrder()
        {
            Driver = SauceLabs.CreateAndroidConnection(AppVersion, HubUrl, TestContext.CurrentContext.Test.Name);

            var productPage = new ProductsPage(Driver);
            productPage.Header.SortButton.Click();

            var sortingProductPage = new SortingProductPage(Driver);
            sortingProductPage.DescendingButton.Click();

            productPage.Products.GetTexts().Should().BeInDescendingOrder();
        }
    }
}