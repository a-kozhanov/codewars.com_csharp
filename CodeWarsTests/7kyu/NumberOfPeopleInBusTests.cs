using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumberOfPeopleInBusTests
    {
        [Test]
        public void FirstTest()
        {
            List<int[]> peopleList = new List<int[]>() {new[] {10, 0}, new[] {3, 5}, new[] {5, 8}};
            Assert.AreEqual(5, NumberOfPeopleInBus.Number(peopleList));
        }

        [Test]
        public void SecondTest()
        {
            List<int[]> peopleList = new List<int[]>()
                {new[] {3, 0}, new[] {9, 1}, new[] {4, 10}, new[] {12, 2}, new[] {6, 1}, new[] {7, 10}};
            Assert.AreEqual(17, NumberOfPeopleInBus.Number(peopleList));
        }

        [Test]
        public void ThirdTest()
        {
            List<int[]> peopleList = new List<int[]>()
                {new[] {3, 0}, new[] {9, 1}, new[] {4, 8}, new[] {12, 2}, new[] {6, 1}, new[] {7, 8}};
            Assert.AreEqual(21, NumberOfPeopleInBus.Number(peopleList));
        }
    }
}