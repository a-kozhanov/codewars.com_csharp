using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class ReversedWordsTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", KataReversedWords.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", KataReversedWords.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", KataReversedWords.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", KataReversedWords.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", KataReversedWords.ReverseWords("row row row your boat"));
        }
    }
}
