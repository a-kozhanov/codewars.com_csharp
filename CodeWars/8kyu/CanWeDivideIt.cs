
//https://www.codewars.com/kata/can-we-divide-it/train/csharp
//https://www.codewars.com/kata/5a2b703dc5e2845c0900005a/solutions/csharp

//Can we divide it?
//8 kyu

//Your task is to create functionisDivideBy (or is_divide_by) to check if an integer number is divisible by each out of two arguments.

//A few cases:
//(-12, 2, -6)  ->  true
//(-12, 2, -5)  ->  false

//(45, 1, 6)    ->  false
//(45, 5, 15)   ->  true

//(4, 1, 4)     ->  true
//(15, -5, 3)   ->  true


namespace CodeWars
{
    public class CanWeDivideIt
    {
        public static bool is_divide_by(int number, int a, int b)
        {
            return number % a == 0 && number % b == 0;
        }
    }
}