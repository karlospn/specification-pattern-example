using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Specification.Logic.Library.Models;

namespace Specification.Logic.Library.UnitTest
{
    [TestClass]
    public class PassengerIsAChildNotLivingInBcnSpecificationTest
    {
        [TestMethod]
        public void PassengerIsAChildNotLivingInBcn()
        {
            var spec = new PassengerIsAChildLivingInBcnSpecification();

            var pax = new Passenger
            {
                Age = 8,
                City = "London",
                FirstName = "John"
            };

            var value = spec.IsSatisfiedBy(pax);
            Assert.AreEqual(value, false);
        }

        [TestMethod]
        public void PassengerIsNotAChildLivingInBcn()
        {
            var spec = new PassengerIsAChildLivingInBcnSpecification();

            var pax = new Passenger
            {
                Age = 28,
                City = "London",
                FirstName = "John"
            };

            var value = spec.IsSatisfiedBy(pax);
            Assert.AreEqual(value, false);
        }

        [TestMethod]
        public void PassengerIsAChildLivingInBcn()
        {
            var spec = new PassengerIsAChildLivingInBcnSpecification();

            var pax = new Passenger
            {
                Age = 8,
                City = "Barcelona",
                FirstName = "John"
            };

            var value = spec.IsSatisfiedBy(pax);
            Assert.AreEqual(value, true);
        }

    }
}
