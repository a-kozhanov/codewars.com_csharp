using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TimeDegreesTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("30:6", TimeDegrees.ClockDegree("01:01"));
            Assert.AreEqual("360:360", TimeDegrees.ClockDegree("00:00"));
            Assert.AreEqual("30:18", TimeDegrees.ClockDegree("01:03"));
            Assert.AreEqual("30:180", TimeDegrees.ClockDegree("01:30"));
            Assert.AreEqual("360:30", TimeDegrees.ClockDegree("12:05"));
            Assert.AreEqual("Check your time !", TimeDegrees.ClockDegree("26:78"));
            Assert.AreEqual("Check your time !", TimeDegrees.ClockDegree("23:60"));
            Assert.AreEqual("Check your time !", TimeDegrees.ClockDegree("24:60"));
            Assert.AreEqual("120:150", TimeDegrees.ClockDegree("16:25"));
            Assert.AreEqual("150:54", TimeDegrees.ClockDegree("17:09"));
            Assert.AreEqual("210:360", TimeDegrees.ClockDegree("19:00"));
            Assert.AreEqual("240:204", TimeDegrees.ClockDegree("20:34"));
            Assert.AreEqual("330:120", TimeDegrees.ClockDegree("23:20"));
            Assert.AreEqual("Check your time !", TimeDegrees.ClockDegree("24:00"));
            Assert.AreEqual("Check your time !", TimeDegrees.ClockDegree("-09:00"));
        }
    }
}