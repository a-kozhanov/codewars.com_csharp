using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PersistentBuggerTests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, PersistentBugger.Persistence(39));
            Assert.AreEqual(0, PersistentBugger.Persistence(4));
            Assert.AreEqual(2, PersistentBugger.Persistence(25));
            Assert.AreEqual(4, PersistentBugger.Persistence(999));
        }
    }
}