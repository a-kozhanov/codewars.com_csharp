using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.getMiddle("test"));
            Console.WriteLine(Kata.getMiddle("testing"));
            Console.WriteLine(Kata.getMiddle("middle"));
            Console.WriteLine(Kata.getMiddle("A"));

 
            Console.ReadKey();
        }
    }
}
