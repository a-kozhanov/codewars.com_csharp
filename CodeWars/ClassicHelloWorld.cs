
/*
https://www.codewars.com/kata/classic-hello-world/train/csharp
https://www.codewars.com/kata/57036f007fd72e3b77000023/solutions/csharp

8 kyu
Classic Hello World

The main mode is having a method named main inside a class and should return nothing but should print a line to the standard output with the message Hello World! 
i.e. print the line Hello World! to the console. 
For Java the main method should receive String array as parameters that can be specified when running from console with the command. 
In many traditional programming languages can be only one main for a whole application since it denotes the application entry point.

Solution.Main("parameter1", "parameter2","parametern")

Hints:

Check your references
Think about the scope of your method
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class ClassicHelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}