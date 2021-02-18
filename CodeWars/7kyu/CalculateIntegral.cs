/*
https://www.codewars.com/kata/55d32bff0cc60b2e7f000173/csharp

7 kyu
Calculate Integral

##What are you dealing with...

You're a clever programmer and too lazy to calculate integrals by your own!
So you decide to write a method which will do your calculations.

You got a linear function y = m * x + b and this is the code that is already existing:

public class LinFunc
{
  public double M { get; set; }
  public double B { get; set; }

  public double GetY(double x)
  {
    // not implemented
  }

  public double CalcIntegral(int a, int b)
  {
    // not implemented
  }
}
##TODO Here it is up to you! Implement the missing code for these two methods GetY(double x) and CalcIntegral(int from, int to).
*/

namespace CodeWars
{
    public class CalculateIntegral
    {
        public double M { get; set; }
        public double B { get; set; }
        public double GetY(double x) => M * x + B;
        public double CalcIntegral(int from, int to) => GetY((to + from) / 2d) * (to - from);
    }
}