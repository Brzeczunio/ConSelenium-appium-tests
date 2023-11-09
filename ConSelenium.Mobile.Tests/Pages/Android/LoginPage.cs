using ConSelenium.Mobile.Tests.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace ConSelenium.Mobile.Tests.Pages.Android
{
    internal class LoginPage : AndroidBasePage
    {
        public Input LoginInput { get; private set; }
        public Input PasswordInput { get; private set; }
        public Button LogInButton { get; private set; }

        public LoginPage(IWebDriver driver) : base(driver, "mydemoapprn://login")
        {
            LoginInput = new Input(Driver, MobileBy.AccessibilityId("Username input field"));
            PasswordInput = new Input(Driver, MobileBy.AccessibilityId("Password input field"));
            LogInButton = new Button(Driver, MobileBy.AccessibilityId("Login button"));
        }

        public void MoveToLoginPage() => MoveToPageDeepLink();
    }
}
