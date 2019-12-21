using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class UnfinishedLoopBugFixing1Tests
    {
        [Test]
        public static void FixedTest()
        {
            List<int> myValues = new List<int>(new int[] { 1 });
            Assert.AreEqual(myValues, UnfinishedLoopBugFixing1.CreateList(1));

            myValues = new List<int>(new int[] { 1, 2 });
            Assert.AreEqual(myValues, UnfinishedLoopBugFixing1.CreateList(2));

            myValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.AreEqual(myValues, UnfinishedLoopBugFixing1.CreateList(6));
        }
    }
}