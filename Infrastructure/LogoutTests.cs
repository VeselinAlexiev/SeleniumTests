using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.Pages;

[TestFixture]
public class LogoutTests
{
    private IWebDriver driver;
    private LoginPage loginPage;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        loginPage = new LoginPage(driver);
        driver.Navigate().GoToUrl("https://example.com/login");

        // Perform login first
        loginPage.Login("testuser", "password123");
    }

    [Test]
    public void UserCanLogout()
    {
        IWebElement logoutButton = driver.FindElement(By.Id("logout"));
        logoutButton.Click();
        Assert.IsTrue(driver.Url.Contains("login"), "Logout did not redirect to the login page.");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
