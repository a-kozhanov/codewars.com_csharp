using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StringArrayDuplicatesTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new String[] {"codewars", "picaniny", "hubububo"},
                StringArrayDuplicates.dup(new String[] {"ccooddddddewwwaaaaarrrrsssss", "piccaninny", "hubbubbubboo"}));

            Assert.AreEqual(new String[] {"abracadabra", "alote", "asese"},
                StringArrayDuplicates.dup(new String[] {"abracadabra", "allottee", "assessee"}));

            Assert.AreEqual(new String[] {"keles", "kenes"},
                StringArrayDuplicates.dup(new String[] {"kelless", "keenness"}));
        }
    }
}