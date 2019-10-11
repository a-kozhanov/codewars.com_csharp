using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BeginnerSeriesCockroachTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(30, BeginnerSeriesCockroach.CockroachSpeed(1.08));
            Assert.AreEqual(30, BeginnerSeriesCockroach.CockroachSpeed(1.09));
            Assert.AreEqual(0, BeginnerSeriesCockroach.CockroachSpeed(0));
        }
    }
}