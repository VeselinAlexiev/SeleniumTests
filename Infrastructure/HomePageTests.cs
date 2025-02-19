using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class HomePageTests
{
    private IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://example.com");
    }

    [Test]
    public void HomePageTitleIsCorrect()
    {
        string expectedTitle = "Example Website - Home";
        Assert.AreEqual(expectedTitle, driver.Title, "The homepage title does not match.");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
