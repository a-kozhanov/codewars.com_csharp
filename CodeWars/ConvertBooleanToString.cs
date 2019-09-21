
//https://www.codewars.com/kata/convert-a-boolean-to-a-string/train/csharp
//https://www.codewars.com/kata/551b4501ac0447318f0009cd/solutions/csharp

//Convert a Boolean to a String

//In this programming exercise, you're going to learn about functions, boolean (true/false) values, strings, and the if-statement.
//A function is a block of code that takes an input and produces an output. In this example,
//boolean_to_string is a function whose input is either true or false, and whose output is the string representation of the input,
//either "true"/"True" or "false"/"False" (check the sample tests about what capitalization to use in a given language).
//A common idea we often want to represent in code is the concept of true and false. A variable that can either be true or false is called a boolean variable.
//In this example, the input to boolean_to_string (represented by the variable b) is a boolean.
//Lastly, when we want to take one action if a boolean is true, and another if it is false, we use an if-statement.
//For this kata, don't worry about edge cases like where unexpected input is passed to the function. You'll get to worry about these enough in later exercises.


using System;

namespace CodeWars
{
    public class ConvertBooleanToString
    {
        public static string boolean_to_string(bool b)
        {
            return Convert.ToString(b);
        }


        //public static string boolean_to_string(bool b)
        //{
        //    return b.ToString();
        //}


        //public static string boolean_to_string(bool b)
        //{
        //    return b?"True":"False";
        //}


        //public static string boolean_to_string(bool b) => b.ToString();


        //public static string boolean_to_string(bool b)
        //{
        //    return b + "";
        //}

        //public static string boolean_to_string(bool b)
        //    => Convert.ToString(b);


        //public static string boolean_to_string(bool b)
        //{
        //    return string.Format("{0}",b);
        //}

        //public static string boolean_to_string(bool b)
        //{
        //    string response;

        //    if( b == true){
        //        response = "True";
        //    }
        //    else{
        //        response = "False";
        //    }
        //    return response;
        //}


        //public static string boolean_to_string(bool b)
        //{
        //    string c = b ? "True" : "False";
        //    return c;
        //}

        //public static string boolean_to_string(bool b)
        //{
        //    return Convert.ToInt64(b) == 1? "True": "False";
        //}

    }
}