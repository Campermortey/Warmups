using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warmups.Conditionals;

namespace Warmups.Tests.Conditionals
{
    [TestClass]
    public class MischievioiusChildrenTest
    {
        private MischieviousChildren children;
        
        [TestInitialize]
        public void Initialize()
        {
            children = new MischieviousChildren();
        }
        [TestMethod]
        public void MischieviousChildren_IsTrouble()
        {
            bool actual = children.AreWeInTrouble(true, true);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void MischieviousChildren_IsTroubleNotSmile()
        {
            bool actual = children.AreWeInTrouble(false, false);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void MischieviousChildren_NotTrouble()
        {
            bool actual = children.AreWeInTrouble(true, false);
            Assert.AreEqual(false, actual);
        }
    }
}
