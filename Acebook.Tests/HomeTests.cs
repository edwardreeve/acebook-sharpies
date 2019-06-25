using NUnit.Framework;
// using Acebook.Models;
using Acebook.Controllers;

namespace Acebook.Controllers.NunitTests
{
    public class HomeControllerTests
    {
        private HomeController _controller;

        [SetUp]
        public void Setup()
        {
            // // _context = new AcebookContext();
            // _controller = new HomeController();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}