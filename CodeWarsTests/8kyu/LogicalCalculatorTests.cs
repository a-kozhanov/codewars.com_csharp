using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class LogicalCalculatorTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, true, true, false }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true, true, false }, "OR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true, true, false }, "XOR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, true, false, false }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true, false, false }, "OR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, true, false, false }, "XOR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, false, false, false }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, false, false, false }, "OR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, false, false, false }, "XOR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true }, "OR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, true }, "XOR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false, false }, "AND"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false, false }, "OR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false, false }, "XOR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false }, "AND"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false }, "OR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false }, "XOR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true }, "OR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true }, "XOR"));
        }
    }
}
