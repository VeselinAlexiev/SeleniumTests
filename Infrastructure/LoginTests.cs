using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class LoginTests
{
    private IWebDriver driver;
    private LoginPage loginPage;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        loginPage = new LoginPage(driver);
        driver.Navigate().GoToUrl("https://example.com/login");
    }

    [Test]
    public void ValidUserCanLogin()
    {
        var user = UserFactory.CreateFakeUser();
        loginPage.Login(user.Username, user.Password);
        Assert.IsTrue(driver.Url.Contains("dashboard"));
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
