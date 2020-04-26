using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MaxMinArraysTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(MaxMinArrays.Solve(new List<int> {15, 11, 10, 7, 12}),
                Is.EqualTo(new List<int> {15, 7, 12, 10, 11}));
            Assert.That(MaxMinArrays.Solve(new List<int> {91, 75, 86, 14, 82}),
                Is.EqualTo(new List<int> {91, 14, 86, 75, 82}));
            Assert.That(MaxMinArrays.Solve(new List<int> {84, 79, 76, 61, 78}),
                Is.EqualTo(new List<int> {84, 61, 79, 76, 78}));
            Assert.That(MaxMinArrays.Solve(new List<int> {52, 77, 72, 44, 74, 76, 40}),
                Is.EqualTo(new List<int> {77, 40, 76, 44, 74, 52, 72}));
            Assert.That(MaxMinArrays.Solve(new List<int> {1, 6, 9, 4, 3, 7, 8, 2}),
                Is.EqualTo(new List<int> {9, 1, 8, 2, 7, 3, 6, 4}));
            Assert.That(MaxMinArrays.Solve(new List<int> {78, 79, 52, 87, 16, 74, 31, 63, 80}),
                Is.EqualTo(new List<int> {87, 16, 80, 31, 79, 52, 78, 63, 74}));
        }
    }
}