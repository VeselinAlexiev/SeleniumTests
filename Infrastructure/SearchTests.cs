using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


[TestFixture]
public class SearchTests
{
    private IWebDriver driver;
    private HomePage homePage;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        homePage = new HomePage(driver);
        driver.Navigate().GoToUrl("https://example.com");
    }

    [Test]
    public void SearchReturnsResults()
    {
        homePage.Search("Selenium");
        Assert.IsTrue(driver.Url.Contains("search-results"));
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
