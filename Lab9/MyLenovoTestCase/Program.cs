using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FunctionalTests
{
    public class Tests
    {
        [Test]

        public void LenovoTestNinthTestCase()
        {
            WebDriver driver = new ChromeDriver("D:\\Soft\\WebDrivers\\chromedriver.exe");
            driver.Url = "https://www.lenovo.com/us/en/";
            driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/div/div/div/div[4]/div[1]/ul/li[6]/a")).Click();
            driver.FindElement(By.XPath("/html/body/main/section[2]/div/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/section[2]/div/div/div[2]/div[2]/div/a[3]")).Click();
            driver.FindElement(By.XPath("/html/body/header/div[3]/div/div[2]/div/div[3]/span")).Click();
            driver.Close();
        }
    }
}