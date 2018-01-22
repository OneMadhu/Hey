using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCPluralsight;
using MVCPluralsight.Controllers;

namespace MVCPluralsight.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void OdeFoodScenario1()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result.ViewBag.Razor);
        }
        [TestMethod]
        public void OdeFoodScenario2()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            //Models.Hotels model = (Models.Hotels)result.Model;
            var model = (Models.Hotels)result.Model;
            Assert.AreEqual(model.Name, "Nagarjuna");
        }
        [TestMethod]
        public void OdeFoodScenario3()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            //Models.Hotels model = (Models.Hotels)result.Model;
            var model = (Models.Hotels)result.Model;
            Assert.IsTrue(model.Rating > 0);
        }
    }
}
