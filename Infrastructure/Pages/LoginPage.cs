using OpenQA.Selenium;

public class LoginPage
{
    private readonly IWebDriver driver;
    public LoginPage(IWebDriver driver) => this.driver = driver;

    private IWebElement UsernameField => driver.FindElement(By.Name("username"));
    private IWebElement PasswordField => driver.FindElement(By.Name("password"));
    private IWebElement LoginButton => driver.FindElement(By.Id("login-btn"));

    public void Login(string username, string password)
    {
        UsernameField.SendKeys(username);
        PasswordField.SendKeys(password);
        LoginButton.Click();
    }
}
