using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warmups.Conditionals;

namespace Warmups.Tests.Conditionals
{
    [TestClass]
    public class Difference21Test
    {
        private Diff21 difference;
        private int actual;

        [TestInitialize]
        public void Initialize()
        {
            difference = new Diff21();
        }

        [TestMethod]
        public void Diff21_NumberOver21_ReturnsDoubleDifference()
        {
            actual = difference.DifferenceBetween21(23);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void Diff21_NumberLessThan21_ReturnsAbsoluteDifference()
        {
            actual = difference.DifferenceBetween21(10);
            Assert.AreEqual(11, actual);
        }

        [TestMethod]
        public void Diff21_NumberIs21_ReturnsZero()
        {
            actual = difference.DifferenceBetween21(21);
            Assert.AreEqual(0, actual);
        }
    }
}
