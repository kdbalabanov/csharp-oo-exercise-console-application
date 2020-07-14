using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using VectorBasedDrawing.src.ApplicationCore.Entities;

namespace VectorBasedDrawing.UnitTests.tests.UnitTests.ApplicationCore.Entities
{
    [TestClass]
    public class TextboxTests
    {
        private readonly int _x = 22;
        private readonly int _y = 11;
        private readonly int _width = 10;
        private readonly int _height = 20;
        private readonly string _text = "mytext";

        [TestMethod]
        public void TestTextboxInitialization()
        {
            var textbox = new Textbox(_x, _y, _width, _height, _text);

            Assert.AreEqual(_x, textbox.X);
            Assert.AreEqual(_y, textbox.Y);
            Assert.AreEqual(_width, textbox.Width);
            Assert.AreEqual(_height, textbox.Height);
            Assert.AreEqual(_text, textbox.Text);
        }

        [TestMethod]
        public void TestTextboxInitializationNegativeValues()
        {
            var textbox = new Textbox(-5, -10, -200, -100, _text);

            Assert.AreEqual(0, textbox.X);
            Assert.AreEqual(0, textbox.Y);
            Assert.AreEqual(0, textbox.Width);
            Assert.AreEqual(0, textbox.Height);
            Assert.AreEqual(_text, textbox.Text);
        }

        [TestMethod]
        public void TestTextboxInitializationNullString()
        {
            var textbox = new Textbox(_x, _y, _width, _height, null);

            Assert.AreEqual(_x, textbox.X);
            Assert.AreEqual(_y, textbox.Y);
            Assert.AreEqual(_width, textbox.Width);
            Assert.AreEqual(_height, textbox.Height);
            Assert.IsTrue(textbox.Text.Length == 0);
        }
    }
}
