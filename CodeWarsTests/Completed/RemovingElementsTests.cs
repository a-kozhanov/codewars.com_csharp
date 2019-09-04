using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemovingElementsTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(new object[] { "Hello", "Hello Again" }, RemovingElements.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }));
            Assert.AreEqual(new object[] { new object[] { 1, 2 } }, RemovingElements.RemoveEveryOther(new object[] { new object[] { 1, 2 } }));
            Assert.AreEqual(new object[] { 1, 3, 5, 7, 9 }, RemovingElements.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            Assert.AreEqual(new object[] { new object[] { "Goodbye" } }, RemovingElements.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }));
            Assert.AreEqual(new object[] { }, RemovingElements.RemoveEveryOther(new object[] { }));
        }

        [Test]
        public void RandomTest([Values(1)] int a, [Random(-1, 1, 30)] double d)
        {
            RgTest rg = new RgTest((int)d * 10000);
            object[] input = rg.RandomList();
            List<object> output = new List<object>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    output.Add(input[i]);
                }
            }
            Assert.AreEqual(output.ToArray(), RemovingElements.RemoveEveryOther(input));
        }
    }

    public class RgTest
    {
        static Random _random;
        private static int _counter;
        public RgTest(int seed)
        {
            _counter = _counter + 1;
            _random = new Random(seed + _counter);
        }

        public object[] RandomList()
        {
            List<object> myList = new List<object>();
            int length = _random.Next(0, 500);
            for (int i = 0; i < length; i++)
            {
                myList.Add(_random.Next(0, 1000));
            }
            return myList.ToArray();
        }
    }
}