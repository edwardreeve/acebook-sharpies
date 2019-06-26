using System;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
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
            _driver = new RemoteWebDriver();
            // IWebDriver driver = new SafariDriver();
            _baseUrl = "/";
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}