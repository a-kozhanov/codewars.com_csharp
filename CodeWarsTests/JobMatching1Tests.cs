using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class JobMatching1Tests
    {
        JobMatching1.Candidate candidate = new JobMatching1.Candidate(minSalary: 120000);
        JobMatching1.Job job1 = new JobMatching1.Job(MaxSalary: 130000);
        JobMatching1.Job job2 = new JobMatching1.Job(MaxSalary: 80000);

        [Test]
        public void ShouldMatch()
        {
            Assert.AreEqual(true, JobMatching1.Match(candidate, job1));
        }

        [Test]
        public void ShouldNotMatch()
        {
            Assert.AreEqual(false, JobMatching1.Match(candidate, job2));
        }
    }
}