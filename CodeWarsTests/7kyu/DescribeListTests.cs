using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DescribeListTests
    {
        List<int> empty = new List<int>();
        List<int> one = new List<int>() {1};

        List<int> moreThan = new List<int>() {2, 3};

        [Test]
        public void MyTest()
        {
            Assert.AreEqual("empty", DescribeList.describeList(empty));
            Assert.AreEqual("singleton", DescribeList.describeList(one));
            Assert.AreEqual("longer", DescribeList.describeList(moreThan));
        }
    }
}