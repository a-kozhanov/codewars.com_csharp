using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MakeMeSlowTests
    {
        [Test]
        public void Test()
        {
            DateTime start = DateTime.Now;
            KataMakeMeSlow.MakeMeSlow();
            Assert.IsTrue((DateTime.Now - start).TotalMilliseconds >= 7000);
        }
    }
}