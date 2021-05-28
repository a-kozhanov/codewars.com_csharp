using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LinkedListsPushBuildOneTwoThreeTests
    {
        [Test, Description("tests for inserting a node before another node.")]
        public void pushTests()
        {
            Assert.AreEqual(1, LinkedListsPushBuildOneTwoThree.Push(null, 1).Data,
                "Should be able to create a new linked list with push().");
            Assert.AreEqual(null, LinkedListsPushBuildOneTwoThree.Push(null, 1).Next,
                "Should be able to create a new linked list with push().");
            Assert.AreEqual(2, LinkedListsPushBuildOneTwoThree.Push(new LinkedListsPushBuildOneTwoThree(1), 2).Data,
                "Should be able to prepend a node to an existing node.");
            Assert.AreEqual(1,
                LinkedListsPushBuildOneTwoThree.Push(new LinkedListsPushBuildOneTwoThree(1), 2).Next.Data,
                "Should be able to prepend a node to an existing node.");
        }

        [Test, Description("tests for building a linked list.")]
        public void buildTests()
        {
            Assert.AreEqual(1, LinkedListsPushBuildOneTwoThree.BuildOneTwoThree().Data,
                "First node should should have 1 as data.");
            Assert.AreEqual(2, LinkedListsPushBuildOneTwoThree.BuildOneTwoThree().Next.Data,
                "Second node should should have 2 as data.");
            Assert.AreEqual(3, LinkedListsPushBuildOneTwoThree.BuildOneTwoThree().Next.Next.Data,
                "Third node should should have 3 as data.");
            Assert.AreEqual(null, LinkedListsPushBuildOneTwoThree.BuildOneTwoThree().Next.Next.Next,
                "Third node should be the tail of the linked list");
        }
    }
}