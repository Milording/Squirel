using System;
using Squirel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Forester
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Value must be positive.")]
        public void Circle_Negative_Radius()
        {
            ISquarable shape = new Circle(-10);

            shape.Square();
        }

        [TestMethod]
        public void Circle_Normal_Radius()
        {
            ISquarable shape = new Circle(10);

            var square = shape.Square();

            Assert.AreEqual(314, Math.Round(square));
        }

        [TestMethod]
        public void Triangle_Normal_Sides()
        {
            ISquarable shape = new Triangle(10, 10, 10);
            
            var square = shape.Square();

            Assert.AreEqual(43, Math.Round(square));
        }

        [TestMethod]
        public void Triangle_Is_Right()
        {
            var triangle = new Triangle(4, 5, 3);
            
            Assert.IsTrue(triangle.IsRight);
        }

        [TestMethod]
        public void Triangle_Is_Not_Right()
        {
            var triangle = new Triangle(2, 2, 3);

            Assert.IsFalse(triangle.IsRight);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "All sides must be positive.")]
        public void Triangle_Negative_First_Side()
        {
            ISquarable shape = new Triangle(-1, 10, 10);

            var square = shape.Square();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "All sides must be positive.")]
        public void Triangle_Negative_Second_Side()
        {
            ISquarable shape = new Triangle(1, -1, 10);

            var square = shape.Square();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "All sides must be positive.")]
        public void Triangle_Negative_Third_Side()
        {
            ISquarable shape = new Triangle(10, 10, -1);

            var square = shape.Square();
        }
    }
}
