using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PikBgTests
{
    [TestFixture]
    public class PikBgTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }


        [Test]
        public void VerifyHomePageTitle()
        {
            driver.Navigate().GoToUrl("https://pik.bg/");
            string expectedTitle = "Информационна агенция ПИК";
            Assert.AreEqual(expectedTitle, driver.Title, "Заглавието на страницата не е вярно.");
        }

        [Test]
        public void VerifyLogoIsDisplayed()
        {
            driver.Navigate().GoToUrl("https://pik.bg/");
            var logo = driver.FindElement(By.CssSelector("header .logo img"));
            Assert.IsTrue(logo.Displayed, "Логото не се показва на началната страница.");
        }

        [Test]
        public void VerifyPoliticsSectionInMenu()
        {
            driver.Navigate().GoToUrl("https://pik.bg/");


            var politicsSection = driver.FindElements(By.LinkText("Политика"));


            Assert.IsTrue(politicsSection.Count > 0, "Секцията 'Политика' не присъства в главното меню.");
        }

        [Test]
        public void VerifyFooterIsPresent()
        {
            driver.Navigate().GoToUrl("https://pik.bg/");


            var footer = driver.FindElement(By.CssSelector("footer"));

            Assert.IsTrue(footer.Displayed, "Футерът не е видим на страницата.");
        }


        [Test]
        public void VerifyFooterContainsContacts()
        {
            driver.Navigate().GoToUrl("https://pik.bg/");
            var footer = driver.FindElement(By.TagName("footer"));
            Assert.IsTrue(footer.Text.Contains("Контакти"), "Футърът не съдържа 'Контакти'.");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}