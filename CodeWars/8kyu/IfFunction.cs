
/*
https://www.codewars.com/kata/the-if-function/train/csharp
https://www.codewars.com/kata/54147087d5c2ebe4f1000805/solutions/csharp

8 kyu
The 'if' function

Who likes keywords? Nobody likes keywords, so why use them?

You know what keyword I use too much? if! We should make a function called _if, 
with its arguments as a logical test and two functions/lambdas where the first function is executed if the boolean is true, 
and the second if it's false, like an if/else statement, so that we don't have to mess around with those nasty keywords! 
Even so, It should support truthy/falsy types just like the keyword.

Example:
Kata.If(true, () => Console.WriteLine("True"), () => Console.WriteLine("False"));
// write "True" to console

*/


using System;

namespace CodeWars
{
    public class IfFunction
    {
        public static void If(bool condition, Action func1, Action func2)
        {
            if (condition)
                func1();
            else
                func2();
        }


        //public static void If(bool condition, Action func1, Action func2)
        //{
        //    (condition ? func1 : func2)();
        //}


        //public static void If(bool condition, Action func1, Action func2)
        //{
        //    if(condition)
        //    {
        //        func1.Invoke();
        //    }
        //    else
        //    {
        //        func2.Invoke();
        //    }
        //}


        //public static void If(bool condition, Action func1, Action func2)
        //{
        //    (condition ? (Action)func1 : func2)();          
        //}

        //public static void If(bool condition, Action func1, Action func2)
        //{
        //    Action ex = condition ? func1: func2;
        //    ex();
        //}


        //public static void If(bool condition, Action func1, Action func2)
        //{
        //    (condition ? func1 : func2).Invoke();
        //}


        //public static void If(bool condition, Action ifAction, Action elseAction) => (condition ? ifAction : elseAction)();


        //public static void If(bool condition, Action func1, Action func2)
        //{
        //    var action =  condition == true ? func1 : func2;
        //    action.Invoke();
        //}


        //public static void If(bool condition, Action func1, Action func2)  =>  new Action(condition? func1: func2).Invoke();



    }
}