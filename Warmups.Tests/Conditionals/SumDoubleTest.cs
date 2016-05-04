using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warmups.Conditionals;

namespace Warmups.Tests.Conditionals
{
    [TestClass]
    public class SumDoubleTest
    {
        private DoubleSum sumDouble;
        private int actual;

        [TestInitialize]
        public void Initialize()
        {
            sumDouble = new DoubleSum();
        }

        [TestMethod]
        public void SumDouble_Returns3()
        {
            actual = sumDouble.SumDouble(1, 2);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void SumDouble_NotDouble()
        {
            actual = sumDouble.SumDouble(3, 2);
            Assert.AreEqual(5, actual);
        }
        [TestMethod]
        public void SumDouble_IsDouble()
        {
            actual = sumDouble.SumDouble(2, 2);
            Assert.AreEqual(8, actual);
        }
    }
}
