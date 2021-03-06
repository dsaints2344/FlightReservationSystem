﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlightReservationSystem;
using FlightReservationSystem.Controllers;

namespace FlightReservationSystem.Tests.Controllers
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
        public void RedirecttoFlightView()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = (RedirectToRouteResult)controller.About();

            Assert.IsNotNull(result);

        }

       
    }
}
