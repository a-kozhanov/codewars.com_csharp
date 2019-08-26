using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//https://www.codewars.com/kata/printer-errors/csharp
//https://www.codewars.com/kata/printer-errors/solutions/csharp

//Printer Errors

//    In a factory a printer prints labels for boxes.For one kind of boxes the printer has to use colors which, for the sake of simplicity,
// are named with letters from a to m.
//    The colors used by the printer are recorded in a control string. For example a "good" control string would be aaabbbbhaijjjm
// meaning that the printer used three times color a, four times color b, one time color h then one time color a...
//    Sometimes there are problems: lack of colors, technical malfunction and a "bad" control string is produced e.g.aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.
//    You have to write a function printer_error which given a string will output the error rate of the printer as a string
// representing a rational whose numerator is the number of errors and the denominator the length of the control string. Don't reduce this fraction to a simpler expression.
//    The string has a length greater or equal to one and contains only letters from ato z.

//#Examples:
//    s= "aaabbbbhaijjjm"
//    error_printer(s) => "0/14"

//    s= "aaaxbbbbyyhwawiwjjjwwm"
//    error_printer(s) => "8/22"


namespace CodeWars
{
    public class PrinterErrors
    {
        public static string PrinterError(string s)
        {
            return s.Count(c => c > 'm') + "/" + s.Length;
        }

        //Best Practices
        //public static string PrinterError(string s)
        //{
        //    return s.Where(c => c > 'm').Count() + "/" + s.Length;
        //}

    }
}
