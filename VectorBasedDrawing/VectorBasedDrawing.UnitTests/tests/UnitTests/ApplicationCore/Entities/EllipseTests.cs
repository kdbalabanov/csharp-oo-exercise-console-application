using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using VectorBasedDrawing.src.ApplicationCore.Entities;

namespace VectorBasedDrawing.UnitTests.tests.UnitTests.ApplicationCore.Entities
{
    [TestClass]
    public class EllipseTests
    {
        private readonly int _x = 25;
        private readonly int _y = 50;
        private readonly int _horizontalDiameter = 44;
        private readonly int _verticalDiameter = 44;

        [TestMethod]
        public void TestEllipseInitialization()
        {
            var ellipse = new Ellipse(_x, _y, _horizontalDiameter, _verticalDiameter);

            Assert.AreEqual(_x, ellipse.X);
            Assert.AreEqual(_y, ellipse.Y);
            Assert.AreEqual(_horizontalDiameter, ellipse.HorizontalD);
            Assert.AreEqual(_horizontalDiameter, ellipse.VerticalD);
        }
    }
}
