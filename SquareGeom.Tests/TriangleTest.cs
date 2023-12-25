using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquareGeom.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void getSquare_345_6Returned()
        {
            double sideA = 3, sideB = 4, sideC = 5;
            Figure triangle = new Triangle(sideA, sideB, sideC);

            double square = triangle.getSquare();

            Assert.AreEqual(square, 6);

        }
        [TestMethod]
        public void triangle_113_ArgExReturned()
        {
            double sideA = 1, sideB = 1, sideC = 3;

            Assert.ThrowsException<ArgumentException>(() => { Figure triangle = new Triangle(sideA, sideB, sideC); });
        }
        [TestMethod]
        public void triangle_011_ArgExReturned()
        {
            double sideA = 0, sideB = 1, sideC = 1;

            Assert.ThrowsException<ArgumentException>(() => { Figure triangle = new Triangle(sideA,sideB,sideC); });
        }
        [TestMethod]
        public void isRect_345_TrueReturned()
        {
            Figure triangle = new Triangle(3,4,5);

            bool isRect = Triangle.isRect((Triangle)triangle);

            Assert.IsTrue(isRect);
        }

        [TestMethod]
        public void isRect_344_FalseReturned()
        {
            Figure triangle = new Triangle(3, 4, 4);

            bool isRect = Triangle.isRect((Triangle)triangle);

            Assert.IsFalse(isRect);
        }
    }
}
