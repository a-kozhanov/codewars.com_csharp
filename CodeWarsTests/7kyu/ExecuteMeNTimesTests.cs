using System;
using System.Threading;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExecuteMeNTimesTests
    {
        private readonly object monitor = new object();

        [Test]
        public void SampleTests()
        {
            ExecuteMeNTimes w = new ExecuteMeNTimes();
            Random rand = new Random();
            int counter = 20;
            int executionCounter = 0;

            Action a = () =>
            {
                Console.Write('.');
                Thread.Sleep(1000);
                lock (monitor)
                {
                    executionCounter++;
                }
            };

            w.Execute(a, 20);

            if (counter != executionCounter)
                Console.WriteLine($"Aciton was executed {executionCounter} times instead of {counter} times");

            Assert.IsTrue(counter == executionCounter);
        }
    }
}