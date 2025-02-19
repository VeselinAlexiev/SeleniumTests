using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class ButtonClickTests
{
    private IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://example.com");
    }

    [Test]
    public void ClickLearnMoreButton()
    {
        IWebElement learnMoreButton = driver.FindElement(By.Id("learn-more"));
        learnMoreButton.Click();
        Assert.IsTrue(driver.Url.Contains("about"), "Clicking the button did not navigate to the expected page.");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
