using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/do-i-get-a-bonus/train/csharp
//https://www.codewars.com/kata/56f6ad906b88de513f000d96/solutions/csharp

//Do I get a bonus?
//8 kyu

//It's bonus time in the big city! The fatcats are rubbing their paws in anticipation... but who is going to make the most money?
//Build a function that takes in two arguments (salary, bonus). Salary will be an integer, and bonus a boolean.
//If bonus is true, the salary should be multiplied by 10. If bonus is false, the fatcat did not make enough money and must receive only his stated salary.
//Return the total figure the individual will receive as a string prefixed with "£" (= "\u00A3", JS and Java) or "$" (C#, C++, Ruby, Clojure, Elixir, PHP and Python, Haskell).


namespace CodeWars
{
    public class DoIGetBonus
    {
        public static string bonus_time(int salary, bool bonus)
        {
            return $"${(bonus ? salary * 10 : salary)}";
        }


        //public static string bonus_time(int salary, bool bonus)
        //{
        //    return $"${salary * (bonus ? 10 : 1)}";
        //}


        //public static string bonus_time(int salary, bool bonus) => "$" + (bonus ? salary * 10 : salary);


        //public static string bonus_time(int salary, bool bonus)
        //{
        //    return bonus ? $"${salary * 10}" : $"${salary}";
        //}


        //public static string bonus_time(int salary, bool bonus)
        //{
        //    return string.Format("${0}", bonus ? salary * 10 : salary);
        //}


        //public static string bonus_time(int salary, bool bonus)
        //{
        //    return (bonus) 
        //        ? "$" + (salary*10)
        //        : "$" + salary;
        //}



        //public static string bonus_time(int s, bool b) => b ? $"${s*10}" : $"${s}";


        //public static string bonus_time(int salary, bool bonus)
        //{
        //    return bonus == true ? "$" + salary + "0" : "$" + salary;
        //}




    }
}
