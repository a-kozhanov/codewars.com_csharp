using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AlphabetSymmetryTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.That(AlphabetSymmetry.Solve(new List<string> {"abode", "ABc", "xyzD"}),
                Is.EqualTo(new List<int> {4, 3, 1}));

            Assert.That(AlphabetSymmetry.Solve(new List<string> {"abide", "ABc", "xyz"}),
                Is.EqualTo(new List<int> {4, 3, 0}));

            Assert.That(AlphabetSymmetry.Solve(new List<string> {"IAMDEFANDJKL", "thedefgh", "xyzDEFghijabc"}),
                Is.EqualTo(new List<int> {6, 5, 7}));

            Assert.That(AlphabetSymmetry.Solve(new List<string> {"encode", "abc", "xyzD", "ABmD"}),
                Is.EqualTo(new List<int> {1, 3, 1, 3}));
        }
    }
}