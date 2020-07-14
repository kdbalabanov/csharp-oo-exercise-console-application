using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorBasedDrawing.src.ApplicationCore.Entities;

namespace VectorBasedDrawing.UnitTests.tests.UnitTests.ApplicationCore.Entities
{
    [TestClass]
    public class RectangleTests
    {
        private readonly int _x = 13;
        private readonly int _y = 44;
        private readonly int _width = 10;
        private readonly int _height = 20;

        [TestMethod]
        public void TestRectangleInitialization()
        {
            var rectangle = new Rectangle(_x, _y, _width, _height);

            Assert.AreEqual(_x, rectangle.X);
            Assert.AreEqual(_y, rectangle.Y);
            Assert.AreEqual(_width, rectangle.Width);
            Assert.AreEqual(_height, rectangle.Height);
        }

        [TestMethod]
        public void TestRectangleInitializationNegativeValues()
        {
            var rectangle = new Rectangle(-40, -60, -100, -50);

            Assert.AreEqual(0, rectangle.X);
            Assert.AreEqual(0, rectangle.Y);
            Assert.AreEqual(0, rectangle.Width);
            Assert.AreEqual(0, rectangle.Height);
        }
    }
}
