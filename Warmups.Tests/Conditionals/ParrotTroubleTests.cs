using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warmups.Conditionals;

namespace Warmups.Tests.Conditionals
{
    [TestClass]
    public class ParrotTroubleTests
    {
        private ParrotTrouble parrotTrouble;
        private bool actual;

        [TestInitialize]
        public void Initialize()
        {
            parrotTrouble = new ParrotTrouble();
        }

        [TestMethod]
        public void ParrotTrouble_TalkingAtSix()
        {
            actual = parrotTrouble.IsParrotTrouble(true, 6);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ParrotTrouble_TalkingAtTwelve()
        {
            actual = parrotTrouble.IsParrotTrouble(true, 12);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ParrotTrouble_TalkingAtSeven()
        {
            actual = parrotTrouble.IsParrotTrouble(true, 7);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ParrotTrouble_NotTalkingAt6()
        {
            actual = parrotTrouble.IsParrotTrouble(false, 6);
            Assert.AreEqual(false, actual);
        }
    }
}
