using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FunctionalTests
{
    public class Tests
    {
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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Quit();
        }
        [Test]
        public void BringItOn()
        {
            WebDriver driver = new ChromeDriver("D:\\WebDrivers\\chromedriver.exe");
            driver.Url = "https://pastebin.com";

            driver.FindElement(By.Id("postform-text")).SendKeys("git config --global user.name  \"New Sheriff in Town\" \ngit reset $(git commit - tree HEAD ^{ tree} -m \"Legacy code\") \ngit push origin master --force");

            driver.FindElement(By.Id("select2-postform-format-container")).Click();
            driver.FindElement(By.XPath("//li[text()='Bash']")).Click();

            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();

            driver.FindElement(By.Id("postform-name")).SendKeys("how to gain dominance among developers");

            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement syntaxHighlighting = driver.FindElement(By.XPath("//a[text()='Bash']"));
            IWebElement codeFirstLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[1]/div/span[1]"));
            IWebElement codeSecondLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[2]/div/span[1]"));
            IWebElement codeThirdLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[3]/div/span[1]"));

            Assert.That(driver.Title, Is.EqualTo("how to gain dominance among developers - Pastebin.com"));
            Assert.That(syntaxHighlighting.Text, Is.EqualTo("Bash"));
            Assert.That(codeFirstLine.Text, Is.EqualTo("git config"));
            Assert.That(codeSecondLine.Text, Is.EqualTo("git reset"));
            Assert.That(codeThirdLine.Text, Is.EqualTo("git push"));

            driver.Close();
        }
    }
}