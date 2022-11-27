using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System;
using NUnit.Framework.Interfaces;
using System.Reflection.Metadata;

namespace FunctionalTests
{
    public class Tests
    {
        [Test]

        public void LenovoTestNinthTestCase()
        {
            WebDriver driver = new ChromeDriver("D:\\Soft\\WebDrivers\\chromedriver.exe");
            driver.Url = "https://www.lenovo.com/us/en/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/div/div/div/div[4]/div[1]/div/form/input[1]")).SendKeys("Yoga 6");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/div/div/div/div[4]/div[1]/div/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            string findYoga = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div[2]/div[3]/ul/li[1]/div[4]/a")).GetAttribute("innerText");
            Assert.That(findYoga, Is.EqualTo("Yoga 6 (13” AMD) - Dark Teal with Aluminum Top Cover"));
        }
    }
}