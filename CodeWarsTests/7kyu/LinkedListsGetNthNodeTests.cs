using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LinkedListsGetNthNodeTests
    {
        [Test, Description("tests for getting the Nth node in a linked list.")]
        public void Test()
        {
            LinkedListsGetNthNode list = LinkedListsGetNthNode.BuildOneTwoThree();

            Assert.AreEqual(1, LinkedListsGetNthNode.GetNth(list, 0).Data, "First node should be located at index 0.");
            Assert.AreEqual(2, LinkedListsGetNthNode.GetNth(list, 1).Data, "Second node should be located at index 1.");
            Assert.AreEqual(3, LinkedListsGetNthNode.GetNth(list, 2).Data, "Third node should be located at index 2.");
            Assert.Throws<ArgumentException>(() => LinkedListsGetNthNode.GetNth(list, 3),
                "Invalid index value should throw an exception.");
            Assert.Throws<ArgumentException>(() => LinkedListsGetNthNode.GetNth(list, 100),
                "Invalid index value should throw an exception.");
            Assert.Throws<ArgumentException>(() => LinkedListsGetNthNode.GetNth(null, 0),
                "Null linked list should throw an exception.");
        }
    }
}