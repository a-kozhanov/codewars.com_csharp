using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Ch4113ng3Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Ch4113ng3.Nerdify("Fund4m3nt41s"), Is.EqualTo("Fund4m3nt41s"));
            Assert.That(Ch4113ng3.Nerdify("Seven"), Is.EqualTo("S3v3n"));
            Assert.That(Ch4113ng3.Nerdify("Los Angeles"), Is.EqualTo("Los 4ng313s"));
            Assert.That(Ch4113ng3.Nerdify("Seoijselawuue"), Is.EqualTo("S3oijs314wuu3"));
        }

        [Test]
        public void ErrorTest()
        {
            Assert.That(() => Ch4113ng3.Nerdify(null), Throws.TypeOf(typeof(ArgumentNullException)));
        }
    }
}