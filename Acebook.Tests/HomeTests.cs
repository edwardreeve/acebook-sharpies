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
        private HomeController _controller;
        private IWebDriver _driver;
        private string _baseUrl;

        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new FirefoxDriver();
            _baseUrl = "/";
        }

        [Test]
        public void HomePageShowsAcebook()
        {
            _driver.Navigate().GoToUrl(_baseUrl);
            _driver.PageSource.Should().Contain("Acebook");
        }
    }
}