using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SquareGeom.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void getSquare_5_25multPiReturned()
        {
            double radius = 5;
            Figure circle = new Circle(radius);

            double square = circle.getSquare();

            Assert.AreEqual(Math.Pow(radius,2)*Math.PI, square);

        }

        [TestMethod]
        public void getSquare_0_ArgExReturned()
        {
            double radius = 0;

            Assert.ThrowsException<ArgumentException>(() => { Figure circle = new Circle(radius); });
           

        }
    }
}
