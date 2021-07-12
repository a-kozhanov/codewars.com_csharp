/*
https://www.codewars.com/kata/5581a7651185fe13190000ee/csharp

7 kyu
Complete The Pattern #10 - Parallelogram

Task:
You have to write a function pattern which returns the following Pattern(See Examples) upto n rows, where n is parameter.

Rules/Note:
If the Argument is 0 or a Negative Integer then it should return "" i.e. empty string.
The length of each line = (2n-1).
Range of n is (-∞,100]
Examples:
pattern(5):

    12345
   12345 
  12345  
 12345   
12345    
pattern(10):

         1234567890
        1234567890 
       1234567890  
      1234567890   
     1234567890    
    1234567890     
   1234567890      
  1234567890       
 1234567890        
1234567890         
pattern(15):

              123456789012345
             123456789012345 
            123456789012345  
           123456789012345   
          123456789012345    
         123456789012345     
        123456789012345      
       123456789012345       
      123456789012345        
     123456789012345         
    123456789012345          
   123456789012345           
  123456789012345            
 123456789012345             
123456789012345              
pattern(20):

                   12345678901234567890
                  12345678901234567890 
                 12345678901234567890  
                12345678901234567890   
               12345678901234567890    
              12345678901234567890     
             12345678901234567890      
            12345678901234567890       
           12345678901234567890        
          12345678901234567890         
         12345678901234567890          
        12345678901234567890           
       12345678901234567890            
      12345678901234567890             
     12345678901234567890              
    12345678901234567890               
   12345678901234567890                
  12345678901234567890                 
 12345678901234567890                  
12345678901234567890            
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CompletePattern10Parallelogram
    {
        public static string Pattern(int n)
        {
            if (n < 1) return "";
            var str = string.Concat(Enumerable.Range(1, n).Select(x => x % 10));
            static string Ws(int i) => new string(' ', i);
            return string.Join("\n", Enumerable.Range(0, n).Select(i => Ws(n - i - 1) + str + Ws(i)));
            // return string.Join("\n", Enumerable.Range(0, n).Select(i => new string(' ', n - i - 1) + str + new string(' ', i)));

            // if (n < 1) return "";
            // List<string> result = new List<string>();
            // var str = string.Concat(Enumerable.Range(1, n).Select(x => x % 10));
            // for (int i = 0; i < n; i++)
            // {
            //     var s1 = new string(' ', n - i - 1);
            //     var s2 = new string(' ', i);
            //     result.Add(s1 + str + s2);
            // }
            //
            // return string.Join("\n", result);
        }
    }
}