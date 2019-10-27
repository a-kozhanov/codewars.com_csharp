using CodeWars;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    class L1SetAlarmTests
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(false, L1SetAlarm.SetAlarm(true, true));
            Assert.AreEqual(false, L1SetAlarm.SetAlarm(false, true));
            Assert.AreEqual(true, L1SetAlarm.SetAlarm(true, false));
            Assert.AreEqual(false, L1SetAlarm.SetAlarm(false, false));
        }
    }
}
