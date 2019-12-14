/*
https://www.codewars.com/kata/will-there-be-enough-space/train/csharp
https://www.codewars.com/kata/5875b200d520904a04000003/solutions/csharp

8 kyu
Will there be enough space?

The Story:
Bob is working as a bus driver. However, he has become extremely popular amongst the city's residents. With so many passengers wanting to get aboard his bus, he sometimes has to face the problem of not enough space left on the bus! He wants you to write a simple program telling him if he will be able to fit all the passengers.
Task Overview:
You have to write a function that accepts three parameters:

cap is the amount of people the bus can hold excluding the driver.
on is the number of people on the bus.
wait is the number of people waiting to get on to the bus.
If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.

Usage Examples:
Kata.Enough(10, 5, 5);
// 0, He can fit all 5 passengers
Kata.Enough(100, 60, 50);
// 10, He can't fit 10 out of 50 waiting
Documentation:
Kata.Enough Method (Int32, Int32, Int32)
Returns the number of passengers the bus cannot fit, or 0 if the bus can fit every passenger.

Syntax

public static int Enough(
int cap,
int on,
int wait
)

Parameters
cap
Type: System.Int32
The amount of people that can fit on the bus excluding the driver.

on
Type: System.Int32
The amount of people on the bus excluding the driver.

wait
Type: System.Int32
The amount of people waiting to enter the bus.

Return Value
Type: System.Int32
An integer representing how many passengers cannot fit on the bus, or 0 if every passenger can fit on the bus.
(enough 10 5 5)    ;  0 -- He can fit all 5 passengers
(enough 100 60 50) ; 10 -- He can't fit 10 of the 50 waiting
*/

using System;

namespace CodeWars
{
    public class WillThereBeEnoughSpace
    {
        public static int Enough(int cap, int on, int wait)
        {
            return cap - (on + wait) > 0 ? 0 : Math.Abs(cap - (on + wait));
        }

        //public static int Enough(int cap, int on, int wait) => Math.Max(on + wait - cap, 0);

        //public static int Enough(int cap, int on, int wait)
        //{
        //    return Math.Max(0, on + wait - cap);
        //}

        //public static int Enough(int cap, int on, int wait)
        //{
        //    return (cap - on) >= wait ? 0 : (on + wait) - cap;
        //}

    }
}