using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD4n3wbs.UnitTests
{
    [TestClass]
    public class MyMathTests
    {
        static MyMath myMath;
        [TestInitialize]
        public void testInitialize()
        {
            myMath = new MyMath();
        }
        [TestCleanup]
        public void testCleanup()
        {
            myMath = null;
        }

        [TestCategory("basic"), TestMethod]
        public void BasicRooterTest()
        {
            var expectedResult = 2.0;
            var input = expectedResult * expectedResult;
            var actualResult = myMath.MySqrt(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }
        [TestCategory("edge"), TestMethod]
        public void OneRooterTest()
        {
            var input = 1.0;
            var expectedResult = 1.0;
            var actualResult = myMath.MySqrt(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCategory("edge"), TestMethod]
        public void ZeroRooterTest()
        {
            var input = 0.0;
            var expectedResult = 0.0;
            var actualResult = myMath.MySqrt(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCategory("edge"), TestMethod]
        public void NegativeRooterTest()
        {
            var input = -4.5;
            var expectedResult = 0.0;
            var actualResult = myMath.MySqrt(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
