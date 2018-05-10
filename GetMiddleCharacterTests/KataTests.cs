using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetMiddleCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMiddleCharacter.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void getMiddleTest()
        {
            Assert.AreEqual("es", Kata.getMiddle("test"));
            Assert.AreEqual("t", Kata.getMiddle("testing"));
            Assert.AreEqual("dd", Kata.getMiddle("middle"));
            Assert.AreEqual("A", Kata.getMiddle("A"));
        }
    }
}