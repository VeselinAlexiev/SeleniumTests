using OpenQA.Selenium;

public class HomePage
{
    private readonly IWebDriver driver;
    public HomePage(IWebDriver driver) => this.driver = driver;

    private IWebElement SearchBox => driver.FindElement(By.CssSelector("input[name='search']"));
    private IWebElement SearchButton => driver.FindElement(By.CssSelector("button.search-btn"));

    public void Search(string keyword)
    {
        SearchBox.SendKeys(keyword);
        SearchButton.Click();
    }
}
