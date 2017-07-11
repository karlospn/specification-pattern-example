using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Specification.Logic.Library.Models;

namespace Specification.Logic.Library.UnitTest
{
    [TestClass]
    public class PlaneHasOpenSeatsSpecificationTest
    {
        [TestMethod]
        public void PlaneHasOpenSeats()
        {
            var spec = new PlaneHasOpenSeatsSpecification();
            var plane = new Airplane
            {
                Seats = new List<Seat>
                {
                    new Seat
                    {
                        Available = Availability.Open,
                        Column = 1,
                        Row = 1
                    }
                }
            };

            var value = spec.IsSatisfiedBy(plane);
            Assert.AreEqual(value, true);
        }

        [TestMethod]
        public void PlaneHasNotOpenSeats()
        {
            var spec = new PlaneHasOpenSeatsSpecification();
            var plane = new Airplane
            {
                Seats = new List<Seat>
                {
                    new Seat
                    {
                        Available = Availability.Closed,
                        Column = 1,
                        Row = 1
                    }
                }
            };

            var value = spec.IsSatisfiedBy(plane);
            Assert.AreEqual(value, false);
        }
    }
}
