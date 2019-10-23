using System;
using System.Linq;


//https://www.codewars.com/kata/swap-values/train/csharp
//https://www.codewars.com/kata/5388f0e00b24c5635e000fc6/solutions/csharp

//8 kyu
//Swap Values

//I would like to be able to pass an array with two elements to my swapValues function to swap the values.
//However it appears that the values aren't changing.
//Can you figure out what's wrong here?


namespace CodeWars
{
    public class KataSwapValues
    {
        public object[] Arguments { get; private set; }

        public KataSwapValues(object[] args)
        {
            Arguments = args;
        }

        public void SwapValues()
        {
            //object[] args = new[] { Arguments[0], Arguments[1] };

            //object temp = args[0];
            //args[0] = args[1];
            //args[1] = temp;

            Array.Reverse(Arguments);
        }
    }
}


//public class Swapper
//{
//    public object[] Arguments { get; private set; }

//    public Swapper(object[] args)
//    {
//        Arguments = args;
//    }

//    public void SwapValues()
//    {
//        object temp = Arguments[0];
//        Arguments[0] = Arguments[1];
//        Arguments[1] = temp;
//    }
//}


//public class Swapper
//{
//    public object[] Arguments { get; private set; }

//    public Swapper(object[] args)
//    {
//        Arguments = args;
//    }

//    public void SwapValues()
//    {
//        object[] args = new[] { Arguments[0], Arguments[1] };

//        Arguments[0] = args[1];
//        Arguments[1] = args[0];
//    }
//}



//public class Swapper
//{
//    public object[] Arguments { get; private set; }

//    public Swapper(object[] args)
//    {
//        Arguments = args;
//    }

//    public void SwapValues()
//    {
//        System.Array.Reverse(Arguments);
//    }
//}


//public class Swapper
//{
//    public object[] Arguments { get; private set; }

//    public Swapper(object[] args)
//    {
//        Arguments = args;
//    }

//    public void SwapValues()
//    {
//        object[] args = new[] { Arguments[0], Arguments[1] };

//        object temp = args[0];
//        temp = args[0];
//        Arguments[0] = args[1];
//        Arguments[1] = temp;
//    }
//}