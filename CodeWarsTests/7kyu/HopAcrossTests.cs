using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataHopAcrossTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(KataHopAcross.HopAcross(new List<int> {1}), Is.EqualTo(2));
            Assert.That(KataHopAcross.HopAcross(new List<int> {2}), Is.EqualTo(2));
            Assert.That(KataHopAcross.HopAcross(new List<int> {1, 1}), Is.EqualTo(4));
            Assert.That(KataHopAcross.HopAcross(new List<int> {2, 1}), Is.EqualTo(3));
            Assert.That(KataHopAcross.HopAcross(new List<int> {2, 1, 1}), Is.EqualTo(5));
            Assert.That(KataHopAcross.HopAcross(new List<int> {1, 2, 1, 2}), Is.EqualTo(5));
            Assert.That(KataHopAcross.HopAcross(new List<int> {1, 2, 5, 1}), Is.EqualTo(5));
            Assert.That(KataHopAcross.HopAcross(new List<int> {2, 2, 3, 1, 1, 2, 1}), Is.EqualTo(7));
        }
    }
}