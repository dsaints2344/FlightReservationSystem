using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FlightReservationSystem.Controllers;
using FlightReservationSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightReservationSystem.Tests.Controllers
{
    [TestClass]
    public class FlightsControllerTest
    {
        [TestMethod]
        public void IndexShouldReturnView()
        {
            FlightsController controller = new FlightsController();

            var result = controller.Index("New York") as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexShouldHaveModelTypeIEnumerable()
        {
            FlightsController controller = new FlightsController();

            ViewResult view = controller.Index("New York") as ViewResult;
            var result = view.Model;

            Assert.IsInstanceOfType(result,typeof(IEnumerable<FlightViewModel>));
        }
    }
}
