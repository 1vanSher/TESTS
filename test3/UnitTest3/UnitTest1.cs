using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using test3;

namespace UnitTest3
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Сylinder_15and6_90returned()
        {
            double s = 15;
            double h = 6;
            double expected = 90;

            Geometry g = new Geometry();
            double actual = g.Сylinder(s, h);

            Assert.AreEqual(expected, actual);
        }
    }
}
