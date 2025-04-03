using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ReqnrollProject1.Pages;

namespace ReqnrollProject1.Tests
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        private LoginPage loginPage;
        
        [SetUp]
        public void Setup()
        {
            //loginPage = new LoginPage();
        }

        [Test]
        public void VerifyLogin()
        {
            //loginPage.EnterCredentials("admin", "admin123");
            //loginPage.ClickLogin();
            //Assert.IsTrue(driver.Url.Contains("dashboard"));
        }

    }
}
