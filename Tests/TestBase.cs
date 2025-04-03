using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ReqnrollProject1.Tests
{
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Automatically download and setup ChromeDriver
             new DriverManager().SetUpDriver(new ChromeConfig());

            // Initialize WebDriver
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com");
        }
        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

    }
}
