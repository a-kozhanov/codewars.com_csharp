/*
https://www.codewars.com/kata/58cfa163c496ce8856000064/csharp

7 kyu
Custom Accessors

In this Kata you need to fill in the public 'get' and 'set' accessor bodies for the NumericAccessor class.

This simple class is meant to do several things:
Check if the value being assigned (set) is divisible by 2.
If it is, then save it.
If not then raise an ArgumentException.
When trying to read the value (get), return the saved value divided by 2.

For example:

var instance = new NumericAccessor();
instance.Number = 2;
Console.WriteLine("Getter returned: " + instance.Number);
Getter returned: 1

Another example:

var instance = new NumericAccessor();
instance.Number = 3;
ArgumentException value not divisble by 2

You don't need any extra methods or fields.

While this example is arbitrary, 
it serves to demontrate how a class can 'filter' its data when accessed externally (a nice feature to prevent mistakes in a shared code base). 
Note - this is just 1 of at least 2 ways to write accessors in C#, and doesn't touch on access privelage levels.

Hint: in your setter, you'll need to use the keyword 'value'.

An aside: the tests are using reflection to directly access the private field _number, 
so if it isn't actually updated to the correct value the tests will know.
*/

using System;

namespace CodeWars
{
    public class CustomAccessors
    {
        private int _number;

        public int Number
        {
            get => _number / 2;
            set => _number = value % 2 == 0 ? value : throw new ArgumentException($"Value {value} not divisible by 2");


            // get => _number / 2;
            // set => _number = value % 2 == 0
            //     ? value
            //     : throw new ArgumentException("Number should be divisible by two", $"{value}");


            // get { return _number / 2; }
            // set
            // {
            //     if ((value & 1) == 0) _number = value;
            //     else throw new System.ArgumentException();
            // }
        }
    }
}