/*
https://www.codewars.com/kata/job-matching-number-1/train/csharp
https://www.codewars.com/kata/56c22c5ae8b139416c00175d/solutions/csharp

8 kyu
Job Matching #1

One of the simplest, yet most important factors is compensation. As developers we know how much money we need to support our lifestyle, so we generally have a rough idea of the minimum salary we would be satisfied with.

Let's give this a try. We'll create a function match which takes a candidate and a job, which will either return a boolean indicating whether the job is a valid match for the candidate.

A candidate will have a minimum salary, so it will look like this:

Candidate candidate = 
  new Candidate(MinSalary: 120000);
A job will have a maximum salary, so it will look like this:

Job job = 
  new Job(MaxSalary: 140000);
If either the candidate's minimum salary or the job's maximum salary is not present, throw an error.

For a valid match, the candidate's minimum salary must be less than or equal to the job's maximum salary. 
However, let's also include 10% wiggle room (deducted from the candidate's minimum salary) in case the candidate is a rockstar who enjoys programming on Codewars in their spare time. 
The company offering the job may be able to work something out.

*/


using System;

namespace CodeWars
{
    public class JobMatching1
    {
        public class Candidate
        {
            public int MinSalary = 0;

            public Candidate(int minSalary = 120000)
            {
                MinSalary = minSalary;
            }
        }

        public class Job
        {
            public int MaxSalary = 0;

            public Job(int MaxSalary = 80000)
            {
                this.MaxSalary = MaxSalary;
            }
        }

        public static bool Match(Candidate c, Job j)
        {
            return (c?.MinSalary == null || j?.MaxSalary == null)
                ? throw new ArgumentException()
                : c.MinSalary * 0.9 <= j.MaxSalary;
        }
    }
}