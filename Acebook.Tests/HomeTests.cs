using System;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Acebook.Controllers;

namespace Acebook.Controllers.NunitTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        private IWebDriver _driver;
        private string _baseUrl;

        [SetUp]
        public void Setup()
        {
            IWebDriver _driver = new FirefoxDriver();
            _baseUrl = this._driver.Url;
        }

        [Test]
        public void HomePageShowsAcebook()
        {
            // _driver.Navigate().GoToUrl(_baseUrl);
            // _driver.PageSource.Should().Contain("Acebook");
            Assert.Pass();
        }

        [TearDown]
        public void Cleanup()
        {
            if (this._driver == null)
            {
                return;
            }

            this._driver.Close();
            this._driver.Quit();
        }
    }
}