using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using VectorBasedDrawing.src.ApplicationCore.Entities;

namespace VectorBasedDrawing.UnitTests.tests.UnitTests.ApplicationCore.Entities
{
    [TestClass]
    public class CircleTests
    {
        private readonly int _x = 20;
        private readonly int _y = 60;
        private readonly int _diameter = 80;

        [TestMethod]
        public void TestCircleInitialization()
        {
            var circle = new Circle(_x, _y, _diameter);


            Assert.AreEqual(_x, circle.X);
            Assert.AreEqual(_y, circle.Y);
            Assert.AreEqual(_diameter, circle.Diameter);
        }

        [TestMethod]
        public void TestCircleInitializationNegativeValues()
        {
            var circle = new Circle(-10, -20, -55);

            Assert.AreEqual(0, circle.X);
            Assert.AreEqual(0, circle.Y);
            Assert.AreEqual(0, circle.Diameter);
        }
    }
}
