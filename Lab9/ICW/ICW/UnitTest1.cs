using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ICW
{
    public class Tests
    {
        [TearDown]
        public void TearDown()
        {
            WebDriver driver = new ChromeDriver("D:\\Soft\\WebDrivers\\chromedriver.exe");
            driver.Quit();
        }
        [Test]
        public void ICanWin()
        {
            WebDriver driver = new ChromeDriver("D:\\Soft\\WebDrivers\\chromedriver.exe");
            driver.Url = "https://pastebin.com";
            driver.FindElement(By.Id("postform-text")).SendKeys("Hello from WebDriver");
            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();
            driver.FindElement(By.Id("postform-name")).SendKeys("helloweb");
            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Quit();
        }
    }
}