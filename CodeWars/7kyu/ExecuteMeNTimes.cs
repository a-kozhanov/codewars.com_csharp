/*
https://www.codewars.com/kata/5b2b4836b6989d207700005b/csharp

7 kyu
Execute me nTimes

Fix a bug in provided method which should execute a passed action n (possibly hundreds) times. 
The method is timing out and not completing in time.
*/

using System;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ExecuteMeNTimes
    {
        public void Execute(Action a, int nTimes)
        {
            Parallel.For(0, nTimes, i => a());
            //Parallel.Invoke(Enumerable.Repeat(a, nTimes).ToArray());
        }
    }
}