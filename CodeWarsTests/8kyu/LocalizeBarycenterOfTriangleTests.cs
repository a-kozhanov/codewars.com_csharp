using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LocalizeBarycenterOfTriangleTests
    {
        [Test]
        public static void test1() {
            Console.WriteLine("Fixed Tests");  
            Assert.AreEqual(new double[] {8.6667, 6.6667}, LocalizeBarycenterOfTriangle.BarTriang(
                new double[]{4,6}, new double[]{12,4}, new double[]{10,10}));
            Assert.AreEqual(new double[] {7.3333, 4.6667}, LocalizeBarycenterOfTriangle.BarTriang(
                new double[]{4,2}, new double[]{12,2}, new double[]{6,10}));
        }      
    }
}