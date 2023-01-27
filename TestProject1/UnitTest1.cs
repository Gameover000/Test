using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Class1 cls = new Class1();
        [TestMethod]
        public void triangleTest()
        {
            Assert.AreEqual(cls.triangle(4, 4, 6), Math.Sqrt(7 * (7 - 4) * (7 - 4) * (7 - 6)));
        }
        [TestMethod]
        public void circleTest()
        {
            Assert.AreEqual(cls.circle(5), 5 * 5 * 3.14);
        }
        [TestMethod]
        public void prymougtriangleTest()
        {
            Assert.AreEqual(cls.prymougtriangle(4,6,7), false);
            Assert.AreEqual(cls.prymougtriangle(3,4,5), true);
        }
    }
}