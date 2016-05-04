using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warmups.Conditionals;

namespace Warmups.Tests.Conditionals
{
    [TestClass]
    public class SleepingInTest
    {
        private SleepingIn sleep;

        [TestInitialize]
        public void Initialize()
        {
            sleep = new SleepingIn();
        }

        [TestMethod]
        public void SleepingIn_NotWeekdayNotVacation()
        {
            bool actual = sleep.CanSleepIn(false, false);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SleepingIn_IsWeekDayNotVacation()
        {
            bool actual = sleep.CanSleepIn(true, false);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void SleepingIn_IsNotWeekdayIsVacation()
        {
            bool actual = sleep.CanSleepIn(false, true);
            Assert.AreEqual(true, actual);
        }
    }
}
